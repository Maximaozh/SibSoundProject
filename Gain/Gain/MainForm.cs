using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gain
{
    public partial class MainForm : Form
    {
        int begin { get; set; }

        AudioData.AudioData data { get; set; }

        int end { get; set; }
        public MainForm(ref AudioData.AudioData data, ref int begin, ref int end)
        {
            InitializeComponent();

            this.data = data;
            this.begin = begin;
            this.end = end;
        }
        public float[] AdjustVolume(float[] samples, float volumeFactor)
        {
            float volumeFactorLinear = (float)Math.Pow(10, volumeFactor / 20);

            for (int i = 0; i < samples.Length; i++)
            {
                samples[i] *= volumeFactorLinear;

                if (samples[i] > 1.0f) samples[i] = 1.0f;
                if (samples[i] < -1.0f) samples[i] = -1.0f;
            }
            return samples;
        }
        public float[] Normalize(float[] data, float maxAmplitude)
        {
            float currentMax = 0f;

            foreach (float value in data)
            {
                if (Math.Abs(value) > currentMax)
                {
                    currentMax = Math.Abs(value);
                }
            }

            float normalizationFactor = maxAmplitude / currentMax;

            for (int i = 0; i < data.Length; i++)
                data[i] *= normalizationFactor;

            return data;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            int power = (int)this.PowerNumeric.Value;

            var output = AdjustVolume(
                data.Samples.GetRange(begin, end - begin).ToArray(), power);

            data.Samples.RemoveRange(begin, end - begin);
            data.Samples.InsertRange(begin, output);

            this.Close();

        }
    }
}
