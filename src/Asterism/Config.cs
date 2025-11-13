using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using Asterism;
using System.Xml.Serialization;

namespace Asterism
{
    public class Config
    {
        public Config() {    
        }

        public bool ExitWithSavingDirectoryInfo = true;
        public string InitialDirectory = "";
        public int FileMaskNumber = 5;
        public int AlarmFileSize = 20;

        public string MaximumValue = "";
        public string MinimumValue = "";
        public bool ShowStrings = true;

        public bool EnablesOutOfRangeColor = false;
        [XmlIgnore()]
        public Color _OutOfRangeColor = Color.White;
        [XmlIgnore()]
        public Color OutOfRangeColor {
            get { return Color.FromArgb(r, g, b); }
            set { 
                _OutOfRangeColor = value;
                r = value.R;
                g = value.G;
                b = value.B;
            }
        }
        public byte r  = 0;
        public byte b  = 0;
        public byte g  = 0;
        
        
        public void Save()
        {
            Files.SaveXML<Config>(Core.ConfigFilePath, this);
        }

        public static Config Load()
        {
            if (File.Exists(Core.ConfigFilePath))
            {
                return Files.LoadXML<Config>(Core.ConfigFilePath, true);
            }
            else
            {
                return new Config();
            }
        }
    }
}
