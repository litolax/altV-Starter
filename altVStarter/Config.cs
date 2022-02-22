﻿using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace altVStarter
{
    public interface IConfig<out T>
    {
        T Entries { get; }
    }

    public class Config<T> : IConfig<T>
    {
        private static T ReadConfig()
        {
            var file = new FileInfo("./config.json");
            if (!file.Exists)
                throw new FileNotFoundException(
                    "Config file not found, please create config.json file in the root directory!");

            var fileData = File.ReadAllText(file.FullName);
            var data = JsonSerializer.Deserialize<T>(fileData);
            if (data is null) throw new FileLoadException("Can't load " + typeof(T).Name + " config");
            return data;
        }

        public Config()
        {
            var file = new FileInfo("./config.json");
            if (!file.Exists)
            {
                MessageBox.Show("Config file not found, please create config.json file in the root directory!", "Exception");
                Application.Exit();
            }
            else this.Entries = ReadConfig();
        }

        public T Entries { get; }
    }
}