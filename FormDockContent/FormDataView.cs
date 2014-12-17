using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Diagnostics;
using System.IO;
using CodeD.Data;
using ZedGraph;
using System.Drawing.Drawing2D;

namespace Asterism
{
    public partial class FormDataView : DockContent
    {
        FormMain main; //親フォーム

        FileInfo currentFile; 
        ZMappingData zMap;
        Bitmap defaultBitmap;

        public Bitmap GetCurrentImage()
        {
            return defaultBitmap;
        }

        public FormDataView(FormMain main)
        {
            InitializeComponent();
            InitializeComboBoxes();
            InitializeZedGraphs();

            this.main = main;
            timerCheckCursorPosition.Start();
        }

        /// <summary>
        /// 表示するファイルの設定
        /// </summary>
        /// <param name="path"></param>
        internal void SetCurrentFile(string path)
        {
            currentFile = new FileInfo(path);
            LoadFileData();

            if (zMap != null && zMap.Data != null)
            {
                DrawZMap();
                DrawLineOnZMap();
                DrawGraph();
                SetParameters();
            }
            else
            {
                pictureBoxZMap.Image = null;

                ClearGraphs();

                textBoxMin.Text = "N/A";
                textBoxMax.Text = "N/A";
                textBoxDataSize.Text = "";
                textBoxPV.Text = "";
                main.SetTitle("no data");
            }

            //親フォームにZMap情報を設定
            main.CurrentZMapData = zMap;
        }

        private void ClearGraphs()
        {
            zedGraphControlVertical.GraphPane.CurveList.Clear();
            zedGraphControlHorizontal.GraphPane.CurveList.Clear();

            zedGraphControlVertical.Refresh();
            zedGraphControlHorizontal.Refresh();
        }

        /// <summary>
        /// 選択中のラインを表示
        /// </summary>
        private void DrawLineOnZMap()
        {
            int x0 = (int)numericUpDownVertical.Value;
            int xSelected = (2*x0 + 1) * pictureBoxZMap.Size.Width / (zMap.XSize) /2;

            int y0 = (int)numericUpDownHorizontal.Value;
            int ySelected = (2*y0 +1)* pictureBoxZMap.Size.Height / (zMap.YSize) /2;

            pictureBoxZMap.Image = defaultBitmap;
            this.Refresh();
            Graphics g = pictureBoxZMap.CreateGraphics();
            Pen penH = new Pen(Color.White) { DashStyle = DashStyle.Dash };
            Pen penV = new Pen(Color.White) { DashStyle = DashStyle.Dash };
            g.DrawLine(penV, xSelected, 0, xSelected, pictureBoxZMap.Height);
            g.DrawLine(penH, 0, ySelected, pictureBoxZMap.Width, ySelected);
            g.Dispose();

        }

        /// <summary>
        /// 現在位置のグラフを表示
        /// - numUpDown読み込み
        /// </summary>
        private void DrawGraph()
        {
            //たてライン番号取得
            int x0 = (int)numericUpDownVertical.Value;
            if (x0 >= zMap.XSize)
            {
                numericUpDownVertical.Value = 0;
                return;
            }

            //よこライン番号取得
            int y0 = (int)numericUpDownHorizontal.Value;
            if (y0 >= zMap.YSize)
            {
                numericUpDownHorizontal.Value = 0;
                return;
            }

            //たて・よこグラフ描画
            SetGraphVertical(zMap.GetColumnData(x0));
            SetGraphHorizontal(zMap.GetRowData(y0));
        }

        /// <summary>
        /// 縦のグラフ表示
        /// </summary>
        /// <param name="data"></param>
        private void SetGraphVertical(double[] data)
        {
            GraphPane myPane = zedGraphControlVertical.GraphPane;
            myPane.CurveList.Clear();

            var position = new double[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                position[i] = -i;
            }

            LineItem myCurve = myPane.AddCurve("Vertical profile", data, position, Color.Red, SymbolType.None);

            myPane.YAxis.Scale.Max = position.Max() + 0.5;
            myPane.YAxis.Scale.Min = position.Min() - 0.5;
            

            myPane.AxisChange();
            zedGraphControlVertical.Refresh();
        }

