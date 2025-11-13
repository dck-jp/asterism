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
    public partial class FormRotate : Form
    {
        /// <summary>
        /// 指定回転角[rad]
        /// </summary>
        internal double Angle { get; set; }
        
        public FormRotate()
        {
            InitializeComponent();
        }

        /// <summary>
        /// OKクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonDegree.Checked)
            {
                Angle = (double)numericUpDownDegree.Value * Math.PI / 180;
            }
            else if (radioButtonRadian.Checked)
            {
                double parsedRad;
                if (!double.TryParse(textBoxRadian.Text, out parsedRad))
                {
                    MessageBox.Show("入力文字が数値として認識できません");
                    return;
                }

                Angle = parsedRad;
            }

            Close();
        }

        /// <summary>
        /// rad選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonRadian_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownDegree.Enabled = false;
            textBoxRadian.Enabled = true;
        }

        /// <summary>
        /// degree選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonDegree_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownDegree.Enabled = true;
            textBoxRadian.Enabled = false;
        }
    }
}
