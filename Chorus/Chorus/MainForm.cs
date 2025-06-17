using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chorus
{
    public partial class MainForm : Form
    {
        public MainForm(ref AudioData.AudioData data, ref int begin, ref int end)
        {
            InitializeComponent();


            this.data = data;
            this.begin = begin;
            this.end = end;

        }

        int begin { get; set; }

        AudioData.AudioData data { get; set; }

        int end { get; set; }

        public float[] ApplyChorus(float[] audioData, int delayMilliseconds, float depth, float rate)
        {
            float[] processedData = new float[audioData.Length];
            int delaySamples = (int)((delayMilliseconds / 1000.0) * data.SampleRate * data.Channels);
            float modIndex = 0;

            audioData.CopyTo(processedData, 0);

            for (int i = 0; i < audioData.Length; i++)
            {
                modIndex = delaySamples * (1 + depth * (float)Math.Sin(2 * Math.PI * rate * i / data.SampleRate));

                int modDelayIndex = i - (int)modIndex;
                if (modDelayIndex >= 0 && modDelayIndex < audioData.Length)
                {
                    processedData[i] += audioData[modDelayIndex];
                }
            }

            return processedData;
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

        private void DeepTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        private void DelayTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void SpeedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            int   delay = Convert.ToInt32(this.DelayTextBox.Text);
            float depth = (float)Convert.ToDouble(this.DepthTextBox.Text);
            float speed = (float)Convert.ToDouble(this.SpeedTextBox.Text);

            var output = Normalize(ApplyChorus(
                data.Samples.GetRange(begin, end - begin).ToArray(),delay,depth,speed),
                1f);

            data.Samples.RemoveRange(begin, end - begin);
            data.Samples.InsertRange(begin, output);

            this.Close();
        }
    }
}
