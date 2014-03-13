using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using CodeD.Data;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;

namespace Asterism
{
    /// <summary>
    /// イメージビューア
    /// 
    /// TO DO:
    /// - 起動時のサイズ
    /// 
    /// last modefied:
    /// 10/11/29
    /// + DockContentとして色々仕様変更
    /// + 描画モードの追加
    /// 09/11/15
    /// + 描画モード2パターン実装
    /// 09/11/15
    /// - 仮実装
    /// </summary>
    public partial class FormImage : DockContent
    {
        FormMain main;
        ZMappingData zMap;
        enum DisplayMode { アスペクト比固定=0, 縦方向最大=1, DotByDot=2, 任意=3};

        public FormImage(FormMain main)
        {
            InitializeComponent();
            InitializeComboBox();

            this.main = main;
        }

        string WidthText { get { return toolStripTextBoxWidth.Text; } }
        string HeightText { get { return toolStripTextBoxHeight.Text; } }

        /// <summary>
        /// comboBoxの設定
        /// </summary>
        private void InitializeComboBox()
        {
            toolStripComboBoxConvertMode.Items.AddRange(Enum.GetNames(typeof(ZMappingData.ConvertMode)));
            toolStripComboBoxConvertMode.SelectedIndex = 0;

            toolStripComboBoxColorMode.Items.AddRange(Enum.GetNames(typeof(ZMappingData.ColorMode)));
            toolStripComboBoxColorMode.SelectedIndex = 1;

            toolStripComboBoxDrawMode.Items.AddRange(Enum.GetNames(typeof(DisplayMode)));
            toolStripComboBoxDrawMode.SelectedIndex = 2;

            toolStripComboBoxInterpolationMethod.Items.AddRange(Enum.GetNames(typeof(InterpolationMode)));
            toolStripComboBoxInterpolationMethod.Items.RemoveAt(7);
            toolStripComboBoxInterpolationMethod.Items.RemoveAt(7);
            toolStripComboBoxInterpolationMethod.SelectedIndex = 5;
        }

        /// <summary>
        /// 描画ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonRedraw_Click(object sender, EventArgs e)
        {
            if(zMap.Data !=null) DrawImage();
        }

        /// <summary>
        /// 文字列チェック後指定した横幅に補完して、イメージを描画
        /// </summary>
        /// <param name="p"></param>
        private void DrawImage()
        {
            int width, h;
            if (int.TryParse(WidthText, out width) && int.TryParse(HeightText, out h)
                && width > 0 && h > 0)
            {
                ResetImageSize();
                DrawImage(width, h);
            }
            else
            {
                MessageBox.Show("Widthには正の整数値を入力してください。");
            }
        }

        /// <summary>
        /// 指定した横幅に補完して、イメージを描画
        /// </summary>
        /// <param name="width"></param>
        private void DrawImage(int width, int height)
        {
            double? min = null, max = null;
            double temp;

            // 最大値の決定 ----------------------------------------------------------------------
            if (toolStripTextBoxMax.Text == "")
            {
                toolStripTextBoxMax.BackColor = SystemColors.Window;
            }
            else if (Double.TryParse(toolStripTextBoxMax.Text, out temp))
            {
                max = temp;
                toolStripTextBoxMax.BackColor = SystemColors.Window;
            }
            else
            {
                MessageBox.Show("最大値に入力された文字列は、数値として扱えません。最大値を自動決定します。");
                toolStripTextBoxMax.BackColor = Color.LightPink; 
            }

            // 最小値の決定 ----------------------------------------------------------------------
            if (toolStripTextBoxMin.Text == "")
            {
                toolStripTextBoxMin.BackColor = SystemColors.Window;
            }
            else if( Double.TryParse(toolStripTextBoxMin.Text, out temp)) 
            {
                min = temp;
                toolStripTextBoxMin.BackColor = SystemColors.Window;
            }
            else
            {
                MessageBox.Show("最小値に入力された文字列は、数値として扱えません。最小値を自動決定します。");
                toolStripTextBoxMin.BackColor = Color.LightPink; 
            }

            // 画像の生成 ------------------------------------------------------------------------
            Bitmap image = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(image);
            g.InterpolationMode = (InterpolationMode)toolStripComboBoxInterpolationMethod.SelectedIndex;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.DrawImage(
                zMap.ToBitmap(min, max,
                    (ZMappingData.ColorMode)toolStripComboBoxColorMode.SelectedIndex,
                    (ZMappingData.ConvertMode)toolStripComboBoxConvertMode.SelectedIndex),
                    0, 0, width, height);

            pictureBoxZMap.Image = image;
        }

