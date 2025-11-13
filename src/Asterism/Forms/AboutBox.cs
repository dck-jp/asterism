using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Asterism
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();

            foreach (Control control in this.Controls) { control.Font = new Font(new FontFamily("Meiryo uI"), 10.5f); }

            label1.Text = "asterism";
            label1.Font = new Font(new FontFamily("Meiryo uI"), 18f, FontStyle.Bold);
            label11.Text = "CSV, TSV File Visualizer for researchers";

            label2.Text = "Copyright 2009-2025(c) dck-jp";
            linkLabel1.Text = "https://github.com/dck-jp/asterism";
            
            // アプリケーションバージョンとライブラリバージョンを表示
            var versionInfo = new StringBuilder();
            versionInfo.AppendLine($"asterism Ver.{Core.MajourVersion}.{Core.MinorVersion}.{Core.Revision}");
            versionInfo.AppendLine();
            versionInfo.AppendLine("使用ライブラリ：");
            
            // 読み込まれているアセンブリからバージョンを取得
            var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies();
            var libraryNames = new[]
            {
                "CodeD.CSV2Heatmap",
                "WeifenLuo.WinFormsUI.Docking",
                "WeifenLuo.WinFormsUI.Docking.ThemeVS2015",
                "ZedGraph"
            };

            foreach (var libName in libraryNames)
            {
                var assembly = loadedAssemblies.FirstOrDefault(a => 
                    a.GetName().Name.Equals(libName, StringComparison.OrdinalIgnoreCase));
                
                if (assembly != null)
                {
                    versionInfo.AppendLine($"  {libName}");
                }
                else
                {
                    versionInfo.AppendLine($"  {libName} (未読み込み)");
                }
            }
            
            textBox1.Text = versionInfo.ToString();
        }

        #region アセンブリ属性アクセサ

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                if (titleAttribute.Title != "")
                {
                    return titleAttribute.Title;
                }
            }
            return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().Location);
        }
    }        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }
    }
}
