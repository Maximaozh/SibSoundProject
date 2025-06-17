namespace NoiseGeneration
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.NoiseGroupBox = new System.Windows.Forms.GroupBox();
            this.BrownNoise = new System.Windows.Forms.RadioButton();
            this.PinkNoise = new System.Windows.Forms.RadioButton();
            this.WhiteNoise = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timesInSecondNumeric = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.AmplitudeBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.NoiseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timesInSecondNumeric)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.AcceptButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.NoiseGroupBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.timesInSecondNumeric, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(224, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AcceptButton.Location = new System.Drawing.Point(3, 223);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(218, 34);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Принять";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // NoiseGroupBox
            // 
            this.NoiseGroupBox.Controls.Add(this.BrownNoise);
            this.NoiseGroupBox.Controls.Add(this.PinkNoise);
            this.NoiseGroupBox.Controls.Add(this.WhiteNoise);
            this.NoiseGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoiseGroupBox.Location = new System.Drawing.Point(3, 63);
            this.NoiseGroupBox.Name = "NoiseGroupBox";
            this.NoiseGroupBox.Padding = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.NoiseGroupBox.Size = new System.Drawing.Size(218, 114);
            this.NoiseGroupBox.TabIndex = 1;
            this.NoiseGroupBox.TabStop = false;
            this.NoiseGroupBox.Text = "Вид шума";
            // 
            // BrownNoise
            // 
            this.BrownNoise.AutoSize = true;
            this.BrownNoise.Dock = System.Windows.Forms.DockStyle.Top;
            this.BrownNoise.Location = new System.Drawing.Point(3, 71);
            this.BrownNoise.Name = "BrownNoise";
            this.BrownNoise.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.BrownNoise.Size = new System.Drawing.Size(212, 29);
            this.BrownNoise.TabIndex = 2;
            this.BrownNoise.TabStop = true;
            this.BrownNoise.Text = "Коричневый";
            this.BrownNoise.UseVisualStyleBackColor = true;
            // 
            // PinkNoise
            // 
            this.PinkNoise.AutoSize = true;
            this.PinkNoise.Dock = System.Windows.Forms.DockStyle.Top;
            this.PinkNoise.Location = new System.Drawing.Point(3, 42);
            this.PinkNoise.Name = "PinkNoise";
            this.PinkNoise.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.PinkNoise.Size = new System.Drawing.Size(212, 29);
            this.PinkNoise.TabIndex = 1;
            this.PinkNoise.TabStop = true;
            this.PinkNoise.Text = "Розовый";
            this.PinkNoise.UseVisualStyleBackColor = true;
            // 
            // WhiteNoise
            // 
            this.WhiteNoise.AutoSize = true;
            this.WhiteNoise.Dock = System.Windows.Forms.DockStyle.Top;
            this.WhiteNoise.Location = new System.Drawing.Point(3, 25);
            this.WhiteNoise.Name = "WhiteNoise";
            this.WhiteNoise.Size = new System.Drawing.Size(212, 17);
            this.WhiteNoise.TabIndex = 0;
            this.WhiteNoise.TabStop = true;
            this.WhiteNoise.Text = "Белый";
            this.WhiteNoise.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Укажите длительность в секундах";
            // 
            // timesInSecondNumeric
            // 
            this.timesInSecondNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timesInSecondNumeric.Location = new System.Drawing.Point(3, 23);
            this.timesInSecondNumeric.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.timesInSecondNumeric.Name = "timesInSecondNumeric";
            this.timesInSecondNumeric.Size = new System.Drawing.Size(218, 20);
            this.timesInSecondNumeric.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.AmplitudeBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 183);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(218, 34);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Амплитуда (0 - 1)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AmplitudeBox
            // 
            this.AmplitudeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AmplitudeBox.Location = new System.Drawing.Point(112, 3);
            this.AmplitudeBox.Name = "AmplitudeBox";
            this.AmplitudeBox.Size = new System.Drawing.Size(103, 20);
            this.AmplitudeBox.TabIndex = 1;
            this.AmplitudeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmplitudeBox_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генерация шума";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.NoiseGroupBox.ResumeLayout(false);
            this.NoiseGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timesInSecondNumeric)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.GroupBox NoiseGroupBox;
        private System.Windows.Forms.RadioButton BrownNoise;
        private System.Windows.Forms.RadioButton PinkNoise;
        private System.Windows.Forms.RadioButton WhiteNoise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown timesInSecondNumeric;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AmplitudeBox;
    }
}

