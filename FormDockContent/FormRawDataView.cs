using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CodeD.Data;
using WeifenLuo.WinFormsUI.Docking;

namespace Asterism
{
    public partial class FormRawDataView : DockContent
    {
        FormMain main;

        public FormRawDataView(FormMain main)
        {
            InitializeComponent();

            this.main = main;
        }

        public void SetRawData()
        {
            if (main.CurrentZMapData != null && main.CurrentZMapData.Header.Length != 0)
            {
                textBox.Text = main.CurrentZMapData.Header;
            }else
            {
                textBox.Text = "- Header Not Found -";
            }

            textBox.SelectionStart = textBox.Text.Length;
        }

        
    }
}
