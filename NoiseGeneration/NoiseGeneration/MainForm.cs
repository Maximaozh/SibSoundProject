using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoiseGeneration
{
    public partial class MainForm : Form
    {
        AudioData.AudioData data { get; set; }
        int begin { get; set; }

        int end { get; set; }

        Random random = new Random();

        public MainForm(ref AudioData.AudioData data, int begin, int end)
        {
            InitializeComponent();  

            this.data = data;
            this.begin = begin;
            this.end = end;
        }
        private float[] WhiteNoiseFunc(int timeInSamples)
        {
            float[] whiteNoise = new float[timeInSamples];
            for (int i = 0; i < timeInSamples; i++)
            {
                whiteNoise[i] = (float)(random.NextDouble() * 2.0 - 1.0);
            }
            return whiteNoise;
        }

        private float[] PinkNoiseFunc(int timeInSamples)
        {
            float[] pinkNoise = new float[timeInSamples];
            float[] whiteNoise = WhiteNoiseFunc(timeInSamples);
            float b0, b1, b2, b3, b4, b5, b6;
            b0 = b1 = b2 = b3 = b4 = b5 = b6 = 0.0f;

            for (int i = 0; i < timeInSamples; i++)
            {
                float white = whiteNoise[i];

                b0 = 0.99886f * b0 + white * 0.0555179f;
                b1 = 0.99332f * b1 + white * 0.0750759f;
                b2 = 0.96900f * b2 + white * 0.1538520f;
                b3 = 0.86650f * b3 + white * 0.3104856f;
                b4 = 0.55000f * b4 + white * 0.5329522f;
                b5 = -0.7616f * b5 - white * 0.0168980f;
                pinkNoise[i] = b0 + b1 + b2 + b3 + b4 + b5 + b6 + white * 0.5362f;
                pinkNoise[i] *= 0.11f;
                b6 = white * 0.115926f;
            }
            return pinkNoise;
        }

        private float[] BrownNoiseFunc(int timeInSamples)
        {
            float[] brownNoise = new float[timeInSamples];
            float lastOut = 0.0f;
            for (int i = 0; i < timeInSamples; i++)
            {
                float white = (float)(random.NextDouble() * 2.0 - 1.0);
                brownNoise[i] = (lastOut + (0.02f * white)) / 1.02f;
                lastOut = brownNoise[i];
                brownNoise[i] *= 3.5f;
            }
            return brownNoise;
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
            if (AmplitudeBox.Text == "" || AmplitudeBox.Text == null)
            {
                MessageBox.Show("AMPLITUDE NOT SET", "ERR");
                return;
            }    

            int inputTime = Convert.ToInt32(this.timesInSecondNumeric.Value);
            int lenghtInSamples = (int)(inputTime * data.SampleRate * data.Channels);

            float amplitude = (float)Convert.ToDouble(AmplitudeBox.Text);
            if (amplitude > 1)
                amplitude = 1;

            var output = new List<float>();

            if (WhiteNoise.Checked)
                output = new List<float>(Normalize(WhiteNoiseFunc(lenghtInSamples),amplitude));
            else if (PinkNoise.Checked)
                output = new List<float>(Normalize(PinkNoiseFunc(lenghtInSamples), amplitude));
            else if (BrownNoise.Checked)
                output = new List<float>(Normalize(BrownNoiseFunc(lenghtInSamples), amplitude));

            if (data.Samples.Count > 0)
                data.Samples.InsertRange(0, output);
            else
                data.Samples.AddRange(output);


            this.Close();
        }

        private void AmplitudeBox_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
