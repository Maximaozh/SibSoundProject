using IPlugin;
using Sibsound.Audios;
using Sibsound.Plugins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sibsound
{
    public partial class MainWindow : Form
    {
        PluginManager pluginManager;
        private Process LoggerExecutable { get; set; }

        public void InversePluginAccess()
        {
            this.SettignsToolStripMenuItem.Enabled = !this.SettignsToolStripMenuItem.Enabled;
        }

        public MainWindow()
        {
            InitializeComponent();
            pluginManager = new PluginManager();
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Logger\\Logger.exe";
            SetLoggerExecutable(path);
        }

        private void SetLoggerExecutable(string pathToLoggerExecutable)
        {
            LoggerExecutable = new Process();
            LoggerExecutable.StartInfo.FileName = pathToLoggerExecutable;
            LoggerExecutable.StartInfo.CreateNoWindow = true;
            LoggerExecutable.StartInfo.UseShellExecute = false;
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdatePluginList()
        {
            this.PluginsToolStripMenuItem.DropDownItems.Clear();
            foreach (IPlugin.IPlugin plugin in pluginManager.Plugins)
            {
                ToolStripMenuItem pluginItem = new ToolStripMenuItem();
                pluginItem.Text = plugin.Name();
                pluginItem.Click += delegate (object sender, EventArgs e)
                {
                    AudioTrack.CalculateFrameBorders(out AudioTrack.begin, out AudioTrack.end);
                    plugin.Run(ref AudioTrack.audio, ref AudioTrack.begin, ref AudioTrack.end);
                    AudioTrack.Configure();
                    AudioTrack.Draw();
                    LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%Плагин%" + plugin.Name() + " выполняет свою задачу%";
                    LoggerExecutable.Start();
                };
                PluginsToolStripMenuItem.DropDownItems.Add(pluginItem);
            }
        }


        private void LoadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Dynamic load library|*.dll";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string selectedFileName = "";
            selectedFileName = openFileDialog.FileName;

            pluginManager.LoadFromFile(selectedFileName);

            UpdatePluginList();

            string result = "";
            foreach (var plugin in pluginManager.Plugins)
            {
                result += plugin.Name() + " ";
            }
            LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%Плагин%Обновление. Текущий список " + result + "%";
            LoggerExecutable.Start();
        }

        private void LoadDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog.Description = "Выберите директорию";
            folderBrowserDialog.ShowNewFolderButton = true;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                pluginManager.LoadFromDirectory(selectedPath);

                UpdatePluginList();

                string result = "";
                foreach(var plugin in pluginManager.Plugins) {
                    result += plugin.Name() + " ";
                }

                LoggerExecutable.StartInfo.Arguments = DateTime.Now + "%Плагин%Обновление. Текущий список " + result + "%";
                LoggerExecutable.Start();
            }
        }

        private void LoadedPluginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var loaded = new LoadedPlugins(pluginManager);
            loaded.ShowDialog();
        }
    }
}
