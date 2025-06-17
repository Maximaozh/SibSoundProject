using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chorus
{
    public class Chorus : IPlugin.IPlugin
    {
        public string Author()
        {
            return "Maksim 'Maximaozh' Slastnikov";
        }

        public string Description()
        {
            return "Добавляет эффект хоруса в сегмент аудио";
        }

        public string Group()
        {
            return "Эффект";
        }

        public string GUID()
        {
            return "{6C1DA44F-A9BA-4402-8B14-D3B0D9231FA4}";
        }

        public string Name()
        {
            return "Хорус";
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
