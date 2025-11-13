using CodeD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            label11.Text = "visualize CSV/TSV files in Counter Plot & Line Chart";

            label2.Text = "Copyright 2009-2014(c) D*isuke YAMAKAWA";
            linkLabel1.Text = "http://www.clockahead.com";

            label3.Text = "Version 情報：";
            FileVersionInfo vi = FileVersionInfo.GetVersionInfo("ZedGraph.dll");
            FileVersionInfo vi2 = FileVersionInfo.GetVersionInfo("WeifenLuo.WinFormsUI.Docking.dll");
            textBox1.Text = string.Format(@"asterism : Ver.{0}.{1}.{2} β", Core.MajourVersion, Core.MinorVersion, Core.Revision) + Environment.NewLine
                             + "CodeD.CSV2Heatmap : (NuGet Package)" + Environment.NewLine
                             + string.Format("{0} : Ver.{1}", vi.InternalName,vi.FileVersion) + Environment.NewLine
                             + string.Format("{0} : Ver.{1}", vi2.InternalName, vi2.FileVersion) + Environment.NewLine;
            
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
