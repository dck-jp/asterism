namespace Asterism
{
    partial class FormEasyFiler
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEasyFiler));
            this.comboBoxFilePattern = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.エクスプローラで開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonApplyFileMask = new System.Windows.Forms.Button();
            this.textBoxSelectedFolder = new System.Windows.Forms.TextBox();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.listViewFolders = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelFolderSelect = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFileMask = new System.Windows.Forms.Panel();
            this.numericUpDownZColNum = new System.Windows.Forms.NumericUpDown();
            this.radioButtonXYZ = new System.Windows.Forms.RadioButton();
            this.radioButtonZMap = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenuStripRightClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelFolderSelect.SuspendLayout();
            this.panelFileMask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZColNum)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFilePattern
            // 
            this.comboBoxFilePattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFilePattern.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxFilePattern.FormattingEnabled = true;
            this.comboBoxFilePattern.Location = new System.Drawing.Point(80, 7);
            this.comboBoxFilePattern.Name = "comboBoxFilePattern";
            this.comboBoxFilePattern.Size = new System.Drawing.Size(99, 21);
            this.comboBoxFilePattern.TabIndex = 17;
            this.comboBoxFilePattern.Text = "*.txt";
            this.comboBoxFilePattern.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxFilePattern_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "ファイルマスク：";
            // 
            // listViewFiles
            // 
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewFiles.ContextMenuStrip = this.contextMenuStripRightClick;
            this.listViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFiles.FullRowSelect = true;
            this.listViewFiles.GridLines = true;
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.Location = new System.Drawing.Point(0, 76);
            this.listViewFiles.MultiSelect = false;
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(231, 385);
            this.listViewFiles.TabIndex = 18;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            this.listViewFiles.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewFiles_ItemDrag);
            this.listViewFiles.SelectedIndexChanged += new System.EventHandler(this.listViewFiles_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ファイル名";
            this.columnHeader1.Width = 205;
            // 
            // contextMenuStripRightClick
            // 
            this.contextMenuStripRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.エクスプローラで開くToolStripMenuItem});
            this.contextMenuStripRightClick.Name = "contextMenuStripRightClick";
            this.contextMenuStripRightClick.Size = new System.Drawing.Size(165, 26);
            // 
            // エクスプローラで開くToolStripMenuItem
            // 
            this.エクスプローラで開くToolStripMenuItem.Name = "エクスプローラで開くToolStripMenuItem";
            this.エクスプローラで開くToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.エクスプローラで開くToolStripMenuItem.Text = "エクスプローラで開く";
            this.エクスプローラで開くToolStripMenuItem.Click += new System.EventHandler(this.エクスプローラで開くToolStripMenuItem_Click);
            // 
            // buttonApplyFileMask
            // 
            this.buttonApplyFileMask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApplyFileMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApplyFileMask.Location = new System.Drawing.Point(185, 5);
            this.buttonApplyFileMask.Name = "buttonApplyFileMask";
            this.buttonApplyFileMask.Size = new System.Drawing.Size(43, 23);
            this.buttonApplyFileMask.TabIndex = 21;
            this.buttonApplyFileMask.Text = "適用";
            this.buttonApplyFileMask.UseVisualStyleBackColor = true;
            this.buttonApplyFileMask.Click += new System.EventHandler(this.buttonApplyFileMask_Click);
            // 
            // textBoxSelectedFolder
            // 
            this.textBoxSelectedFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSelectedFolder.Location = new System.Drawing.Point(55, 5);
            this.textBoxSelectedFolder.Name = "textBoxSelectedFolder";
            this.textBoxSelectedFolder.ReadOnly = true;
            this.textBoxSelectedFolder.Size = new System.Drawing.Size(125, 19);
            this.textBoxSelectedFolder.TabIndex = 20;
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectFolder.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelectFolder.Image")));
            this.buttonSelectFolder.Location = new System.Drawing.Point(185, 3);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(43, 23);
            this.buttonSelectFolder.TabIndex = 15;
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // listViewFolders
            // 
            this.listViewFolders.AutoArrange = false;
            this.listViewFolders.BackColor = System.Drawing.Color.Black;
            this.listViewFolders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewFolders.ContextMenuStrip = this.contextMenuStripRightClick;
            this.listViewFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFolders.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listViewFolders.ForeColor = System.Drawing.Color.White;
            this.listViewFolders.FullRowSelect = true;
            this.listViewFolders.GridLines = true;
            this.listViewFolders.Location = new System.Drawing.Point(0, 29);
            this.listViewFolders.MultiSelect = false;
            this.listViewFolders.Name = "listViewFolders";
            this.listViewFolders.Size = new System.Drawing.Size(231, 235);
            this.listViewFolders.TabIndex = 16;
            this.listViewFolders.UseCompatibleStateImageBehavior = false;
            this.listViewFolders.View = System.Windows.Forms.View.Details;
            this.listViewFolders.DoubleClick += new System.EventHandler(this.listViewFolders_DoubleClick);
            this.listViewFolders.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewFolders_KeyUp);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "フォルダ名";
            this.columnHeader2.Width = 203;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.listViewFolders);
            this.splitContainer.Panel1.Controls.Add(this.panelFolderSelect);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.listViewFiles);
            this.splitContainer.Panel2.Controls.Add(this.panelFileMask);
            this.splitContainer.Size = new System.Drawing.Size(231, 729);
            this.splitContainer.SplitterDistance = 264;
            this.splitContainer.TabIndex = 22;
            // 
            // panelFolderSelect
            // 
            this.panelFolderSelect.Controls.Add(this.label2);
            this.panelFolderSelect.Controls.Add(this.textBoxSelectedFolder);
            this.panelFolderSelect.Controls.Add(this.buttonSelectFolder);
            this.panelFolderSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFolderSelect.Location = new System.Drawing.Point(0, 0);
            this.panelFolderSelect.Name = "panelFolderSelect";
            this.panelFolderSelect.Size = new System.Drawing.Size(231, 29);
            this.panelFolderSelect.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "フォルダ：";
            // 
            // panelFileMask
            // 
            this.panelFileMask.Controls.Add(this.numericUpDownZColNum);
            this.panelFileMask.Controls.Add(this.radioButtonXYZ);
            this.panelFileMask.Controls.Add(this.radioButtonZMap);
            this.panelFileMask.Controls.Add(this.label5);
            this.panelFileMask.Controls.Add(this.label4);
            this.panelFileMask.Controls.Add(this.label3);
            this.panelFileMask.Controls.Add(this.label1);
            this.panelFileMask.Controls.Add(this.comboBoxFilePattern);
            this.panelFileMask.Controls.Add(this.buttonApplyFileMask);
            this.panelFileMask.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFileMask.Location = new System.Drawing.Point(0, 0);
            this.panelFileMask.Name = "panelFileMask";
            this.panelFileMask.Size = new System.Drawing.Size(231, 76);
            this.panelFileMask.TabIndex = 17;
            // 
            // numericUpDownZColNum
            // 
            this.numericUpDownZColNum.Enabled = false;
            this.numericUpDownZColNum.Location = new System.Drawing.Point(148, 54);
            this.numericUpDownZColNum.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownZColNum.Name = "numericUpDownZColNum";
            this.numericUpDownZColNum.Size = new System.Drawing.Size(45, 19);
            this.numericUpDownZColNum.TabIndex = 23;
            this.numericUpDownZColNum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownZColNum.ValueChanged += new System.EventHandler(this.numericUpDownZColNum_ValueChanged);
            // 
            // radioButtonXYZ
            // 
            this.radioButtonXYZ.AutoSize = true;
            this.radioButtonXYZ.Location = new System.Drawing.Point(135, 34);
            this.radioButtonXYZ.Name = "radioButtonXYZ";
            this.radioButtonXYZ.Size = new System.Drawing.Size(44, 16);
            this.radioButtonXYZ.TabIndex = 22;
            this.radioButtonXYZ.Text = "XYZ";
            this.radioButtonXYZ.UseVisualStyleBackColor = true;
            this.radioButtonXYZ.CheckedChanged += new System.EventHandler(this.radioButtonZMap_CheckedChanged);
            // 
            // radioButtonZMap
            // 
            this.radioButtonZMap.AutoSize = true;
            this.radioButtonZMap.Checked = true;
            this.radioButtonZMap.Location = new System.Drawing.Point(80, 34);
            this.radioButtonZMap.Name = "radioButtonZMap";
            this.radioButtonZMap.Size = new System.Drawing.Size(51, 16);
            this.radioButtonZMap.TabIndex = 22;
            this.radioButtonZMap.TabStop = true;
            this.radioButtonZMap.Text = "ZMap";
            this.radioButtonZMap.UseVisualStyleBackColor = true;
            this.radioButtonZMap.CheckedChanged += new System.EventHandler(this.radioButtonZMap_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "列目";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "Zの値：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "データ形式：";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "フォルダの変更";
            // 
            // FormEasyFiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 729);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.splitContainer);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)));
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HideOnClose = true;
            this.Name = "FormEasyFiler";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockRight;
            this.Text = "ファイルセレクター";
            this.Resize += new System.EventHandler(this.FormEasyFiler_Resize);
            this.contextMenuStripRightClick.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelFolderSelect.ResumeLayout(false);
            this.panelFolderSelect.PerformLayout();
            this.panelFileMask.ResumeLayout(false);
            this.panelFileMask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZColNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFilePattern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buttonApplyFileMask;
        private System.Windows.Forms.TextBox textBoxSelectedFolder;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.ListView listViewFolders;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelFolderSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelFileMask;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRightClick;
        private System.Windows.Forms.ToolStripMenuItem エクスプローラで開くToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDownZColNum;
        private System.Windows.Forms.RadioButton radioButtonXYZ;
        private System.Windows.Forms.RadioButton radioButtonZMap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}