using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Asterism
{
    public partial class FormUserConfig : Form
    {
        public FormUserConfig()
        {
            InitializeComponent();
            InitializeSetting();
        }

        private void InitializeSetting()
        {
            if (Config.ExitWithSavingDirectoryInfo) radioButtonAutoSave.Checked = true;
            else radioButtonUserDefine.Checked = true;

            folderBrowserDialog.SelectedPath = textBoxInitialDirectory.Text
                = Config.InitialDirectory;

            numericUpDownFileMaskNumber.Value = Config.FileMaskNumber;

            numericUpDownAlarmFileSize.Value = Config.AlarmFileSize;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Config.ExitWithSavingDirectoryInfo = radioButtonAutoSave.Checked;

            if(!radioButtonAutoSave.Checked)
                Config.InitialDirectory = textBoxInitialDirectory.Text;

            Config.FileMaskNumber = (int)numericUpDownFileMaskNumber.Value;

            Config.AlarmFileSize = (int)numericUpDownAlarmFileSize.Value;

            this.Close();
        }

        private void radioButtonAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            textBoxInitialDirectory.Enabled = buttonSelectInitialDirectory.Enabled = !radioButtonAutoSave.Checked;
        }

        private void buttonSelectInitialDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxInitialDirectory.Text = folderBrowserDialog.SelectedPath;
            }

        }
    }
}
