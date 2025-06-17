using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Echo
{
    public class Echo : IPlugin.IPlugin
    {
        public string Author()
        {
            return "Maksim 'Maximaozh' Slastnikov";
        }

        public string Description()
        {
            return "Создаёт эффект эхо в сегментаудио";
        }

        public string Group()
        {
            return "Эффект";
        }

        public string GUID()
        {
            return "{990306B6-B087-4E61-BA13-EC82484F1AE9}";
        }

        public string Name()
        {
            return "Эхо";
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
