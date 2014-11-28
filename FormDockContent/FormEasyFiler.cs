using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;

namespace Asterism
{
    public partial class FormEasyFiler : DockContent
    {
        FormDataView view; //データ表示部
        string currentFolder; //現在表示中のフォルダパス
        FilePatternList maskList ;

        public System.Windows.Forms.ListView.ListViewItemCollection FileList { get { return listViewFiles.Items; } }

        public FormEasyFiler(FormDataView view)
        {
            InitializeComponent();
            this.view = view;
        }

        /// <summary>
        /// ウィンドウサイズ変更時、listviewの列幅変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEasyFiler_Resize(object sender, EventArgs e)
        {
            listViewFolders.Columns[0].Width = listViewFolders.Width - 25;
            listViewFiles.Columns[0].Width = listViewFiles.Width - 25;
        }

        /// <summary>
        /// 表示するフォルダを設定する
        /// - 表示の更新
        /// </summary>
        /// <param name="p"></param>
        internal void SetCurrentDisplayDirectory(string path)
        {
            currentFolder = path;

            //folderBrowserDialogのプロパティ変更
            folderBrowserDialog.SelectedPath = currentFolder;

            //表示フォルダ名
            //if (path.Substring(path.Length - 2) == "..")
            //{
            //    path = path.Remove(path.LastIndexOf('\\'));
            //    path = path.Remove(path.LastIndexOf('\\'));
            //}
            textBoxSelectedFolder.Text = currentFolder;
            textBoxSelectedFolder.SelectionStart = textBoxSelectedFolder.Text.Length;

            ReloadFolderList();
            ReloadFileList();
        }

        /// <summary>
        /// listviewFoldersのフォルダ一覧を更新
        /// </summary>
        private void ReloadFolderList()
        {
            List<string> folders = new List<string>(Directory.GetDirectories(currentFolder));

            listViewFolders.Items.Clear();
            //親フォルダの追加
            if (!IsRootDirectory(currentFolder))
            {
                ListViewItem item = new ListViewItem("..");
                item.SubItems.Add(Directory.GetParent(currentFolder).FullName);
                listViewFolders.Items.Add(item);
            }
            //フォルダ追加
            List<ListViewItem> items = new List<ListViewItem>();
            folders.ForEach(folderName =>
                {
                    ListViewItem item = new ListViewItem(Path.GetFileName(folderName));
                    item.SubItems.Add(folderName);

                    items.Add(item);
                });
            listViewFolders.Items.AddRange(items.ToArray());

            //表示幅の更新
            listViewFolders.Columns[0].Width = listViewFolders.Width - 25;
        }

        /// <summary>
        /// listviewFilesのファイル一覧を更新
        /// - textboxFilePattern.Text読み込み
        /// + ファイルが存在すれば自動選択
        /// </summary>
        private void ReloadFileList()
        {
            string pattern = (comboBoxFilePattern.Text == "") ? "*" : comboBoxFilePattern.Text;
            List<string> files = new List<string>(Directory.GetFiles(currentFolder, pattern));

            listViewFiles.Items.Clear();
            //ファイルの追加
            List<ListViewItem> items = new List<ListViewItem>();
            files.ForEach(filename =>
            {
                ListViewItem item = new ListViewItem(Path.GetFileName(filename));
                item.SubItems.Add(filename);

                items.Add(item);
            });
            listViewFiles.Items.AddRange(items.ToArray());

            //ファイルが存在する場合、先頭のファイルを選択
            if (listViewFiles.Items.Count != 0)
            {
                listViewFiles.Items[0].Selected = true;
            }

            //表示幅の更新
            listViewFiles.Columns[0].Width = listViewFiles.Width - 25;
        }

        /// <summary>
        /// pathがルートディレクトリか否かの判定
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private bool IsRootDirectory(string path)
        {
            return path.Substring(path.Length - 1) == @"\";
        }

        /// <summary>
        /// フォルダの選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog.SelectedPath;
                SetCurrentDisplayDirectory(path);
            }
        }

        /// <summary>
        /// ファイルマスク指定(表示ファイルがあれば自動選択)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonApplyFileMask_Click(object sender, EventArgs e)
        {
            //設定ファイルの更新
            RefreshFilePattern(comboBoxFilePattern.Text);
            ReloadFileList();
        }

        /// <summary>
        /// 一覧からフォルダ選択時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewFolders_DoubleClick(object sender, EventArgs e)
        {
            if (listViewFolders.SelectedItems.Count == 0) return;
            SetCurrentDisplayDirectory(listViewFolders.SelectedItems[0].SubItems[1].Text);
        }

        /// <summary>
        /// フォルダ選択部分のキーボード操作(表示ファイルがあれば自動選択)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewFolders_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //フォルダ選択
            {
                if (listViewFolders.SelectedItems.Count == 0) return;
                SetCurrentDisplayDirectory(listViewFolders.SelectedItems[0].SubItems[1].Text);
            }
            else if (e.KeyCode == Keys.Back) //１つ上に移動
            {
                if (!IsRootDirectory(currentFolder))
                {
                    SetCurrentDisplayDirectory(currentFolder + @"\..");
                }
            }
        }
        
        /// <summary>
        /// ファイルリスト選択時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFiles.SelectedItems.Count == 0) return;
            view.SetCurrentFile(listViewFiles.SelectedItems[0].SubItems[1].Text);
        }

        /// <summary>
        /// ファイルマスク入力時、Enter押下で更新(表示ファイルがあれば自動選択)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxFilePattern_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonApplyFileMask.PerformClick();
                
            }
        }

        private void listViewFiles_ItemDrag(object sender, ItemDragEventArgs e)
        {
            string[] filename = new string[1] { listViewFiles.SelectedItems[0].SubItems[1].Text };
            DataObject data = new DataObject(DataFormats.FileDrop, filename);
            listViewFiles.DoDragDrop(data, DragDropEffects.Copy);
        }

        /// <summary>
        /// Comboboxを更新
        /// </summary>
        /// <param name="p"></param>
        private void RefreshFilePattern(string p)
        {
            maskList.Add(comboBoxFilePattern.Text);
            comboBoxFilePattern.Items.Clear();
            comboBoxFilePattern.Items.AddRange(maskList.ToArray());
        }

        internal void LoadConfig()
        {
            maskList = new FilePatternList(Core.Config.FileMaskNumber);
            maskList.LoadListFile();
            comboBoxFilePattern.Items.AddRange(maskList.ToArray());
        }


        internal void SetConfig()
        {
            if (Core.Config.ExitWithSavingDirectoryInfo) Core.Config.InitialDirectory = currentFolder;
        }

        internal void SaveMaskList()
        {
            maskList.SaveListFile();
        }

        private void エクスプローラで開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(currentFolder);
        }
    }
}
