namespace KeyGenFramework
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GetDrivesButton = new System.Windows.Forms.Button();
            this.GenerateKeyButton = new System.Windows.Forms.Button();
            this.DrivesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OrganizationNameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.FunctionsAvaiableRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ExpirationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EventsViewerRichTextBox = new System.Windows.Forms.RichTextBox();
            this.LoadedFlashDrivesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.EventsViewerRichTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LoadedFlashDrivesRichTextBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.Controls.Add(this.GetDrivesButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.GenerateKeyButton, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.DrivesComboBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.OrganizationNameRichTextBox, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.FunctionsAvaiableRichTextBox, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.ExpirationDateTimePicker, 0, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(452, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(146, 362);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // GetDrivesButton
            // 
            this.GetDrivesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GetDrivesButton.Location = new System.Drawing.Point(2, 2);
            this.GetDrivesButton.Margin = new System.Windows.Forms.Padding(2);
            this.GetDrivesButton.Name = "GetDrivesButton";
            this.GetDrivesButton.Size = new System.Drawing.Size(142, 33);
            this.GetDrivesButton.TabIndex = 0;
            this.GetDrivesButton.Text = "Получить буквы дисков";
            this.GetDrivesButton.UseVisualStyleBackColor = true;
            this.GetDrivesButton.Click += new System.EventHandler(this.GetDrivesButton_Click);
            // 
            // GenerateKeyButton
            // 
            this.GenerateKeyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenerateKeyButton.Location = new System.Drawing.Point(2, 327);
            this.GenerateKeyButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateKeyButton.Name = "GenerateKeyButton";
            this.GenerateKeyButton.Size = new System.Drawing.Size(142, 33);
            this.GenerateKeyButton.TabIndex = 1;
            this.GenerateKeyButton.Text = "Сгенерировать ключ";
            this.GenerateKeyButton.UseVisualStyleBackColor = true;
            this.GenerateKeyButton.Click += new System.EventHandler(this.GenerateKeyButton_Click);
            // 
            // DrivesComboBox
            // 
            this.DrivesComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrivesComboBox.FormattingEnabled = true;
            this.DrivesComboBox.Location = new System.Drawing.Point(2, 39);
            this.DrivesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.DrivesComboBox.Name = "DrivesComboBox";
            this.DrivesComboBox.Size = new System.Drawing.Size(142, 21);
            this.DrivesComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(2, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Организация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(2, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Функции";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(2, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата истечения лицензии";
            // 
            // OrganizationNameRichTextBox
            // 
            this.OrganizationNameRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrganizationNameRichTextBox.Location = new System.Drawing.Point(2, 184);
            this.OrganizationNameRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.OrganizationNameRichTextBox.Name = "OrganizationNameRichTextBox";
            this.OrganizationNameRichTextBox.Size = new System.Drawing.Size(142, 33);
            this.OrganizationNameRichTextBox.TabIndex = 6;
            this.OrganizationNameRichTextBox.Text = "";
            // 
            // FunctionsAvaiableRichTextBox
            // 
            this.FunctionsAvaiableRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FunctionsAvaiableRichTextBox.Location = new System.Drawing.Point(2, 237);
            this.FunctionsAvaiableRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FunctionsAvaiableRichTextBox.Name = "FunctionsAvaiableRichTextBox";
            this.FunctionsAvaiableRichTextBox.Size = new System.Drawing.Size(142, 33);
            this.FunctionsAvaiableRichTextBox.TabIndex = 7;
            this.FunctionsAvaiableRichTextBox.Text = "";
            // 
            // ExpirationDateTimePicker
            // 
            this.ExpirationDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpirationDateTimePicker.Location = new System.Drawing.Point(2, 290);
            this.ExpirationDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.ExpirationDateTimePicker.Name = "ExpirationDateTimePicker";
            this.ExpirationDateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.ExpirationDateTimePicker.TabIndex = 8;
            // 
            // EventsViewerRichTextBox
            // 
            this.EventsViewerRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventsViewerRichTextBox.Location = new System.Drawing.Point(2, 2);
            this.EventsViewerRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EventsViewerRichTextBox.Name = "EventsViewerRichTextBox";
            this.EventsViewerRichTextBox.Size = new System.Drawing.Size(221, 362);
            this.EventsViewerRichTextBox.TabIndex = 1;
            this.EventsViewerRichTextBox.Text = "";
            // 
            // LoadedFlashDrivesRichTextBox
            // 
            this.LoadedFlashDrivesRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadedFlashDrivesRichTextBox.Location = new System.Drawing.Point(227, 2);
            this.LoadedFlashDrivesRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoadedFlashDrivesRichTextBox.Name = "LoadedFlashDrivesRichTextBox";
            this.LoadedFlashDrivesRichTextBox.Size = new System.Drawing.Size(221, 362);
            this.LoadedFlashDrivesRichTextBox.TabIndex = 2;
            this.LoadedFlashDrivesRichTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Сластников М.С. : Ключи";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button GetDrivesButton;
        private System.Windows.Forms.Button GenerateKeyButton;
        private System.Windows.Forms.ComboBox DrivesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox OrganizationNameRichTextBox;
        private System.Windows.Forms.RichTextBox FunctionsAvaiableRichTextBox;
        private System.Windows.Forms.DateTimePicker ExpirationDateTimePicker;
        private System.Windows.Forms.RichTextBox EventsViewerRichTextBox;
        private System.Windows.Forms.RichTextBox LoadedFlashDrivesRichTextBox;
    }
}