        /// <summary>
        /// 横のグラフを表示
        /// </summary>
        /// <param name="data"></param>
        private void SetGraphHorizontal(double[] data)
        {
            GraphPane myPane = zedGraphControlHorizontal.GraphPane;
            myPane.CurveList.Clear();

            var position = new double[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                position[i] = i;
            }

            LineItem myCurve = myPane.AddCurve("Horizontal profile", position, data, Color.Blue, SymbolType.None);

            myPane.XAxis.Scale.Max = position.Max() + 0.5;
            myPane.XAxis.Scale.Min = position.Min() - 0.5;

            myPane.AxisChange();
            zedGraphControlHorizontal.Refresh();
        }

        /// <summary>
        /// zMapの各種パラメータ表示
        /// + mainのタイトル変更
        /// </summary>
        /// <param name="filename"></param>
        private void SetParameters()
        {
            // numericUpDownの上限設定
            numericUpDownVertical.Maximum = zMap.XSize - 1;
            numericUpDownHorizontal.Maximum = zMap.YSize - 1;

            // ファイルのステータス表示
            textBoxDataSize.Text = zMap.XSize.ToString() + " x " + zMap.YSize.ToString();

            textBoxMax.Text = zMap.Max.ToString("E6");
            textBoxMin.Text = zMap.Min.ToString("E6");

            textBoxPV.Text = (zMap.Max - zMap.Min).ToString("E6");

            main.SetTitle(currentFile.Name);
        }

        /// <summary>
        /// 2D図を作成
        /// - comboBoxColorMode読み込み
        /// </summary>
        private void DrawZMap()
        {
            double temp;
            double? min = null, max = null;
            try
            {
                if (checkBoxUserMin.Checked)
                {
                    if (Double.TryParse(textBoxUserMin.Text, out temp)) min = temp;
                    else throw new System.ApplicationException("最小値に入力された値は、数値として扱えません");
                }
                if (checkBoxUserMax.Checked)
                {
                    if (Double.TryParse(textBoxUserMax.Text, out temp)) max = temp;
                    else throw new System.ApplicationException("最大値に入力された値は、数値として扱えません");
                }

                int w = pictureBoxZMap.Size.Width;
                int h = pictureBoxZMap.Size.Height;

                Bitmap image = new Bitmap(w, h);
                  Graphics g = Graphics.FromImage(image);
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                
                zMap.EnablesOutOfRangeColor = Core.Config.EnablesOutOfRangeColor;
                zMap.OutOfRangeColor = Core.Config.OutOfRangeColor;
                var bitmap = zMap.ToBitmap(min, max, (ZMappingData.ColorMode)comboBoxColorMode.SelectedIndex, (ZMappingData.ConvertMode)comboBoxConvertMode.SelectedIndex);

                g.DrawImage(bitmap,0, 0, w, h);
                defaultBitmap = image;
                pictureBoxZMap.Image = image;
                //ChangeOperationMode(true);
            }
            catch (ApplicationException e)
            {
                MessageBox.Show(e.Message);
                //ClearAllItems();
                //ChangeOperationMode(false);
                //toolStripStatusLabel.Text = "入力エラー： " + e.Message;
                return;
            }
        }

