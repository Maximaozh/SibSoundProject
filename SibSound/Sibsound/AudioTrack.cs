using Sibsound.Audios;
using Sibsound.Editors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AudioData;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Sibsound.Secures;

namespace Sibsound
{
    public partial class AudioTrack : UserControl
    {
        [Serializable]
        public struct AudioDataStructure
        {
            public float[] samples;
            public int channels;
            public int bitsPerSample;
            public int sampleRate;
        }

        public AudioData.AudioData audio;
        public int begin;
        public int end;
        public AudioTrack()
        {

            // Настройка компонентов формы
            //--- Логгер
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Logger\\Logger.exe";
            SetLoggerExecutable(path);
            LoggerExecutable.StartInfo.CreateNoWindow = true;
            LoggerExecutable.StartInfo.UseShellExecute = false;

            // Установка рисующих инструментов
            WaveFormPen = new Pen(Color.LightCoral, 0.5f);
            CentralLinePen = new Pen(Color.White, 2);
            ChartScale = 1;
            Draw = () => { };
            //----

            // Установка дефолтных значений для аудио
            Audio = new AudioData.AudioData();
            AudioSelected = new AudioData.AudioData();
            Editor = new BasicAudioEditor();
            begin = 0;
            end = 0;
            //----
            InitializeComponent();
            ScaleLabel.Text = ChartScale.ToString();
            SelectedSampleBeginLabel.Text = "-1";
            SelectedSampleEndLabel.Text = "-1";
            Configure();
            Draw();
            //----
            //раздел защиты
            var verifier = new Verify();
            var accessbits = verifier.VerifyKey();

               if(accessbits[0] == 0) 
                 this.CopySegmentButton.Hide();
            if (accessbits[1] == 0) 
                 this.CutSegmentButton.Hide();
               if(accessbits[2] == 0) 
                 this.InsertSegmentButton.Hide();
            if (accessbits[3] == 0) 
                 this.DeleteSegmentButton.Hide();
        }

        public delegate void DrawFunction();

        public AudioData.AudioData Audio { get { return audio; } set { audio = value; } }
        public AudioData.AudioData AudioSelected { get; set; }
        public Pen CentralLinePen { get; set; }
        public float ChartScale { get; set; }
        public DrawFunction Draw { get; set; }
        public IAudioEditor Editor { get; set; }
        public int SelectedSampleBegin { get; set; }
        public int SelectedSampleEnd { get; set; }
        public Pen WaveFormPen { get; set; }
        private Process LoggerExecutable { get; set; }

        public bool CalculateFrameBorders(out int begin, out int end)
        {
            begin = 0;
            end = 0;

            if (Audio == null)
                return false;
            int audioLenghtInSeconds = (int)(Audio.Samples.Count / Audio.SampleRate / Audio.Channels * ChartScale);
            int audioLenghtInSquareSeconds = audioLenghtInSeconds * 4;

            begin = (int)(SelectedSampleBeginTrackBar.Value / 4 / ChartScale * Audio.SampleRate * Audio.Channels);
            end = (int)(SelectedSampleEndTrackBar.Value / 4 / ChartScale * Audio.SampleRate * Audio.Channels);
            this.begin = (int)begin;
            this.end = (int)end;
            return true;
        }

        public void Configure()
        {
            if (Audio == null)
                return;

            int audioLenghtInSeconds = (int)(Audio.Samples.Count / Audio.SampleRate / Audio.Channels * ChartScale);
            int audioLenghtInSquareSeconds = audioLenghtInSeconds * 4;

            ChannelsLayoutPanel.Width = audioLenghtInSquareSeconds;
            SelectedSampleBeginTrackBar.Maximum = audioLenghtInSquareSeconds;
            SelectedSampleEndTrackBar.Maximum = audioLenghtInSquareSeconds;

            LeftChannelPictureBox.Width = (int)(LeftChannelPictureBox.Width * ChartScale);
            RightChannelPictureBox.Width = (int)(RightChannelPictureBox.Width * ChartScale);
        }

        private void AddAudioFromFileButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Wave (.wav)|*.wav|MP3 (.mp3)|*.mp3";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string selectedFileName = "";
            selectedFileName = openFileDialog.FileName;

            var addAudio = new AudioData.AudioData();
            addAudio.Load(selectedFileName);

            if (addAudio.SampleRate != this.Audio.SampleRate)
                addAudio.ChangeSampleRate(this.Audio.SampleRate);
            this.Audio.Samples.AddRange(addAudio.Samples);

