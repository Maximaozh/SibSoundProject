using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sibsound.Plugins
{
    public class PluginManager
    {
        public List<IPlugin.IPlugin> Plugins { get; set; }

        public PluginManager()
        {
            Plugins = new List<IPlugin.IPlugin>();
        }

        public bool LoadFromFile(string file)
        {
            Assembly assembly = Assembly.LoadFrom(file);

            Type[] types = assembly.GetExportedTypes();
            foreach(Type t in types) 
            {
                if(t.GetInterfaces().Contains(typeof(IPlugin.IPlugin)))
                {
                    IPlugin.IPlugin plugin = (IPlugin.IPlugin)Activator.CreateInstance(t);
                    
                    foreach(var pluginCompare in Plugins)
                    {
                        if (pluginCompare.GUID() == plugin.GUID())
                            return false;
                    }
                    Plugins.Add(plugin);
                }
            }

            return true;
        }
        public int LoadFromDirectory(string folderPath)
        {
            if (!Directory.Exists(folderPath))
                return -1;
            // Получаем список файлов в папке
            string[] files = Directory.GetFiles(folderPath, "*.dll", SearchOption.AllDirectories);

            int counter = 0;

            foreach (var file in files)
            {
                try
                {
                    counter = LoadFromFile(file) ? counter + 1 : counter;
                } catch (Exception ex) 
                {
                }
            }

            return counter;
        }
    }
}
