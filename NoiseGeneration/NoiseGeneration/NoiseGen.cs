using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoiseGeneration
{
    public class NoiseGen : IPlugin.IPlugin
    {
        public string Version()
        {
            return "1.00.00";
        }

        string IPlugin.IPlugin.Author()
        {
            return "Maksim 'Maksimaozh' Slastnikov";
        }

        string IPlugin.IPlugin.Description()
        {
            return "Добавляет сегмент шума в аудио";
        }

        string IPlugin.IPlugin.Group()
        {
            return "Генерация";
        }
        string IPlugin.IPlugin.GUID()
        {
            return "{0B8C872E-6333-49DD-9434-EE67B2AEFA64}";
        }

        string IPlugin.IPlugin.Name()
        {
            return "Генерация шумов";
        }

        string IPlugin.IPlugin.Released()
        {
            return "31.05.2024";
        }

        void IPlugin.IPlugin.Run(ref AudioData.AudioData data, ref int begin, ref int end)
        {
            var form = new MainForm(ref data, begin, end);
            form.ShowDialog();
        }
    }
}
