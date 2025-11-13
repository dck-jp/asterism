using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CodeD;
using System.IO;
using WeifenLuo.WinFormsUI.Docking;

namespace Asterism
{
    /// <summary>
    /// Name : Asterism
    /// Created by: Daisuke YAMAKAWA
    /// </summary>
    public partial class FormMain : Form
    {
        #region ロード中のファイルに関する情報
        internal HeatmapRenderer CurrentZMapData
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
        HeatmapRenderer currentZMapData;
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
            var vS2005Theme1 = new VS2015LightTheme();
            this.dockPanel.Theme = vS2005Theme1;

            Core.Config = Config.Load();
            string startPath;

            #region configデータセット
            if (Core.Config.InitialDirectory != "" && Directory.Exists(Core.Config.InitialDirectory))
            {
                startPath = Core.Config.InitialDirectory;
            }
            else
            {
                startPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }


            ToggleToolStripButtonText();

            #endregion

            // 各種ウィンドウの生成
            view = new FormDataView(this);
            view.Show(dockPanel);

            image = new FormImage(this);
            image.Show(dockPanel);

            raw = new FormRawDataView(this);
            raw.Show(dockPanel);

            view.Activate();

            //ファイラーウィンドウの生成
            ezfiler = new FormEasyFiler(view);
            ezfiler.Show(dockPanel, DockState.DockRight);
            ezfiler.SetCurrentDisplayDirectory(startPath);
            Core.EzFiler = ezfiler;

            ezfiler.Activate();

            ezfiler.LoadConfig();
            view.LoadConfig();

            // 非同期処理はLoadイベントで実行
            this.Load += FormMain_LoadAsync;
        }

        private async void FormMain_LoadAsync(object sender, EventArgs e)
        {
            //「送る」で送られてきた場合に対象ファイルを開く処理
            string[] files = Environment.GetCommandLineArgs();
            if (files.Length != 1 && File.Exists(files[1]))
            {
                string filename = files[1];
                ezfiler.SetCurrentDisplayDirectory(Path.GetDirectoryName(filename));

                try
                {
                    await view.SetCurrentFileAsync(filename);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ファイルの読み込みに失敗しました:\n{ex.Message}",
                                   "エラー",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// フォーム表示時にレイアウトを強制更新
        /// ※なぜか最初の表示時にファイラーが表示されない問題への対策 (bad code)
        /// </summary>
        private void FormMain_Shown(object sender, EventArgs e)
        {
            // 強制的にレイアウトを再計算させるためにウィンドウサイズを微調整
            this.Width += 1;
            this.Refresh();
            this.Width -= 1;
        }

        private void ToggleToolStripButtonText()
        {
            var buttons = new List<ToolStripButton>(){
                toolStripButtonConfig,
                toolStripButtonReload,
                toolStripButtonRotate,
                toolStripButtonSaveAsPNG,
                toolStripButtonRotateCW,
                toolStripButtonSaveAs,
                toolStripButtonVerInfo,
                toolStripButtonRotateCCW
            };

            if (!Core.Config.ShowStrings)
            {
                buttons.ForEach(b => b.DisplayStyle = ToolStripItemDisplayStyle.Image);
            }
            else
            {
                buttons.ForEach(b => b.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText);
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
        private async void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            ezfiler.SetCurrentDisplayDirectory(Path.GetDirectoryName(files[0]));
            await view.SetCurrentFileAsync(files[0]);
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
            ToggleToolStripButtonText();
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

            Core.Config.Save();
        }

        #endregion

        internal void SetTitle(string path)
        {
            this.Text = Path.GetFileName(path) + " - "+ Core.VerInfo;
            
        }
    }
}
