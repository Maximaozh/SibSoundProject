using Sibsound.Audios;
using Sibsound.Errors;
using System;

namespace Sibsound.Editors
{
    public class BasicAudioEditor : IAudioEditor
    {

        private void ValidateData(AudioData.AudioData audioData, int begin, int end)
        {
            if(audioData.Samples.Count == 0)
                return;

            if (begin > end)
                throw new Exception("Индекс начального фрагмент больше индекса финального");

            if (audioData.Samples.Count < end)
                throw new Exception("Индекс финального сэмпла находится вне границ массива");

            if (audioData == null)
                throw new Exception("Объект аудиоданных оказался пустым");

            if (audioData.Samples == null)
                throw new Exception("Сэмплы объекта оказались пусты");
        }

        public AudioData.AudioData Copy(AudioData.AudioData audioData, int begin, int end)
        {
            ValidateData(audioData, begin, end);

            var copySegment = new AudioData.AudioData();

            copySegment.Samples = audioData.Samples.GetRange((int)begin, (int)(end - begin));
            copySegment.LoadFormat(audioData);

            return copySegment;
        }

        public AudioData.AudioData Cut(AudioData.AudioData audioData, int begin, int end)
        {
            ValidateData(audioData, begin, end);

            var cutSegment = Copy(audioData, begin, end);
            audioData.Samples.RemoveRange((int)begin, (int)(end - begin));

            return cutSegment;
        }

        public Status Delete(AudioData.AudioData audioData, int begin, int end)
        {
            ValidateData(audioData, begin, end);

            audioData.Samples.RemoveRange((int)begin, (int)(end - begin));

            return Status.Done;
        }

        public Status Insert(AudioData.AudioData origin, AudioData.AudioData paste, int begin)
        {
            if (origin.Samples.Count <= begin)
                return Status.Failed;

            origin.Samples.InsertRange((int)begin, paste.Samples);

            return Status.Done;
        }
    }
}