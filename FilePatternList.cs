using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Asterism
{
    internal class FilePatternList
    {
        List<string> filePattern;
        int max; //最大リスト保持数

        /// <summary>
        /// 
        /// </summary>
        /// <param name="max">リスト最大保持数</param>
        public FilePatternList(int max)
        {
            this.max = max;
            filePattern = new List<string>();
        }

        /// <summary>
        /// ファイルからリストを読み込み
        /// </summary>
        public void LoadListFile()
        {
            string listFile = Application.StartupPath + @"\patternlist";

            if (File.Exists(listFile))
            {
                string[] list = File.ReadAllLines(listFile);
                foreach (string str in list)
                {
                    Add(str);
                }
            }
        }

        public void SaveListFile()
        {
            File.WriteAllLines(Application.StartupPath + @"\patternlist", filePattern.ToArray());
        }

        /// <summary>
        /// ファイルパターンを追加
        /// </summary>
        /// <param name="newPattern"></param>
        public void Add(string newPattern)
        {
            if (!filePattern.Exists(str => str == newPattern))
            {
                filePattern.Add(newPattern);

                if (filePattern.Count > max)
                {
                    filePattern.RemoveAt(0);
                }
            }

        }

        /// <summary>
        /// 文字配列に変換
        /// </summary>
        /// <returns></returns>
        internal string[] ToArray()
        {
            List<string> listTemp = new List<string>();
            string[] temp = filePattern.ToArray();
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                listTemp.Add(temp[i]);
            }


            return listTemp.ToArray();
        }
    }
}
