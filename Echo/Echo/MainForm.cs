using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Echo
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

        public float[] ApplyEcho(float[] audioData, double delaySeconds, double decayFactor)
        {
            int delaySamples = (int)((delaySeconds * this.data.SampleRate * this.data.Channels));
            int totalLength = audioData.Length + delaySamples;
            float[] processedData = new float[totalLength];

            audioData.CopyTo(processedData, 0);

            for (int i = 0; i < audioData.Length; i++)
            {
                int echoIndex = i + delaySamples;
                if (echoIndex >= totalLength)
                    break;
                    processedData[echoIndex] += (float)(audioData[i] * decayFactor);
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

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            double seconds = Convert.ToDouble(this.DelayTextBox.Text);
            double decay   = Convert.ToDouble(this.DecayFactorTextBox.Text);

            var output = Normalize(ApplyEcho(
                data.Samples.GetRange(begin, end - begin).ToArray(), seconds, decay),
                1f);

            data.Samples.RemoveRange(begin, end - begin);
            data.Samples.InsertRange(begin, output);

            this.Close();
        }

        private void DecayFactorTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
