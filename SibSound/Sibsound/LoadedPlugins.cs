using IPlugin;
using Sibsound.Plugins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sibsound
{
    public partial class LoadedPlugins : Form
    {
        PluginManager pluginManager;
        public LoadedPlugins(PluginManager pluginManager)
        {
            InitializeComponent();
            this.pluginManager = pluginManager;

            dataGridView1.Columns.Add("Name", "Имя");
            dataGridView1.Columns.Add("Author", "Автор");
            dataGridView1.Columns.Add("Description", "Описание");
            dataGridView1.Columns.Add("Version", "Версия");

            foreach (var plugin in pluginManager.Plugins)
            {
                dataGridView1.Rows.Add(plugin.Name(), plugin.Author(), plugin.Description(), plugin.Version());
            }
        }
    }
}
