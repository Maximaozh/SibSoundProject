using NAudio.Utils;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioData
{
    public enum Status
    {
        Done,
        Failed,
        Exception
    }
    public class AudioData
    {
        #region Поля и конструкторы

        private ushort _bitsPerSample;
        private ushort _channels;
        private uint _sampleRate;
        private List<float> _samples;

        public AudioData()
        {
            Samples = new List<float>();
            Samples.Add(0);
            SampleRate = 44100;
            BitsPerSample = 16;
            Channels = 2;
        }

        public AudioData(List<float> samples, uint sampleRate, ushort bitsPerSample, ushort channels)
        {
            Samples = samples;
            SampleRate = sampleRate;
            BitsPerSample = bitsPerSample;
            Channels = channels;
        }

        #endregion Поля и конструкторы

        #region Свойства

        public ushort BitsPerSample
        {
            get
            {
                return _bitsPerSample;
            }
            set
            {
                _bitsPerSample = value;
            }
        }

        public ushort Channels
        {
            get
            {
                return _channels;
            }
            set
            {
                _channels = value;
            }
        }

        public uint SampleRate
        {
            get
            {
                return _sampleRate;
            }
            set
            {
                _sampleRate = value;
            }
        }

        public List<float> Samples
        {
            get
            {
                if (_samples == null)
                    return new List<float>();
                return _samples;
            }
            set
            {
                if (value != null)
                    _samples = value;
            }
        }

        private WaveOut CurrentWaveOut { get; set; }

        #endregion Свойства

        #region Функции

        /// <summary>
        /// Возвращает количество добавленных сэмплов
        /// </summary>
        public void ChangeSampleRate(uint newSampleRate)
        {
            this.Save(".originalAudio.wav");
            string audioFilePath = ".originalAudio.wav";
            var audioFileReader = new AudioFileReader(audioFilePath);

            var resampler = new MediaFoundationResampler(audioFileReader, new WaveFormat((int)newSampleRate, BitsPerSample, Channels));
            resampler.ResamplerQuality = 60;

            string outputFile = ".outputAudio.wav";
            using (var waveWriter = new WaveFileWriter(outputFile, resampler.WaveFormat))
            {
                byte[] buffer = new byte[16384];
                while (resampler.Read(buffer, 0, buffer.Length) > 0)
                {
                    waveWriter.Write(buffer, 0, buffer.Length);
                }
            }

            resampler.Dispose();
            audioFileReader.Dispose();

            var newAudio = new AudioData();
            newAudio.Load(outputFile);
            this.Samples = newAudio.Samples;
            this.SampleRate = newAudio.SampleRate;
        }

        public static bool CompareFormat(AudioData a, AudioData b)
        {
            if (a.SampleRate != b.SampleRate) return false;
            if (a.Channels != b.Channels) return false;
            if (a.BitsPerSample != b.BitsPerSample) return false;

            return true;
        }

        /// <summary>
        /// Преобразует сэмплы в поток MemoryStream для его последующего воспроизведения в NAudio
        /// </summary>
        public byte[] FloatArrayToByteArray()
        {
            byte[] byteArray = new byte[Samples.Count * sizeof(float)];
            Buffer.BlockCopy(Samples.ToArray(), 0, byteArray, 0, byteArray.Length);
            return byteArray;
        }

        /// <summary>
        /// Преобразует данные о аудио в классе в WaveFormat NAudio
        /// </summary>
        public WaveFormat FormatToWaveFormat()
        {
            return new WaveFormat((int)SampleRate, BitsPerSample, (int)Channels);
        }

        /// <summary>
        /// Возвращает текущее время воспроизведения в секундах
        /// </summary>
        public double GetCurrentPlayTime()
        {
            return CurrentWaveOut.GetPositionTimeSpan().TotalSeconds;
        }

        public List<float> GetFrame(int index)
        {
            if (index < 0 || index + Channels + 1 >= Samples.Count) return null;

            return Samples.GetRange(index, Channels);
        }

        /// <summary>
        /// Возвращает сэмплы левого канала и сэмплы моно звука
        /// </summary>
        public List<float> GetLeftChannel()
        {
            var leftChannel = new List<float>();

            if (Channels == 1)
                leftChannel.AddRange(Samples);
            else if (Channels == 2)
            {
                for (int i = 0; i < Samples.Count; i += 2)
                    leftChannel.Add(Samples[i]);
            }

            return leftChannel;
        }

        /// <summary>
        /// Возвращает сэмплы правого канала
        /// </summary>
        public List<float> GetRightChannel()
        {
            var leftChannel = new List<float>();

            if (Channels == 2)
            {
                for (int i = 1; i < Samples.Count; i += 2)
                    leftChannel.Add(Samples[i]);
            }

            return leftChannel;
        }

        /// <summary>
        /// Возвращает состояние воспроизведения аудио
        /// </summary>
        public bool IsPlaying()
        {
            if (CurrentWaveOut == null) return false;
            return CurrentWaveOut.PlaybackState == PlaybackState.Playing;
        }

        /// <summary>
        /// Загружает данные из файла формата MP3 или WAV
        /// </summary>
        public Status Load(string pathToFile)
        {
            if (!File.Exists(pathToFile))
                return Status.Failed;

            if (pathToFile.Contains(".wav"))
                return LoadWav(pathToFile);

            if (pathToFile.Contains(".mp3"))
                LoadMp3(pathToFile);

            return Status.Done;
        }

        /// <summary>
        /// Проводит глубокое копирование из одного аудио-объетка в данный
        /// </summary>
        public Status Load(AudioData origin)
        {
            Samples = new List<float>();
            Samples.AddRange(origin.Samples);

            LoadFormat(origin);

            return Status.Done;
        }

        /// <summary>
        /// Загружает данные о формате аудио
        /// </summary>
        public Status LoadFormat(AudioData origin)
        {
            SampleRate = origin.SampleRate;
            BitsPerSample = origin.BitsPerSample;
            Channels = origin.Channels;

            return Status.Done;
        }

        /// <summary>
        /// Воспроизводит преобразованный в массив байт сэмплы при помощи NAudio
        /// </summary>
        public void Play(int Amplification, int Balance)
        {
            float leftPower = (10 - Balance)/10.0f;
            float rightPower = (10 + Balance)/10.0f;

            if(Channels == 2)
            for(int i = 0; i < Samples.Count; i++) 
            {
                    if (i % 2 == 0)
                        Samples[i] *= leftPower;
                    else 
                        Samples[i] *= rightPower;

                    if (Samples[i] >= 1) Samples[i] = 1;
                    else if (Samples[i] <= -1) Samples[i] = -1;
            }

            float gain = (float)Math.Pow(10, Amplification / 20);

            for (int i = 0; i < Samples.Count; i++)
            {
                Samples[i] *= gain;

                if (Samples[i] >= 1) Samples[i] = 1;
                else if (Samples[i] <= -1) Samples[i] = -1;
            }


            MemoryStream memoryStream = new MemoryStream(FloatArrayToByteArray());
            {
                using (var waveStream = new RawSourceWaveStream(memoryStream, WaveFormat.CreateIeeeFloatWaveFormat((int)SampleRate, Channels)))
                {
                    CurrentWaveOut = new WaveOut();
                    CurrentWaveOut.Init(waveStream);
                    CurrentWaveOut.Play();
                }
            }
        }

        /// <summary>
        /// Сохраняет аудио-объект в файл, преобразуя данные в WaveFormat и записывая сэмплы в файл поочерёдно (необходимо указывать файл с расширением!)
        /// </summary>
        public Status Save(string fileName)
        {
            var format = new WaveFormat((int)SampleRate, BitsPerSample, (int)Channels);
            using (WaveFileWriter writer = new WaveFileWriter(fileName, format))
                Samples.ForEach((float x) => { writer.WriteSample(x); });

            return Status.Done;
        }

        /// <summary>
        /// Останавливает воспроизведение аудио
        /// </summary>
        public void Stop()
        {
            CurrentWaveOut.Stop();
        }

        /// <summary>
        /// Возвращает время аудиодорожки в секундах
        /// </summary>
        public float TimeInSeconds()
        {
            return Samples.Count / SampleRate / _channels;
        }

        /// <summary>
        /// Загружает данные из файла формата MP3, преобразуя в WAV, по абсолютному и относительному пути
        /// </summary>
        private Status LoadMp3(string pathToFile)
        {
            string wavName = pathToFile.Substring(0, pathToFile.Length - 3) + "wav";

            using (var reader = new Mp3FileReader(pathToFile))
            {
                WaveFileWriter.CreateWaveFile(wavName, reader);
            }

            return LoadWav(wavName);
        }

        /// <summary>
        /// Загружает данные из файла формата WAV по абсолютному и относительному пути
        /// </summary>
        private Status LoadWav(string pathToFile)
        {
            using (var reader = new WaveFileReader(pathToFile))
            {
                Samples = new List<float>();

                while (true)
                {
                    var frame = reader.ReadNextSampleFrame();
                    if (frame == null)
                        break;
                    Samples.AddRange(frame);
                }
                var format = reader.WaveFormat;

                SampleRate = (uint)format.SampleRate;
                BitsPerSample = (ushort)format.BitsPerSample;
                Channels = (ushort)format.Channels;

                return Status.Done;
            }
        }

        #endregion Функции
    }
}