        /// <summary>
        /// currentFile => zMap へ読み込み
        /// </summary>
        private void LoadFileData()
        {
            zMap = null;

            try
            {
                if (currentFile.Length > 1024 * 1024 * Core.Config.AlarmFileSize)
                {
                    if (MessageBox.Show(
                            "ファイルサイズが" + Core.Config.AlarmFileSize + "MBを超えています。\n"
                            + "読み込みをキャンセルします。\n"
                            + "\n"
                            + "読み込みファイルサイズの制限は、「設定」から変更可能です。",
                        "", MessageBoxButtons.OK)
                        == DialogResult.OK)
                    {
                        return;
                    }
                }

                if (Core.EzFiler.Mode == FormEasyFiler.FileLoadMode.XYZ)
                {
                    try
                    {
                        var xyz = new XYZData(currentFile.FullName, Core.EzFiler.ZColumnNumber);
                        var array = xyz.ToArray();
                        zMap = array != null ? new ZMappingData(array) : null ;
                        zMap.Header = xyz.Header;
                    }
                    catch(Exception e)
                    {
                        Debug.WriteLine(e.ToString());
                    }
                }
                else { zMap = new ZMappingData(currentFile.FullName, 0); }
            }
            catch (Exception e)
            {
                return;
            }
        }

        #region GUIコンポーネントの初期化
        /// <summary>
        /// comboboxの初期化
        /// </summary>
        private void InitializeComboBoxes()
        {
            //pattern = new FilePatternList(Config.FileMaskNumber);
            //pattern.LoadListFile();
            //comboBoxFilePattern.Items.AddRange(pattern.ToArray());

            comboBoxColorMode.Items.AddRange(Enum.GetNames(typeof(ZMappingData.ColorMode)));
            comboBoxColorMode.SelectedIndex = 1;

            comboBoxConvertMode.Items.AddRange(Enum.GetNames(typeof(ZMappingData.ConvertMode)));
            comboBoxConvertMode.SelectedIndex = 0;
        }

        /// <summary>
        /// グラフ領域の初期化
        /// </summary>
        private void InitializeZedGraphs()
        {
            GraphPane vPane = zedGraphControlVertical.GraphPane; //縦
            vPane.Border.IsVisible = false;
            vPane.Fill.Color = Color.FromKnownColor(KnownColor.Control);
            vPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            
            vPane.Title.IsVisible = false;
            vPane.Title.Text = "";
            vPane.Title.FontSpec.Size = 20;

            vPane.Legend.FontSpec.Size = 18;
            vPane.Legend.Position = LegendPos.InsideTopRight;

            vPane.XAxis.Title.Text = "Value";
            vPane.XAxis.Title.FontSpec.Size = 18;
            vPane.XAxis.Scale.FontSpec.Size = 18;
            vPane.XAxis.MajorGrid.IsVisible = true;
            vPane.XAxis.MajorGrid.PenWidth = 1;
            vPane.XAxis.MajorGrid.Color = Color.Gray;

            vPane.YAxis.Title.IsVisible = false;
            vPane.YAxis.Scale.IsVisible = false;
            vPane.YAxis.Scale.AlignH = AlignH.Right;
            vPane.YAxis.MajorGrid.IsZeroLine = false;
            // ___________________________________________

            GraphPane hPane = zedGraphControlHorizontal.GraphPane; //横
            hPane.Border.IsVisible = false;
            hPane.Fill.Color = Color.FromKnownColor(KnownColor.Control);
            hPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);

            hPane.Title.IsVisible = true;
            hPane.Title.Text = " ";
            hPane.Title.FontSpec.Size = 8;

            hPane.Legend.FontSpec.Size = 24;
            hPane.Legend.Position = LegendPos.InsideTopLeft;

            hPane.YAxis.Title.Text = "Value";
            hPane.YAxis.Title.FontSpec.Size = 24;
            hPane.YAxis.Scale.FontSpec.Size = 24;
            hPane.YAxis.Scale.IsUseTenPower = true;
            hPane.YAxis.Scale.Align = AlignP.Inside;
            hPane.YAxis.MajorGrid.IsVisible = true;
            hPane.YAxis.MajorGrid.PenWidth = 1;
            hPane.YAxis.MajorGrid.Color = Color.Gray;

            hPane.XAxis.IsVisible = false;
        }
        #endregion

