using Asterism;
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
            if (Core.Config.ExitWithSavingDirectoryInfo) radioButtonAutoSave.Checked = true;
            else radioButtonUserDefine.Checked = true;

            folderBrowserDialog.SelectedPath = textBoxInitialDirectory.Text
                = Core.Config.InitialDirectory;

            numericUpDownFileMaskNumber.Value = Core.Config.FileMaskNumber;
            checkBoxShowStrings.Checked = Core.Config.ShowStrings;
            numericUpDownAlarmFileSize.Value = Core.Config.AlarmFileSize;

            checkBoxEnablesOutOfRangeColor.Checked = Core.Config.EnablesOutOfRangeColor;
            pictureBoxOutOfRangeColor.BackColor = Core.Config.OutOfRangeColor;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Core.Config.ExitWithSavingDirectoryInfo = radioButtonAutoSave.Checked;

            if(!radioButtonAutoSave.Checked)
                Core.Config.InitialDirectory = textBoxInitialDirectory.Text;

            Core.Config.ShowStrings = checkBoxShowStrings.Checked;
            Core.Config.FileMaskNumber = (int)numericUpDownFileMaskNumber.Value;

            Core.Config.AlarmFileSize = (int)numericUpDownAlarmFileSize.Value;

            Core.Config.EnablesOutOfRangeColor = checkBoxEnablesOutOfRangeColor.Checked;
            Core.Config.OutOfRangeColor = pictureBoxOutOfRangeColor.BackColor;

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

        private void pictureBoxOutOfRangeColor_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            dialog.Color = pictureBoxOutOfRangeColor.BackColor;
            dialog.FullOpen = true;
            dialog.AnyColor = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxOutOfRangeColor.BackColor = dialog.Color;
            }
        }
    }
}
