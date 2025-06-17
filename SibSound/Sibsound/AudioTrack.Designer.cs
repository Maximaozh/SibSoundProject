namespace Sibsound
{
    partial class AudioTrack
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectedSampleEndLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectedSampleBeginLabel = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.PictureBox();
            this.StopButton = new System.Windows.Forms.PictureBox();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ChannelsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LeftChannelPictureBox = new System.Windows.Forms.PictureBox();
            this.RightChannelPictureBox = new System.Windows.Forms.PictureBox();
            this.LeftChannelLabel = new System.Windows.Forms.Label();
            this.RightChannelLabel = new System.Windows.Forms.Label();
            this.SelectedSampleBeginTrackBar = new System.Windows.Forms.TrackBar();
            this.SelectedSampleEndTrackBar = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.SoundSaveButton = new System.Windows.Forms.PictureBox();
            this.SoundLoadButton = new System.Windows.Forms.PictureBox();
            this.DeleteSegmentButton = new System.Windows.Forms.PictureBox();
            this.InsertSegmentButton = new System.Windows.Forms.PictureBox();
            this.CopySegmentButton = new System.Windows.Forms.PictureBox();
            this.CutSegmentButton = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BalanceTrackBar = new System.Windows.Forms.TrackBar();
            this.RightBalanceLabel = new System.Windows.Forms.Label();
            this.LeftBalanceLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AmplificationTrackBar = new System.Windows.Forms.TrackBar();
            this.PlusAmplificationLabel = new System.Windows.Forms.Label();
            this.MinusAmplificationLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ScaleAddButton = new System.Windows.Forms.PictureBox();
            this.ScaleLabel = new System.Windows.Forms.Label();
            this.ScaleSubButton = new System.Windows.Forms.PictureBox();
            this.AddAudioFromFileButton = new System.Windows.Forms.PictureBox();
            this.AmplificationCurrentValueToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BalanceCurrentValueToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AudioTimer = new System.Windows.Forms.Timer(this.components);
            this.MainTableLayout.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.ChannelsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftChannelPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightChannelPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedSampleBeginTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedSampleEndTrackBar)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoundSaveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundLoadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteSegmentButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsertSegmentButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CopySegmentButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutSegmentButton)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceTrackBar)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmplificationTrackBar)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleAddButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleSubButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAudioFromFileButton)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 1;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayout.Controls.Add(this.tableLayoutPanel10, 0, 2);
            this.MainTableLayout.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.MainTableLayout.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 3;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.MainTableLayout.Size = new System.Drawing.Size(784, 494);
            this.MainTableLayout.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 8;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.PlayButton, 5, 0);
            this.tableLayoutPanel10.Controls.Add(this.StopButton, 6, 0);
            this.tableLayoutPanel10.Controls.Add(this.TimerLabel, 7, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 457);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(778, 34);
            this.tableLayoutPanel10.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.SelectedSampleEndLabel, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(123, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(114, 28);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Конец:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectedSampleEndLabel
            // 
            this.SelectedSampleEndLabel.AutoSize = true;
            this.SelectedSampleEndLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedSampleEndLabel.Location = new System.Drawing.Point(60, 0);
            this.SelectedSampleEndLabel.Name = "SelectedSampleEndLabel";
            this.SelectedSampleEndLabel.Size = new System.Drawing.Size(51, 28);
            this.SelectedSampleEndLabel.TabIndex = 1;
            this.SelectedSampleEndLabel.Text = "label6";
            this.SelectedSampleEndLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SelectedSampleBeginLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(114, 28);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Начало:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectedSampleBeginLabel
            // 
            this.SelectedSampleBeginLabel.AutoSize = true;
            this.SelectedSampleBeginLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedSampleBeginLabel.Location = new System.Drawing.Point(60, 0);
            this.SelectedSampleBeginLabel.Name = "SelectedSampleBeginLabel";
            this.SelectedSampleBeginLabel.Size = new System.Drawing.Size(51, 28);
            this.SelectedSampleBeginLabel.TabIndex = 1;
            this.SelectedSampleBeginLabel.Text = "label5";
            this.SelectedSampleBeginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayButton
            // 
            this.PlayButton.Image = global::Sibsound.Properties.Resources.play;
            this.PlayButton.Location = new System.Drawing.Point(571, 3);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(39, 27);
            this.PlayButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayButton.TabIndex = 5;
            this.PlayButton.TabStop = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Image = global::Sibsound.Properties.Resources.stop;
            this.StopButton.Location = new System.Drawing.Point(616, 3);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(39, 27);
            this.StopButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StopButton.TabIndex = 6;
            this.StopButton.TabStop = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimerLabel.Location = new System.Drawing.Point(661, 0);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(114, 34);
            this.TimerLabel.TabIndex = 7;
            this.TimerLabel.Text = "-1";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.flowLayoutPanel1.Controls.Add(this.ChannelsLayoutPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(778, 408);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // ChannelsLayoutPanel
            // 
            this.ChannelsLayoutPanel.ColumnCount = 2;
            this.ChannelsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.ChannelsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ChannelsLayoutPanel.Controls.Add(this.LeftChannelPictureBox, 1, 2);
            this.ChannelsLayoutPanel.Controls.Add(this.RightChannelPictureBox, 1, 3);
            this.ChannelsLayoutPanel.Controls.Add(this.LeftChannelLabel, 0, 2);
            this.ChannelsLayoutPanel.Controls.Add(this.RightChannelLabel, 0, 3);
            this.ChannelsLayoutPanel.Controls.Add(this.SelectedSampleBeginTrackBar, 1, 0);
            this.ChannelsLayoutPanel.Controls.Add(this.SelectedSampleEndTrackBar, 1, 1);
            this.ChannelsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ChannelsLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.ChannelsLayoutPanel.Name = "ChannelsLayoutPanel";
            this.ChannelsLayoutPanel.RowCount = 4;
            this.ChannelsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ChannelsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ChannelsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ChannelsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ChannelsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ChannelsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ChannelsLayoutPanel.Size = new System.Drawing.Size(515, 404);
            this.ChannelsLayoutPanel.TabIndex = 1;
            // 
            // LeftChannelPictureBox
            // 
            this.LeftChannelPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LeftChannelPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LeftChannelPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftChannelPictureBox.Location = new System.Drawing.Point(30, 75);
            this.LeftChannelPictureBox.Margin = new System.Windows.Forms.Padding(15);
            this.LeftChannelPictureBox.Name = "LeftChannelPictureBox";
            this.LeftChannelPictureBox.Size = new System.Drawing.Size(470, 142);
            this.LeftChannelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LeftChannelPictureBox.TabIndex = 0;
            this.LeftChannelPictureBox.TabStop = false;
            // 
            // RightChannelPictureBox
            // 
            this.RightChannelPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RightChannelPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RightChannelPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightChannelPictureBox.Location = new System.Drawing.Point(30, 247);
            this.RightChannelPictureBox.Margin = new System.Windows.Forms.Padding(15);
            this.RightChannelPictureBox.Name = "RightChannelPictureBox";
            this.RightChannelPictureBox.Size = new System.Drawing.Size(470, 142);
            this.RightChannelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RightChannelPictureBox.TabIndex = 1;
            this.RightChannelPictureBox.TabStop = false;
            // 
            // LeftChannelLabel
            // 
            this.LeftChannelLabel.AutoSize = true;
            this.LeftChannelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftChannelLabel.Location = new System.Drawing.Point(3, 60);
            this.LeftChannelLabel.Name = "LeftChannelLabel";
            this.LeftChannelLabel.Size = new System.Drawing.Size(9, 172);
            this.LeftChannelLabel.TabIndex = 2;
            this.LeftChannelLabel.Text = "L";
            this.LeftChannelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightChannelLabel
            // 
            this.RightChannelLabel.AutoSize = true;
            this.RightChannelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightChannelLabel.Location = new System.Drawing.Point(3, 232);
            this.RightChannelLabel.Name = "RightChannelLabel";
            this.RightChannelLabel.Size = new System.Drawing.Size(9, 172);
            this.RightChannelLabel.TabIndex = 3;
            this.RightChannelLabel.Text = "R";
            this.RightChannelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectedSampleBeginTrackBar
            // 
            this.SelectedSampleBeginTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedSampleBeginTrackBar.Location = new System.Drawing.Point(18, 3);
            this.SelectedSampleBeginTrackBar.Name = "SelectedSampleBeginTrackBar";
            this.SelectedSampleBeginTrackBar.Size = new System.Drawing.Size(494, 24);
            this.SelectedSampleBeginTrackBar.TabIndex = 4;
            this.SelectedSampleBeginTrackBar.ValueChanged += new System.EventHandler(this.SelectedSampleBeginTrackBar_ValueChanged);
            // 
            // SelectedSampleEndTrackBar
            // 
            this.SelectedSampleEndTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedSampleEndTrackBar.Location = new System.Drawing.Point(18, 33);
            this.SelectedSampleEndTrackBar.Name = "SelectedSampleEndTrackBar";
            this.SelectedSampleEndTrackBar.Size = new System.Drawing.Size(494, 24);
            this.SelectedSampleEndTrackBar.TabIndex = 5;
            this.SelectedSampleEndTrackBar.ValueChanged += new System.EventHandler(this.SelectedSampleEndTrackBar_ValueChanged);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 12;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel8.Controls.Add(this.SoundSaveButton, 11, 0);
            this.tableLayoutPanel8.Controls.Add(this.SoundLoadButton, 10, 0);
            this.tableLayoutPanel8.Controls.Add(this.DeleteSegmentButton, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.InsertSegmentButton, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.CopySegmentButton, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.CutSegmentButton, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel1, 8, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel6, 9, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel7, 6, 0);
            this.tableLayoutPanel8.Controls.Add(this.AddAudioFromFileButton, 4, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(778, 34);
            this.tableLayoutPanel8.TabIndex = 6;
            // 
            // SoundSaveButton
            // 
            this.SoundSaveButton.Image = global::Sibsound.Properties.Resources.folder_open;
            this.SoundSaveButton.Location = new System.Drawing.Point(741, 3);
            this.SoundSaveButton.Name = "SoundSaveButton";
            this.SoundSaveButton.Size = new System.Drawing.Size(34, 27);
            this.SoundSaveButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SoundSaveButton.TabIndex = 11;
            this.SoundSaveButton.TabStop = false;
            this.SoundSaveButton.Click += new System.EventHandler(this.SoundSaveButton_Click);
            // 
            // SoundLoadButton
            // 
            this.SoundLoadButton.Image = global::Sibsound.Properties.Resources.folder_save;
            this.SoundLoadButton.Location = new System.Drawing.Point(701, 3);
            this.SoundLoadButton.Name = "SoundLoadButton";
            this.SoundLoadButton.Size = new System.Drawing.Size(34, 27);
            this.SoundLoadButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SoundLoadButton.TabIndex = 10;
            this.SoundLoadButton.TabStop = false;
            this.SoundLoadButton.Click += new System.EventHandler(this.SoundLoadButton_Click);
            // 
            // DeleteSegmentButton
            // 
            this.DeleteSegmentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteSegmentButton.Image = global::Sibsound.Properties.Resources.remove;
            this.DeleteSegmentButton.Location = new System.Drawing.Point(123, 3);
            this.DeleteSegmentButton.Name = "DeleteSegmentButton";
            this.DeleteSegmentButton.Size = new System.Drawing.Size(34, 28);
            this.DeleteSegmentButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteSegmentButton.TabIndex = 8;
            this.DeleteSegmentButton.TabStop = false;
            this.DeleteSegmentButton.Click += new System.EventHandler(this.DeleteSegmentButton_Click);
            // 
            // InsertSegmentButton
            // 
            this.InsertSegmentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InsertSegmentButton.Image = global::Sibsound.Properties.Resources.paste;
            this.InsertSegmentButton.Location = new System.Drawing.Point(83, 3);
            this.InsertSegmentButton.Name = "InsertSegmentButton";
            this.InsertSegmentButton.Size = new System.Drawing.Size(34, 28);
            this.InsertSegmentButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InsertSegmentButton.TabIndex = 7;
            this.InsertSegmentButton.TabStop = false;
            this.InsertSegmentButton.Click += new System.EventHandler(this.InsertSegmentButton_Click);
            // 
            // CopySegmentButton
            // 
            this.CopySegmentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CopySegmentButton.Image = global::Sibsound.Properties.Resources.copy;
            this.CopySegmentButton.Location = new System.Drawing.Point(43, 3);
            this.CopySegmentButton.Name = "CopySegmentButton";
            this.CopySegmentButton.Size = new System.Drawing.Size(34, 28);
            this.CopySegmentButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CopySegmentButton.TabIndex = 6;
            this.CopySegmentButton.TabStop = false;
            this.CopySegmentButton.Click += new System.EventHandler(this.CopySegmentButton_Click);
            // 
            // CutSegmentButton
            // 
            this.CutSegmentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CutSegmentButton.Image = global::Sibsound.Properties.Resources.scissors;
            this.CutSegmentButton.Location = new System.Drawing.Point(3, 3);
            this.CutSegmentButton.Name = "CutSegmentButton";
            this.CutSegmentButton.Size = new System.Drawing.Size(34, 28);
            this.CutSegmentButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CutSegmentButton.TabIndex = 5;
            this.CutSegmentButton.TabStop = false;
            this.CutSegmentButton.Click += new System.EventHandler(this.CutSegmentButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(461, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(114, 28);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(108, 22);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BalanceTrackBar);
            this.panel2.Controls.Add(this.RightBalanceLabel);
            this.panel2.Controls.Add(this.LeftBalanceLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 34);
            this.panel2.TabIndex = 0;
            // 
            // BalanceTrackBar
            // 
            this.BalanceTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BalanceTrackBar.Location = new System.Drawing.Point(13, 0);
            this.BalanceTrackBar.Minimum = -10;
            this.BalanceTrackBar.Name = "BalanceTrackBar";
            this.BalanceTrackBar.Size = new System.Drawing.Size(74, 34);
            this.BalanceTrackBar.TabIndex = 2;
            this.BalanceTrackBar.ValueChanged += new System.EventHandler(this.BalanceTrackBar_ValueChanged);
            // 
            // RightBalanceLabel
            // 
            this.RightBalanceLabel.AutoSize = true;
            this.RightBalanceLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightBalanceLabel.Location = new System.Drawing.Point(87, 0);
            this.RightBalanceLabel.Name = "RightBalanceLabel";
            this.RightBalanceLabel.Size = new System.Drawing.Size(15, 13);
            this.RightBalanceLabel.TabIndex = 1;
            this.RightBalanceLabel.Text = "R";
            // 
            // LeftBalanceLabel
            // 
            this.LeftBalanceLabel.AutoSize = true;
            this.LeftBalanceLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftBalanceLabel.Location = new System.Drawing.Point(0, 0);
            this.LeftBalanceLabel.Name = "LeftBalanceLabel";
            this.LeftBalanceLabel.Size = new System.Drawing.Size(13, 13);
            this.LeftBalanceLabel.TabIndex = 0;
            this.LeftBalanceLabel.Text = "L";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(581, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(114, 28);
            this.tableLayoutPanel6.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AmplificationTrackBar);
            this.panel1.Controls.Add(this.PlusAmplificationLabel);
            this.panel1.Controls.Add(this.MinusAmplificationLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 22);
            this.panel1.TabIndex = 5;
            // 
            // AmplificationTrackBar
            // 
            this.AmplificationTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AmplificationTrackBar.Location = new System.Drawing.Point(10, 0);
            this.AmplificationTrackBar.Maximum = 36;
            this.AmplificationTrackBar.Minimum = -36;
            this.AmplificationTrackBar.Name = "AmplificationTrackBar";
            this.AmplificationTrackBar.Size = new System.Drawing.Size(85, 22);
            this.AmplificationTrackBar.TabIndex = 2;
            this.AmplificationTrackBar.ValueChanged += new System.EventHandler(this.AmplificationTrackBar_ValueChanged);
            // 
            // PlusAmplificationLabel
            // 
            this.PlusAmplificationLabel.AutoSize = true;
            this.PlusAmplificationLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.PlusAmplificationLabel.Location = new System.Drawing.Point(95, 0);
            this.PlusAmplificationLabel.Name = "PlusAmplificationLabel";
            this.PlusAmplificationLabel.Size = new System.Drawing.Size(13, 13);
            this.PlusAmplificationLabel.TabIndex = 1;
            this.PlusAmplificationLabel.Text = "+";
            // 
            // MinusAmplificationLabel
            // 
            this.MinusAmplificationLabel.AutoSize = true;
            this.MinusAmplificationLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MinusAmplificationLabel.Location = new System.Drawing.Point(0, 0);
            this.MinusAmplificationLabel.Name = "MinusAmplificationLabel";
            this.MinusAmplificationLabel.Size = new System.Drawing.Size(10, 13);
            this.MinusAmplificationLabel.TabIndex = 0;
            this.MinusAmplificationLabel.Text = "-";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(243, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(114, 28);
            this.tableLayoutPanel7.TabIndex = 14;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.ScaleAddButton, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.ScaleLabel, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.ScaleSubButton, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(108, 22);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // ScaleAddButton
            // 
            this.ScaleAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScaleAddButton.Image = global::Sibsound.Properties.Resources.arrow_right;
            this.ScaleAddButton.Location = new System.Drawing.Point(75, 3);
            this.ScaleAddButton.Name = "ScaleAddButton";
            this.ScaleAddButton.Size = new System.Drawing.Size(30, 16);
            this.ScaleAddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScaleAddButton.TabIndex = 11;
            this.ScaleAddButton.TabStop = false;
            this.ScaleAddButton.Click += new System.EventHandler(this.ScaleAddButton_Click);
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScaleLabel.Location = new System.Drawing.Point(39, 0);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(30, 22);
            this.ScaleLabel.TabIndex = 10;
            this.ScaleLabel.Text = "SCALE";
            this.ScaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScaleSubButton
            // 
            this.ScaleSubButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScaleSubButton.Image = global::Sibsound.Properties.Resources.arrow_left;
            this.ScaleSubButton.Location = new System.Drawing.Point(3, 3);
            this.ScaleSubButton.Name = "ScaleSubButton";
            this.ScaleSubButton.Size = new System.Drawing.Size(30, 16);
            this.ScaleSubButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScaleSubButton.TabIndex = 12;
            this.ScaleSubButton.TabStop = false;
            this.ScaleSubButton.Click += new System.EventHandler(this.ScaleSubButton_Click);
            // 
            // AddAudioFromFileButton
            // 
            this.AddAudioFromFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddAudioFromFileButton.Image = global::Sibsound.Properties.Resources.addSound;
            this.AddAudioFromFileButton.Location = new System.Drawing.Point(163, 3);
            this.AddAudioFromFileButton.Name = "AddAudioFromFileButton";
            this.AddAudioFromFileButton.Size = new System.Drawing.Size(34, 28);
            this.AddAudioFromFileButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddAudioFromFileButton.TabIndex = 15;
            this.AddAudioFromFileButton.TabStop = false;
            this.AddAudioFromFileButton.Click += new System.EventHandler(this.AddAudioFromFileButton_Click);
            // 
            // AudioTimer
            // 
            this.AudioTimer.Tick += new System.EventHandler(this.AudioTimer_Tick);
            // 
            // AudioTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTableLayout);
            this.Name = "AudioTrack";
            this.Size = new System.Drawing.Size(784, 494);
            this.MainTableLayout.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ChannelsLayoutPanel.ResumeLayout(false);
            this.ChannelsLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftChannelPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightChannelPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedSampleBeginTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedSampleEndTrackBar)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SoundSaveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundLoadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteSegmentButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsertSegmentButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CopySegmentButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutSegmentButton)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceTrackBar)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmplificationTrackBar)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScaleAddButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleSubButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAudioFromFileButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.ToolTip AmplificationCurrentValueToolTip;
        private System.Windows.Forms.ToolTip BalanceCurrentValueToolTip;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel ChannelsLayoutPanel;
        private System.Windows.Forms.PictureBox LeftChannelPictureBox;
        private System.Windows.Forms.PictureBox RightChannelPictureBox;
        private System.Windows.Forms.Label LeftChannelLabel;
        private System.Windows.Forms.Label RightChannelLabel;
        private System.Windows.Forms.Timer AudioTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.PictureBox InsertSegmentButton;
        private System.Windows.Forms.PictureBox CopySegmentButton;
        private System.Windows.Forms.PictureBox CutSegmentButton;
        private System.Windows.Forms.PictureBox SoundSaveButton;
        private System.Windows.Forms.PictureBox SoundLoadButton;
        private System.Windows.Forms.PictureBox DeleteSegmentButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SelectedSampleEndLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SelectedSampleBeginLabel;
        private System.Windows.Forms.PictureBox PlayButton;
        private System.Windows.Forms.PictureBox StopButton;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar BalanceTrackBar;
        private System.Windows.Forms.Label RightBalanceLabel;
        private System.Windows.Forms.Label LeftBalanceLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar AmplificationTrackBar;
        private System.Windows.Forms.Label PlusAmplificationLabel;
        private System.Windows.Forms.Label MinusAmplificationLabel;
        private System.Windows.Forms.PictureBox AddAudioFromFileButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox ScaleAddButton;
        private System.Windows.Forms.Label ScaleLabel;
        private System.Windows.Forms.PictureBox ScaleSubButton;
        private System.Windows.Forms.TrackBar SelectedSampleBeginTrackBar;
        private System.Windows.Forms.TrackBar SelectedSampleEndTrackBar;
    }
}
