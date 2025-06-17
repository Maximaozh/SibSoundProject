using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wah_wah
{
    public  class Program : IPlugin.IPlugin
    {
        public string Author()
        {
            return "Maksim 'Maximaozh' Slastnikov";
        }

        public string Description()
        {
            return "Добавляет эффект 'wah-wah' в сегмент аудио";
        }

        public string Group()
        {
            return "Эффект";
        }

        public string GUID()
        {
            return "{AEB2D8EA-D91A-4E2E-AC67-5489B0444931}";
        }

        public string Name()
        {
            return "Вау-вау";
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
