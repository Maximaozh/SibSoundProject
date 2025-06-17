using Sibsound.Audios;
using Sibsound.Errors;

namespace Sibsound.Editors
{
    /// <summary>
    /// Базовый интерфейс для аудиоредактирвоания. Содержит инструменты "копировать", "вырезать", "вставить" и "удалить"
    /// </summary>
    public interface IAudioEditor
    {
        /// <summary>
        /// Возвращает фрагмент из аудио, сохраняет его в исходном
        /// </summary>
        AudioData.AudioData Copy(AudioData.AudioData audioData, int begin, int end);

        /// <summary>
        /// Возвращает фрагмент из аудио, удаляет его в исходном
        /// </summary>
        AudioData.AudioData Cut(AudioData.AudioData audioData, int begin, int end);

        /// <summary>
        /// Производит вставку paste-данных в origin-данные
        /// </summary>
        Status Insert(AudioData.AudioData origin, AudioData.AudioData paste, int begin);

        /// <summary>
        /// Удаляет фрагмент из аудио
        /// </summary>
        Status Delete(AudioData.AudioData audioData, int begin, int end);
    }
}