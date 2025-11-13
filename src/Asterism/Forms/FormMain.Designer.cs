namespace Asterism
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            statusStrip = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStrip = new System.Windows.Forms.ToolStrip();
            toolStripButtonRotateCCW = new System.Windows.Forms.ToolStripButton();
            toolStripButtonRotateCW = new System.Windows.Forms.ToolStripButton();
            toolStripButtonRotate = new System.Windows.Forms.ToolStripButton();
            toolStripButtonSaveAs = new System.Windows.Forms.ToolStripButton();
            toolStripButtonSaveAsPNG = new System.Windows.Forms.ToolStripButton();
            toolStripButtonReload = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripButtonConfig = new System.Windows.Forms.ToolStripButton();
            toolStripButtonVerInfo = new System.Windows.Forms.ToolStripButton();
            dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            statusStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel, toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip.Location = new System.Drawing.Point(0, 756);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip.Size = new System.Drawing.Size(1139, 22);
            statusStrip.SizingGrip = false;
            statusStrip.TabIndex = 15;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new System.Drawing.Size(1097, 17);
            toolStripStatusLabel.Spring = true;
            toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            toolStripStatusLabel1.Visible = false;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            toolStripStatusLabel2.Visible = false;
            // 
            // toolStrip
            // 
            toolStrip.AutoSize = false;
            toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButtonRotateCCW, toolStripButtonRotateCW, toolStripButtonRotate, toolStripButtonSaveAs, toolStripButtonSaveAsPNG, toolStripButtonReload, toolStripSeparator1, toolStripButtonConfig, toolStripButtonVerInfo });
            toolStrip.Location = new System.Drawing.Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new System.Drawing.Size(1139, 49);
            toolStrip.TabIndex = 19;
            toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonRotateCCW
            // 
            toolStripButtonRotateCCW.Enabled = false;
            toolStripButtonRotateCCW.Image = (System.Drawing.Image)resources.GetObject("toolStripButtonRotateCCW.Image");
            toolStripButtonRotateCCW.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonRotateCCW.Name = "toolStripButtonRotateCCW";
            toolStripButtonRotateCCW.Size = new System.Drawing.Size(64, 46);
            toolStripButtonRotateCCW.Text = "左90°回転";
            toolStripButtonRotateCCW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolStripButtonRotateCCW.Visible = false;
            toolStripButtonRotateCCW.Click += toolStripButtonRotateCCW_Click;
            // 
            // toolStripButtonRotateCW
            // 
            toolStripButtonRotateCW.Enabled = false;
            toolStripButtonRotateCW.Image = (System.Drawing.Image)resources.GetObject("toolStripButtonRotateCW.Image");
            toolStripButtonRotateCW.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonRotateCW.Name = "toolStripButtonRotateCW";
            toolStripButtonRotateCW.Size = new System.Drawing.Size(64, 46);
            toolStripButtonRotateCW.Text = "右90°回転";
            toolStripButtonRotateCW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolStripButtonRotateCW.Visible = false;
            toolStripButtonRotateCW.Click += toolStripButtonRotateCW_Click;
            // 
            // toolStripButtonRotate
            // 
            toolStripButtonRotate.Enabled = false;
            toolStripButtonRotate.Image = (System.Drawing.Image)resources.GetObject("toolStripButtonRotate.Image");
            toolStripButtonRotate.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonRotate.Name = "toolStripButtonRotate";
            toolStripButtonRotate.Size = new System.Drawing.Size(71, 46);
            toolStripButtonRotate.Text = "任意角回転";
            toolStripButtonRotate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolStripButtonRotate.Visible = false;
            toolStripButtonRotate.Click += toolStripButtonRotate_Click;
            // 
            // toolStripButtonSaveAs
            // 
            toolStripButtonSaveAs.Enabled = false;
            toolStripButtonSaveAs.Image = (System.Drawing.Image)resources.GetObject("toolStripButtonSaveAs.Image");
            toolStripButtonSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonSaveAs.Name = "toolStripButtonSaveAs";
            toolStripButtonSaveAs.Size = new System.Drawing.Size(95, 46);
            toolStripButtonSaveAs.Text = "名前をつけて保存";
            toolStripButtonSaveAs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolStripButtonSaveAs.ToolTipText = "回転状態で名前をつけて保存";
            toolStripButtonSaveAs.Visible = false;
            toolStripButtonSaveAs.Click += toolStripButtonSaveAs_Click;
            // 
            // toolStripButtonSaveAsPNG
            // 
            toolStripButtonSaveAsPNG.Image = (System.Drawing.Image)resources.GetObject("toolStripButtonSaveAsPNG.Image");
            toolStripButtonSaveAsPNG.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonSaveAsPNG.Name = "toolStripButtonSaveAsPNG";
            toolStripButtonSaveAsPNG.Size = new System.Drawing.Size(85, 46);
            toolStripButtonSaveAsPNG.Text = "画像として保存";
            toolStripButtonSaveAsPNG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolStripButtonSaveAsPNG.ToolTipText = "画像として保存";
            toolStripButtonSaveAsPNG.Visible = false;
            toolStripButtonSaveAsPNG.Click += toolStripButtonSaveAsPNG_Click;
            // 
            // toolStripButtonReload
            // 
            toolStripButtonReload.Image = (System.Drawing.Image)resources.GetObject("toolStripButtonReload.Image");
            toolStripButtonReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonReload.Name = "toolStripButtonReload";
            toolStripButtonReload.Size = new System.Drawing.Size(69, 46);
            toolStripButtonReload.Text = "再読み込み";
            toolStripButtonReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolStripButtonReload.Visible = false;
            toolStripButtonReload.Click += toolStripButtonReload_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 49);
            // 
            // toolStripButtonConfig
            // 
            toolStripButtonConfig.Image = (System.Drawing.Image)resources.GetObject("toolStripButtonConfig.Image");
            toolStripButtonConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonConfig.Name = "toolStripButtonConfig";
            toolStripButtonConfig.Size = new System.Drawing.Size(35, 46);
            toolStripButtonConfig.Text = "設定";
            toolStripButtonConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolStripButtonConfig.Click += toolStripButtonConfig_Click;
            // 
            // toolStripButtonVerInfo
            // 
            toolStripButtonVerInfo.Image = (System.Drawing.Image)resources.GetObject("toolStripButtonVerInfo.Image");
            toolStripButtonVerInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonVerInfo.Name = "toolStripButtonVerInfo";
            toolStripButtonVerInfo.Size = new System.Drawing.Size(53, 46);
            toolStripButtonVerInfo.Text = "Ver.情報";
            toolStripButtonVerInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolStripButtonVerInfo.Click += toolStripButtonVerInfo_Click;
            // 
            // dockPanel
            // 
            dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            dockPanel.DockBackColor = System.Drawing.SystemColors.Control;
            dockPanel.Location = new System.Drawing.Point(0, 49);
            dockPanel.Margin = new System.Windows.Forms.Padding(4);
            dockPanel.Name = "dockPanel";
            dockPanel.Size = new System.Drawing.Size(1139, 707);
            dockPanel.TabIndex = 24;
            // 
            // FormMain
            // 
            AllowDrop = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1139, 778);
            Controls.Add(dockPanel);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(1864, 990);
            MinimumSize = new System.Drawing.Size(907, 740);
            Name = "FormMain";
            Text = "loading...";
            FormClosed += FormMain_FormClosed;
            Shown += FormMain_Shown;
            DragDrop += FormMain_DragDrop;
            DragEnter += FormMain_DragEnter;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonRotateCW;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonReload;
        private System.Windows.Forms.ToolStripButton toolStripButtonConfig;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveAs;
        private System.Windows.Forms.ToolStripButton toolStripButtonVerInfo;
        private System.Windows.Forms.ToolStripButton toolStripButtonRotate;
        private System.Windows.Forms.ToolStripButton toolStripButtonRotateCCW;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveAsPNG;
    }
}

