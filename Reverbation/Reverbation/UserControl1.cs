using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reverbation
{
    public partial class UserControl1: UserControl, IPlugin.IPlugin
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public string Author()
        {
            throw new NotImplementedException();
        }

        public string Description()
        {
            throw new NotImplementedException();
        }

        public string GetGUID()
        {
            throw new NotImplementedException();
        }

        public string Released()
        {
            throw new NotImplementedException();
        }

        public void Run(AudioData.AudioData data)
        {
            InitializeComponent();
            MessageBox.Show("hi");
        }

        string IPlugin.IPlugin.Name()
        {
            throw new NotImplementedException();
        }
    }
}
