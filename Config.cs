using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Asterism
{
    internal static class Config
    {
        const string configFile = @"\zmap.cfg";

        internal static bool ExitWithSavingDirectoryInfo {get;set;}
        internal static string InitialDirectory { get; set; }
        internal static int FileMaskNumber { get; set; }
        internal static int AlarmFileSize { get; set; }

        internal static string MaximumValue { get; set; }
        internal static string MinimumValue { get; set; }

        internal static bool ShowStrings { get; set; }

        /// <summary>
        /// configファイルを保存
        /// </summary>
        internal static void Save()
        {
            StringBuilder contents = new StringBuilder();
            contents.AppendLine(ExitWithSavingDirectoryInfo.ToString());
            contents.AppendLine(InitialDirectory);
            contents.AppendLine(FileMaskNumber.ToString());
            contents.AppendLine(MaximumValue);
            contents.AppendLine(MinimumValue);
            contents.AppendLine(AlarmFileSize.ToString());

            File.WriteAllText(Application.StartupPath + configFile, contents.ToString());
        }

        /// <summary>
        /// configファイルを読み込み
        /// </summary>
        internal static void Load()
        {
            try
            {
                string[] contents = File.ReadAllLines(Application.StartupPath + configFile);
                ExitWithSavingDirectoryInfo = bool.Parse(contents[0]);
                InitialDirectory = contents[1];
                FileMaskNumber = int.Parse(contents[2]);
                MaximumValue = contents[3];
                MinimumValue = contents[4];
                AlarmFileSize = int.Parse(contents[5]);
            }
            catch
            {
                LoadDefault();
            }
        }

        /// <summary>
        /// Default値をロード
        /// </summary>
        private static void LoadDefault()
        {
            ExitWithSavingDirectoryInfo = true;
            InitialDirectory = "";
            FileMaskNumber = 5;
            MaximumValue = "";
            MinimumValue = "";
            AlarmFileSize = 20;
        }

    }
}
