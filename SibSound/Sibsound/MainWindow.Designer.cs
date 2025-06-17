using System.Drawing;

namespace Sibsound
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettignsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadedPluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.SettignsToolStripMenuItem,
            this.PluginsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // SettignsToolStripMenuItem
            // 
            this.SettignsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadFileToolStripMenuItem,
            this.LoadDirectoryToolStripMenuItem,
            this.LoadedPluginsToolStripMenuItem});
            this.SettignsToolStripMenuItem.Name = "SettignsToolStripMenuItem";
            this.SettignsToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.SettignsToolStripMenuItem.Text = "Настройки плагинов";
            // 
            // LoadFileToolStripMenuItem
            // 
            this.LoadFileToolStripMenuItem.Name = "LoadFileToolStripMenuItem";
            this.LoadFileToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.LoadFileToolStripMenuItem.Text = "Загрузить файл";
            this.LoadFileToolStripMenuItem.Click += new System.EventHandler(this.LoadFileToolStripMenuItem_Click);
            // 
            // LoadDirectoryToolStripMenuItem
            // 
            this.LoadDirectoryToolStripMenuItem.Name = "LoadDirectoryToolStripMenuItem";
            this.LoadDirectoryToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.LoadDirectoryToolStripMenuItem.Text = "Загрузить директорию";
            this.LoadDirectoryToolStripMenuItem.Click += new System.EventHandler(this.LoadDirectoryToolStripMenuItem_Click);
            // 
            // LoadedPluginsToolStripMenuItem
            // 
            this.LoadedPluginsToolStripMenuItem.Name = "LoadedPluginsToolStripMenuItem";
            this.LoadedPluginsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.LoadedPluginsToolStripMenuItem.Text = "Загруженные плагины";
            this.LoadedPluginsToolStripMenuItem.Click += new System.EventHandler(this.LoadedPluginsToolStripMenuItem_Click);
            // 
            // PluginsToolStripMenuItem
            // 
            this.PluginsToolStripMenuItem.Name = "PluginsToolStripMenuItem";
            this.PluginsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.PluginsToolStripMenuItem.Text = "Плагины";
            // 
            // AudioTrack
            // 
            this.AudioTrack = new AudioTrack();
            this.AudioTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AudioTrack.Location = new System.Drawing.Point(0, 24);
            this.AudioTrack.Name = "AudioTrack";
            this.AudioTrack.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 601);
            this.Controls.Add(this.AudioTrack);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "SibSound";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettignsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadedPluginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PluginsToolStripMenuItem;
        private AudioTrack AudioTrack;
    }
}