        /// <summary>
        /// 再描画ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            DrawZMap();
            DrawLineOnZMap();
        }

        /// <summary>
        /// 最大値・最小値指定TextBox入力時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxUserMin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DrawZMap();
                DrawLineOnZMap();
            }
        }

        private void checkBoxUserMin_CheckedChanged(object sender, EventArgs e)
        {
            textBoxUserMin.Enabled = checkBoxUserMin.Checked;
        }

        private void checkBoxUserMax_CheckedChanged(object sender, EventArgs e)
        {
            textBoxUserMax.Enabled = checkBoxUserMax.Checked;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            DrawLineOnZMap();
            DrawGraph();
        }

        /// <summary>
        /// クリックしたライン番号を取得・設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxZMap_Click(object sender, EventArgs e)
        {
            if (zMap == null) return;
            Point clientPosition = pictureBoxZMap.PointToClient(Cursor.Position);
            int x0 = zMap.XSize * clientPosition.X / pictureBoxZMap.Size.Width;
            int y0 = zMap.YSize * clientPosition.Y / pictureBoxZMap.Size.Height;

            numericUpDownVertical.Value = x0;
            numericUpDownHorizontal.Value = y0;
        }

        /// <summary>
        /// 縦のラインをクリップボードに転送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCopyVerticalLine_Click(object sender, EventArgs e)
        {
            SetClipboard(zMap.GetColumnData((int)numericUpDownVertical.Value));
        }

        /// <summary>
        /// 横のラインをクリップボードに転送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCopyHorizontalLine_Click(object sender, EventArgs e)
        {
            SetClipboard(zMap.GetRowData((int)numericUpDownHorizontal.Value));
        }

        /// <summary>
        /// クリップボードに配列をコピー
        /// </summary>
        /// <param name="xData"></param>
        private void SetClipboard(double[] xData)
        {
            StringBuilder st = new StringBuilder();
            foreach (double one in xData)
            {
                st.AppendLine(one.ToString());
            }

            Clipboard.SetText(st.ToString());
        }

        /// <summary>
        /// カーソルがPictureBox内にある場合、カーソル位置情報更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCheckCursorPosition_Tick(object sender, EventArgs e)
        {
            if (zMap == null) return;
            if (zMap.Data == null) return;

            Point clientPosition = pictureBoxZMap.PointToClient(Cursor.Position);

            if (clientPosition.X < 0 || clientPosition.X >= pictureBoxZMap.Size.Width ||
                clientPosition.Y < 0 || clientPosition.Y >= pictureBoxZMap.Size.Height) return;

            int x0 = zMap.XSize * clientPosition.X / pictureBoxZMap.Size.Width;
            int y0 = zMap.YSize * clientPosition.Y / pictureBoxZMap.Size.Height;

            textBoxCursorXY.Text = @"( " + x0.ToString() + @" , " + y0.ToString() + @" )";
            textBoxCursorValue.Text = zMap.Data[x0, y0].ToString("E6");
        }

        private void comboBoxColorMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            double[,] forColorBar = new double[765,1];
            for (int i = 0; i < 765; i++)
            {
                forColorBar[i,0] = i;
            }
            ZMappingData colorBar = new ZMappingData(forColorBar);

            int w = pictureBoxColorBar.Size.Width;
            int h = pictureBoxColorBar.Size.Height;

            Bitmap image = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(image);
            g.InterpolationMode = InterpolationMode.High;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.DrawImage(colorBar.ToBitmap(null,null,(ZMappingData.ColorMode)comboBoxColorMode.SelectedIndex),
                0, 0, w, h);

            pictureBoxColorBar.Image = image;

            if (zMap != null)
            {
                DrawZMap();
                DrawLineOnZMap();
            }
        }


        internal void LoadConfig()
        {
            textBoxUserMax.Text = Core.Config.MaximumValue;
            textBoxUserMin.Text = Core.Config.MinimumValue;

            
        }

        internal void SetConfig()
        {
            Core.Config.MaximumValue = textBoxUserMax.Text;
            Core.Config.MinimumValue = textBoxUserMin.Text;
        }

        private void comboBoxConvertMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (zMap != null)
            {
                DrawZMap();
                DrawLineOnZMap();
            }
        }
    }
}