            Configure();
            Draw();


            LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%Работа%Добавление ещё аудиофайла " + selectedFileName +"%";
            LoggerExecutable.Start();
        }

        private void AmplificationTrackBar_Scroll(object sender, EventArgs e)
        {
            AmplificationCurrentValueToolTip.SetToolTip(AmplificationTrackBar, $"Усиление: {AmplificationTrackBar.Value} Дб");
        }

        private void AudioTimer_Tick(object sender, EventArgs e)
        {
            var beginValue = (float)SelectedSampleBeginTrackBar.Value / 4 / ChartScale;
            TimerLabel.Text = (beginValue + AudioSelected.GetCurrentPlayTime()).ToString() + " сек";
        }

        private float AverageSample(List<float> samples)
        {
            float avg = 0;

            foreach (var sample in samples)
            {
                if (sample > 0)
                    avg += sample + 1;
                else
                    avg += -sample + 1;
            }

            return avg / samples.Count / 2;
        }

        private void BalanceTrackBar_Scroll(object sender, EventArgs e)
        {
            int balanceTrackBarValue = BalanceTrackBar.Value;

            if (balanceTrackBarValue == 0)
            {
                BalanceCurrentValueToolTip.SetToolTip(BalanceTrackBar, $"Баланс: центр");
            }
            else if (balanceTrackBarValue > 0)
            {
                BalanceCurrentValueToolTip.SetToolTip(BalanceTrackBar, $"Баланс: {balanceTrackBarValue * 10}% правый");
            }
            else
            {
                BalanceCurrentValueToolTip.SetToolTip(BalanceTrackBar, $"Баланс: {(-1) * balanceTrackBarValue * 10}% левый");
            }
        }

        private void CopySegmentButton_Click(object sender, EventArgs e)
        {
            int begin, end;
            if (CalculateFrameBorders(out begin, out end))
                AudioSelected = Editor.Copy(Audio, begin, end);

            AudioDataStructure audioDataStruct = new AudioDataStructure();
            audioDataStruct.samples = AudioSelected.Samples.ToArray();
            audioDataStruct.sampleRate = (int)AudioSelected.SampleRate;
            audioDataStruct.channels = (int)AudioSelected.Channels;
            audioDataStruct.bitsPerSample = (int)AudioSelected.BitsPerSample;

            string format = "MAXIMAOZH_AUDIO";
            Clipboard.SetData(format, audioDataStruct);


            LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%Работа%Копирование сегмента " + begin + " " + end +"%";
            LoggerExecutable.Start();
        }

        private void CutSegmentButton_Click(object sender, EventArgs e)
        {
            int begin, end;
            if (CalculateFrameBorders(out begin, out end))
                AudioSelected = Editor.Cut(Audio, begin, end);

            AudioDataStructure audioDataStruct = new AudioDataStructure();
            audioDataStruct.samples = AudioSelected.Samples.ToArray();
            audioDataStruct.sampleRate = (int)AudioSelected.SampleRate;
            audioDataStruct.channels = (int)AudioSelected.Channels;
            audioDataStruct.bitsPerSample = (int)AudioSelected.BitsPerSample;

            string format = "MAXIMAOZH_AUDIO";
            Clipboard.SetData(format, audioDataStruct);

            Configure();
            Draw();

            LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%Работа%Вырезать фрагмент " + begin + " " + end + "%";
            LoggerExecutable.Start();
        }

        private void DeleteSegmentButton_Click(object sender, EventArgs e)
        {
            int begin, end;
            if (CalculateFrameBorders(out begin, out end))
                Editor.Delete(Audio, begin, end);

            Configure();
            Draw();


            LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%Работа%Удалить фрагмент " + begin + " " + end + "%";
            LoggerExecutable.Start();
        }

        private void DrawMonoChannel()
        {
            

            int height = LeftChannelPictureBox.Height;
            int width = LeftChannelPictureBox.Size.Width;

            var chartLeft = new Bitmap(width, height);
            var chartRight = new Bitmap(width, height);
            int lenght = Audio.Samples.Count();

            using (var graphicsLeft = Graphics.FromImage(chartLeft))
            using (var graphicsRight = Graphics.FromImage(chartRight))
            {
                graphicsLeft.DrawLine(CentralLinePen, new Point(0, height / 2), new Point(width, height / 2));
                graphicsRight.DrawLine(CentralLinePen, new Point(0, height / 2), new Point(width, height / 2));

                int step = (int)Math.Round((float)Audio.Samples.Count / width / ChartScale);

                for (int i = 0; i < width; i++)
                {
                    if (i * step >= lenght)
                        break;

                    int x = i;

                    int sampleOffset = i * step;
                    bool isEven = sampleOffset % 2 == 0;
                    int sampleAddLeft = isEven ? 1 : 0;
                    int sampleAddRight = isEven ? 0 : 1;

                    if (i * step + sampleAddLeft >= lenght)
                        break;

                    int yLeft = (int)(AverageSample(GetSampleByChannels(Audio.Samples, i * step + sampleAddLeft, step)) * height);

                    graphicsLeft.DrawLine(WaveFormPen, new Point(x, yLeft), new Point(x, height - yLeft));
                }
            }
            LeftChannelPictureBox.Image = chartLeft;
        }

