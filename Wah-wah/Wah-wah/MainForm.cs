using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wah_wah
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

        public float[] ApplyWahWah(float[] audioData, float modFrequency, float maxCutoff, float minCutoff)
        {

            float[] processedAudio = new float[audioData.Length];
            float modPhase = 0.0f;
            float modIncrement = (float)(2 * Math.PI * modFrequency / data.SampleRate);
            float prevSample = 0.0f;

            for (int i = 0; i < audioData.Length; i++)
            {

                float cutoffFreq = minCutoff + (maxCutoff - minCutoff) * ((float)Math.Sin(modPhase) + 1) / 2;
                processedAudio[i] = LowPassFilter(audioData[i], ref prevSample, cutoffFreq, (int)data.SampleRate);
                modPhase += modIncrement;
                if (modPhase > 2 * Math.PI)
                {
                    modPhase -= (float)(2.0 * Math.PI);
                }
            }

            return processedAudio;
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
            int modFreq = Convert.ToInt32(this.FrequencyTextBox.Text);
            int maxFreq = Convert.ToInt32(this.MaxCutoffTextBox.Text);
            int minFreq = Convert.ToInt32(this.MinCutoffTextBox.Text);
            if (minFreq > maxFreq)
            {
                this.Close();
                return;
            }
            var output = Normalize(ApplyWahWah(
                data.Samples.GetRange(begin, end - begin).ToArray(), modFreq, maxFreq, minFreq),
                1f);

            data.Samples.RemoveRange(begin, end - begin);
            data.Samples.InsertRange(begin, output);

            this.Close();
        }

        private void FrequencyTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private float LowPassFilter(float sample, ref float prevSample, float cutoffFreq, int sampleRate)
        {
            float RC = 1.0f / (cutoffFreq * 2 * (float)Math.PI);
            float dt = 1.0f / sampleRate;
            float alpha = dt / (RC + dt);

            prevSample = prevSample + (alpha * (sample - prevSample));
            return prevSample;
        }
        private void MaxCutoffTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void MinCutoffTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
