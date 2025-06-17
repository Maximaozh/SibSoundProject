using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gain
{
    public class Gain : IPlugin.IPlugin
    {
        public string Author()
        {
            return "Maksim 'Maximaozh' Slastnikov";
        }

        public string Description()
        {
            return "Добавляет усиление или ослабление аудио фрагмента";
        }

        public string Group()
        {
            return "Редактирование";
        }

        public string GUID()
        {
            return "{FEC9AFA5-CEF0-4265-95FD-4F5E43D06906}";
        }

        public string Name()
        {
            return "Усиление";
        }

        public string Released()
        {
            return "31.05.2024";
        }

        public void Run(ref AudioData.AudioData data, ref int begin, ref int end)
        {
            var form = new MainForm(ref data, ref begin, ref end);
            form.ShowDialog();
        }

        public string Version()
        {
            return "1.00.00";
        }
    }
}
