using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CodeD.Data;
using ZedGraph;
using System.Drawing.Drawing2D;
using System.IO;
using System.Diagnostics;

namespace Asterism
{
    /// <summary>
    /// Name : Asterism
    /// Created by: Daisuke YAMAKAWA
    /// </summary>
    public partial class FormMain : Form
    {
        public const string verInfo = @"asterism v1.7.3 β";

        #region ロード中のファイルに関する情報
        internal ZMappingData CurrentZMapData
        {
            get
            {
                return currentZMapData;
            }
            set
            {
                currentZMapData = value;

                //子ウィンドウの更新
                image.SetImage();
                raw.SetRawData();
                
            }
        }
        ZMappingData currentZMapData;
        #endregion

        FormDataView view;
        FormEasyFiler ezfiler;
        FormImage image;
        FormRawDataView raw;

        /// <summary>
        /// コンストラクタ
        /// 　configファイルをロード
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

            Config.Load();
            string startPath;

            #region configデータセット
            if (Config.InitialDirectory != "" && Directory.Exists(Config.InitialDirectory))
            {
                startPath = Config.InitialDirectory;
            }
            else
            {
                startPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }

            Config.ShowStrings = true;
            if (!Config.ShowStrings)
            {
                toolStripButtonConfig.Text = "";
                toolStripButtonReload.Text = "";
                toolStripButtonRotate.Text = "";
                toolStripButtonRotateCW.Text = "";
                toolStripButtonSaveAs.Text = "";
                toolStripButtonVerInfo.Text = "";
                toolStripButtonRotateCCW.Text = "";
                toolStrip.Height = 25;
            }
            #endregion

            // 各種ウィンドウの生成
            view = new FormDataView(this);
            view.Show(dockPanel);

            ezfiler = new FormEasyFiler(view);
            ezfiler.Show(dockPanel);
            ezfiler.SetCurrentDisplayDirectory(startPath);

            image = new FormImage(this);
            image.Show(dockPanel);

            raw = new FormRawDataView(this);
            raw.Show(dockPanel);

            view.Activate(); 
            this.Text = verInfo;


            //
            ezfiler.LoadConfig();
            view.LoadConfig();

            //「送る」で送られてきた場合に対象ファイルを開く処理
            string[] files = Environment.GetCommandLineArgs();
            if (files.Length != 1 && File.Exists(files[1]))
            {
                string filename = files[1];
                ezfiler.SetCurrentDisplayDirectory(Path.GetDirectoryName(filename));
                view.SetCurrentFile(filename);
            }
            else // Configを読み込む
            {
                ezfiler.SetCurrentDisplayDirectory(startPath);
            }

            
            
        }


        #region D&Dイベント
        /// <summary>
        /// DragしたカーソルがForm内に
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] drags = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string d in drags)
                {
                    if (!System.IO.File.Exists(d)) return;
                }
                e.Effect = DragDropEffects.Copy;
            }
        }

        /// <summary>
        /// D&Dされた場合
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            ezfiler.SetCurrentDisplayDirectory(Path.GetDirectoryName(files[0]));
            view.SetCurrentFile(files[0]);
        }
        #endregion

        #region ツールバーイベント(簡易編集)
        /// <summary>
        /// 再読み込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonReload_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 左回りに回転
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonRotateCCW_Click(object sender, EventArgs e)
        {
            currentZMapData = currentZMapData.GetRotateCCW();
            //RedrawZmap();
            //SetParameter(Path.GetFileName(filename) + "*");
        }

        /// <summary>
        /// 右回りに回転
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonRotateCW_Click(object sender, EventArgs e)
        {
            currentZMapData = currentZMapData.GetRotateCW();
            //RedrawZmap(); 
            //SetParameter(Path.GetFileName(filename) + "*");
        }

        /// <summary>
        /// 任意角回転
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonRotate_Click(object sender, EventArgs e)
        {
            FormRotate rotate = new FormRotate();
            if (rotate.ShowDialog() == DialogResult.OK)
            {
                currentZMapData = currentZMapData.GetRotate(rotate.Angle);
                //RedrawZmap();
                //SetParameter(Path.GetFileName(filename) + "*");
            }
        }



        /// <summary>
        /// 名前をつけて保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "名前を付けて保存";
            dialog.SupportMultiDottedExtensions = true;
            dialog.RestoreDirectory = true;
            dialog.OverwritePrompt = true;
            dialog.AutoUpgradeEnabled = true;
            dialog.Filter = "ZMapファイル(*.*)|*";
            dialog.InitialDirectory = Directory.GetCurrentDirectory();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentZMapData.SaveAs(dialog.FileName);
            }
        }

        /// <summary>
        /// PNGファイルとして保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonSaveAsPNG_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "画像として保存";
            dialog.SupportMultiDottedExtensions = true;
            dialog.RestoreDirectory = true;
            dialog.OverwritePrompt = true;
            dialog.AutoUpgradeEnabled = true;
            dialog.Filter = "PNGファイル(*.png)|*.png";
            dialog.InitialDirectory = Directory.GetCurrentDirectory();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                view.GetCurrentImage().Save(dialog.FileName);
            }
        }


        /// <summary>
        /// 設定画面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonConfig_Click(object sender, EventArgs e)
        {
            FormUserConfig config = new FormUserConfig();
            config.ShowDialog();
        }

        private void toolStripButtonVerInfo_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();

        }
        #endregion

        #region その他GUIイベント

        /// <summary>
        /// 終了時、設定保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            ezfiler.SaveMaskList();
            ezfiler.SetConfig();
            view.SetConfig();

            Config.Save();
        }

        #endregion

        internal void SetTitle(string path)
        {
            this.Text = Path.GetFileName(path) + " - "+ verInfo;
            
        }

    }
}
