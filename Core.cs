using Asterism;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Asterism
{
    public static class Core
    {
        public static Config Config;
        public static FormEasyFiler EzFiler;
        public static readonly string ConfigFilePath = Application.UserAppDataPath + "\\config.xml";
        public static readonly int MajourVersion = 2;
        public static readonly int MinorVersion = 0;
        public static readonly int Revision = 0;
        public static string VerInfo { get { return string.Format(@"asterism v{0}.{1}.{2} β", MajourVersion, MinorVersion, Revision); } }
    }

    static class Files
    {
        /// <summary>
        /// XMLファイルへオブジェクトをシリアライズします。
        /// </summary>
        /// <typeparam name="Type">シリアライズする型</typeparam>
        /// <param name="fpath">保存先のファイルパス</param>
        /// <param name="cfgclass">シリアライズするオブジェクト</param>
        public static void SaveXML<Type>(string fpath, Type cfgclass)
        {
            var xsz = new XmlSerializer(typeof(Type));
            using (var fs = new FileStream(fpath, FileMode.Create, FileAccess.Write))
            {
                xsz.Serialize(fs, cfgclass);
            }
        }

        /// <summary>
        /// XMLファイルからオブジェクトをデシリアライズします。
        /// </summary>
        /// <typeparam name="Type">デシリアライズする型</typeparam>
        /// <param name="fpath">読込先のファイルパス</param>
        /// <param name="raiseFileNotFoundException">ファイルが存在しないときにFileNotFoundExceptionを発生させるか</param>
        /// <returns>デシリアライズしたオブジェクト</returns>
        public static Type LoadXML<Type>(string fpath, bool raiseFileNotFoundException)
        {
            if (!File.Exists(fpath))
            {
                if (raiseFileNotFoundException)
                    throw new FileNotFoundException("ファイル " + fpath + "が見つかりません。");
                return default(Type);
            }

            var xsz = new XmlSerializer(typeof(Type));
            using (var fs = new FileStream(fpath, FileMode.Open, FileAccess.Read))
            {
                return (Type)xsz.Deserialize(fs);
            }
        }
    }
}