        private void DrawStereoChannel()
        {
            int height = LeftChannelPictureBox.Height;
            int width = LeftChannelPictureBox.Size.Width;

            var chartLeft = new Bitmap(width, height);
            var chartRight = new Bitmap(width, height);
            int lenght = Audio.Samples.Count();

            using (var graphicsLeft = Graphics.FromImage(chartLeft))
            using (var graphicsRight = Graphics.FromImage(chartRight))
            {
                graphicsLeft.DrawLine(CentralLinePen, new Point(0, height / 2), new Point(width, height / 2));
                graphicsRight.DrawLine(CentralLinePen, new Point(0, height / 2), new Point(width, height / 2));

                int step = (int)Math.Round((float)Audio.Samples.Count / width / ChartScale);

                for (int i = 0; i < width; i++)
                {
                    if (i * step >= lenght)
                        break;

                    int x = i;

                    int sampleOffset = i * step;
                    bool isEven = sampleOffset % 2 == 0;
                    int sampleAddLeft = isEven ? 1 : 0;
                    int sampleAddRight = isEven ? 0 : 1;

                    if (i * step + sampleAddLeft >= lenght)
                        break;

                    int yLeft = (int)(AverageSample(GetSampleByChannels(Audio.Samples, i * step + sampleAddLeft, step)) * height);

                    if (i * step + sampleAddRight >= lenght)
                        break;

                    int yRight = (int)(AverageSample(GetSampleByChannels(Audio.Samples, i * step + sampleAddRight, step)) * height);

                    graphicsLeft.DrawLine(WaveFormPen, new Point(x, yLeft), new Point(x, height - yLeft));
                    graphicsRight.DrawLine(WaveFormPen, new Point(x, yRight), new Point(x, height - yLeft));
                }
            }
            LeftChannelPictureBox.Image = chartLeft;
            RightChannelPictureBox.Image = chartRight;
        }

        private List<float> GetSampleByChannels(List<float> samples, int begin, int count)
        {
            List<float> values = new List<float>();
            int totalAdded = 0;
            for (int i = begin; totalAdded != count; i += 2)
            {
                if (i >= samples.Count)
                    break;

                totalAdded++;
                values.Add(samples[i]);
            }
            return values;
        }