        private void toolStripButtonCopyToClipboard_Click(object sender, EventArgs e)
        {
            if (zMap.Data != null) Clipboard.SetImage(pictureBoxZMap.Image);
        }

        internal void SetImage()
        {
            zMap = main.CurrentZMapData;
            if (zMap.Data != null)
            {
                ResetImageSize();
                DrawImage();
            }
            else
            {
                toolStripTextBoxWidth.Enabled = false;
                toolStripTextBoxHeight.Enabled = false;
                pictureBoxZMap.Image = null;
            }
        }

        /// <summary>
        /// 描画モードに合わせて値を設定
        /// </summary>
        private void ResetImageSize()
        {
            switch (toolStripComboBoxDrawMode.SelectedIndex)
            {
                case (int)DisplayMode.アスペクト比固定:
                    float bairitsu = float.Parse(WidthText) / (float)zMap.XSize;
                    int height = (int)(zMap.YSize * bairitsu);
                    toolStripTextBoxHeight.Text = height.ToString();
                    if (height == 0) toolStripTextBoxHeight.Text = "1";

                    toolStripTextBoxWidth.Enabled = true;
                    toolStripTextBoxHeight.Enabled = false; 
                    break;

                case (int)DisplayMode.縦方向最大:
                    toolStripTextBoxHeight.Text = pictureBoxZMap.Size.Height.ToString();

                    toolStripTextBoxWidth.Enabled = true;
                    toolStripTextBoxHeight.Enabled = false; 
                    break;

                case (int)DisplayMode.DotByDot:
                    toolStripTextBoxHeight.Text = zMap.YSize.ToString();
                    toolStripTextBoxWidth.Text = zMap.XSize.ToString();

                    toolStripTextBoxWidth.Enabled = false;
                    toolStripTextBoxHeight.Enabled = false;
                    break;


                case (int)DisplayMode.任意:

                    toolStripTextBoxWidth.Enabled = true;
                    toolStripTextBoxHeight.Enabled = true;
                    break;

                default:
                    throw new ApplicationException("存在しない描画モードが選択されました。");
            }
        }

        /// <summary>
        /// サイズ設定変更時 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripComboBoxDrawMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (zMap == null) return;

            ResetImageSize();
        }



        /// <summary>
        /// Enter key で入力確定時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripTextBoxWidth_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int v;
                if (int.TryParse(toolStripTextBoxWidth.Text, out v) && v > 0)
                {
                    DrawImage();
                }
                else
                {
                    MessageBox.Show("正の整数値を入力して下さい。");
                }
            }
        }

        private void toolStripTextBoxHeight_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int h;
                if (int.TryParse(HeightText, out h) && h > 0)
                {
                    DrawImage();
                }
                else
                {
                    MessageBox.Show("正の整数値を入力して下さい。");
                }
            }
        }

        /// <summary>
        /// 画像ファイルとして保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "画像ファイルとして保存";
            dialog.SupportMultiDottedExtensions = true;
            dialog.RestoreDirectory = true;
            dialog.OverwritePrompt = true;
            dialog.AutoUpgradeEnabled = true;
            dialog.Filter = "PNGファイル(*.png)|*.png";
            dialog.InitialDirectory = Directory.GetCurrentDirectory();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxZMap.Image.Save(dialog.FileName);
            }
        }


    }
}