        private void InsertSegmentButton_Click(object sender, EventArgs e)
        {
            AudioSelected = new AudioData.AudioData();

            try
            {
                string format = "MAXIMAOZH_AUDIO";
                var audioDataStruct = (AudioDataStructure)Clipboard.GetData(format);

                AudioSelected.Samples       = new List<float>(audioDataStruct.samples);
                AudioSelected.SampleRate    = (uint)audioDataStruct.sampleRate;
                AudioSelected.Channels      = (ushort)audioDataStruct.channels;
                AudioSelected.BitsPerSample = (ushort)audioDataStruct.bitsPerSample;

                if (AudioSelected.Channels != Audio.Channels)
                    return;

                if(!AudioData.AudioData.CompareFormat(AudioSelected, Audio))
                {
                    AudioSelected.ChangeSampleRate(Audio.SampleRate);
                }

                int begin, end;
                if (CalculateFrameBorders(out begin, out end))
                    Editor.Insert(Audio, AudioSelected, begin);

                Configure();
                Draw();


                LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%Работа%Вставить фрагмент " + begin + " " + end + "%";
                LoggerExecutable.Start();
            }
            catch
            {

            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {

            if (AudioSelected != null && AudioSelected.IsPlaying())
            {
                StopButton_Click(null, null);
                return;
            }

            int begin, end;
            if (CalculateFrameBorders(out begin, out end))
                AudioSelected = Editor.Copy(Audio, begin, end);

            AudioSelected?.Play(AmplificationTrackBar.Value, BalanceTrackBar.Value);
            AudioTimer.Start();


            LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%Работа%Проигрывание%";
            LoggerExecutable.Start();
        }

        private void ScaleAddButton_Click(object sender, EventArgs e)
        {
            if (ChartScale >= 25)
                return;

            ChartScale += 1f;
            ScaleLabel.Text = ChartScale.ToString("0.00");
            Configure();
            Draw();
        }

        private void ScaleSubButton_Click(object sender, EventArgs e)
        {
            if (ChartScale <= 1f)
            {
                ChartScale = 1f;
            }
            else
            {
                ChartScale -= 1f;
            }

            ScaleLabel.Text = ChartScale.ToString("0.00");
            Configure();
            Draw();
        }

        private void SelectedSampleBeginTrackBar_ValueChanged(object sender, EventArgs e)
        {
            var beginValue = (float)SelectedSampleBeginTrackBar.Value / 4 / ChartScale;
            var endValue = (float)SelectedSampleEndTrackBar.Value / 4 / ChartScale;
            if (beginValue > endValue)
            {
                beginValue = endValue;
                SelectedSampleBeginTrackBar.Value = (int)(beginValue * 4 * ChartScale);
            }
            SelectedSampleBeginLabel.Text = beginValue.ToString() + " сек";
            SelectedSampleBegin = SelectedSampleBeginTrackBar.Value;
        }

        private void SelectedSampleEndTrackBar_ValueChanged(object sender, EventArgs e)
        {
            var beginValue = (float)SelectedSampleBeginTrackBar.Value / 4 / ChartScale;
            var endValue = (float)SelectedSampleEndTrackBar.Value / 4 / ChartScale;
            if (beginValue > endValue)
            {
                endValue = beginValue;
                SelectedSampleEndTrackBar.Value = (int)(endValue * 4 * ChartScale);
            }
            SelectedSampleEndLabel.Text = endValue.ToString() + " сек";
            SelectedSampleEnd = SelectedSampleEndTrackBar.Value;
        }

        private void SetLoggerExecutable(string pathToLoggerExecutable)
        {
            LoggerExecutable = new Process();
            LoggerExecutable.StartInfo.FileName = pathToLoggerExecutable;
        }
        private void SoundLoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Wave (.wav)|*.wav|MP3 (.mp3)|*.mp3";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string selectedFileName = "";
            selectedFileName = openFileDialog.FileName;

            Audio = new AudioData.AudioData();
            Audio.Load(selectedFileName);

            SelectedSampleEnd = Audio.Samples.Count;

            if (Audio.Channels == 1)
                Draw = DrawMonoChannel;
            else if (Audio.Channels == 2)
                Draw = DrawStereoChannel;
            else
                Draw = () => { };

            Configure();

            SelectedSampleBeginTrackBar.Value = 0;
            SelectedSampleEndTrackBar.Value = this.SelectedSampleEndTrackBar.Maximum;

            var endValue = (float)SelectedSampleEndTrackBar.Value / 4 / ChartScale;
            SelectedSampleBeginLabel.Text = "0 сек";
            SelectedSampleEndLabel.Text = endValue.ToString() + " сек";
            Draw();

            LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%Работа%Загрузка аудио " + selectedFileName+ "%";
            LoggerExecutable.Start();
        }

        private void SoundSaveButton_Click(object sender, EventArgs e)
        {
            if (Audio == null)
                return;

            var saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Wave (.wav) |*.wav";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            if (!saveFileDialog.FileName.Contains(".wav"))
            {
                MessageBox.Show("Недопустимый файл для сохранения");
                return;
            }

            Audio.Save(saveFileDialog.FileName);

            LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%Работа%Сохранение аудио " + saveFileDialog.FileName + "%";
            LoggerExecutable.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (AudioSelected == null || !AudioSelected.IsPlaying())
                return;

            AudioSelected?.Stop();
            AudioTimer.Stop();


            LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%Работа%Остановить%";
            LoggerExecutable.Start();
        }

        private void BalanceTrackBar_ValueChanged(object sender, EventArgs e)
        {
            string value = (BalanceTrackBar.Value * 100).ToString() + "%";
            BalanceCurrentValueToolTip.SetToolTip(BalanceTrackBar, value);
        }

        private void AmplificationTrackBar_ValueChanged(object sender, EventArgs e)
        {
            string value = AmplificationTrackBar.Value.ToString();
            AmplificationCurrentValueToolTip.SetToolTip(AmplificationTrackBar, value + " дб");
        }
    }
}