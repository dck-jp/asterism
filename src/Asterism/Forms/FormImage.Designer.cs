namespace Asterism
{
    partial class FormImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImage));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxConvertMode = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxWidth = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxHeight = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonRedraw = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCopyToClipboard = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.pictureBoxZMap = new System.Windows.Forms.PictureBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxColorMode = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxDrawMode = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxInterpolationMethod = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxMin = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxMax = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonMultiSave = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZMap)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel6,
            this.toolStripComboBoxConvertMode,
            this.toolStripLabel1,
            this.toolStripTextBoxWidth,
            this.toolStripLabel4,
            this.toolStripTextBoxHeight,
            this.toolStripButtonRedraw,
            this.toolStripSeparator1,
            this.toolStripButtonCopyToClipboard,
            this.toolStripSeparator2,
            this.toolStripButtonSave,
            this.toolStripButtonMultiSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(846, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(60, 23);
            this.toolStripLabel6.Text = "表示形式:";
            // 
            // toolStripComboBoxConvertMode
            // 
            this.toolStripComboBoxConvertMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxConvertMode.Name = "toolStripComboBoxConvertMode";
            this.toolStripComboBoxConvertMode.Size = new System.Drawing.Size(126, 26);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 23);
            this.toolStripLabel1.Text = "Width:";
            // 
            // toolStripTextBoxWidth
            // 
            this.toolStripTextBoxWidth.Enabled = false;
            this.toolStripTextBoxWidth.Name = "toolStripTextBoxWidth";
            this.toolStripTextBoxWidth.Size = new System.Drawing.Size(50, 26);
            this.toolStripTextBoxWidth.Text = "300";
            this.toolStripTextBoxWidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxWidth_KeyUp);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(50, 23);
            this.toolStripLabel4.Text = "Height:";
            // 
            // toolStripTextBoxHeight
            // 
            this.toolStripTextBoxHeight.Enabled = false;
            this.toolStripTextBoxHeight.Name = "toolStripTextBoxHeight";
            this.toolStripTextBoxHeight.Size = new System.Drawing.Size(50, 26);
            this.toolStripTextBoxHeight.Text = "300";
            this.toolStripTextBoxHeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxHeight_KeyUp);
            // 
            // toolStripButtonRedraw
            // 
            this.toolStripButtonRedraw.AutoSize = false;
            this.toolStripButtonRedraw.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRedraw.Image")));
            this.toolStripButtonRedraw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRedraw.Name = "toolStripButtonRedraw";
            this.toolStripButtonRedraw.Size = new System.Drawing.Size(100, 22);
            this.toolStripButtonRedraw.Text = "描画";
            this.toolStripButtonRedraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonRedraw.Click += new System.EventHandler(this.toolStripButtonRedraw_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripButtonCopyToClipboard
            // 
            this.toolStripButtonCopyToClipboard.AutoSize = false;
            this.toolStripButtonCopyToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopyToClipboard.Image")));
            this.toolStripButtonCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopyToClipboard.Name = "toolStripButtonCopyToClipboard";
            this.toolStripButtonCopyToClipboard.Size = new System.Drawing.Size(100, 23);
            this.toolStripButtonCopyToClipboard.Text = "コピー";
            this.toolStripButtonCopyToClipboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonCopyToClipboard.Click += new System.EventHandler(this.toolStripButtonCopyToClipboard_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.AutoSize = false;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(100, 23);
            this.toolStripButtonSave.Text = "保存";
            this.toolStripButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // pictureBoxZMap
            // 
            this.pictureBoxZMap.BackColor = System.Drawing.Color.White;
            this.pictureBoxZMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxZMap.Location = new System.Drawing.Point(0, 51);
            this.pictureBoxZMap.Name = "pictureBoxZMap";
            this.pictureBoxZMap.Size = new System.Drawing.Size(846, 620);
            this.pictureBoxZMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxZMap.TabIndex = 1;
            this.pictureBoxZMap.TabStop = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripComboBoxColorMode,
            this.toolStripLabel2,
            this.toolStripComboBoxDrawMode,
            this.toolStripLabel5,
            this.toolStripComboBoxInterpolationMethod});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(846, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel3.Text = "配色:";
            // 
            // toolStripComboBoxColorMode
            // 
            this.toolStripComboBoxColorMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxColorMode.Name = "toolStripComboBoxColorMode";
            this.toolStripComboBoxColorMode.Size = new System.Drawing.Size(150, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel2.Text = "サイズ設定:";
            // 
            // toolStripComboBoxDrawMode
            // 
            this.toolStripComboBoxDrawMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxDrawMode.Name = "toolStripComboBoxDrawMode";
            this.toolStripComboBoxDrawMode.Size = new System.Drawing.Size(150, 25);
            this.toolStripComboBoxDrawMode.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxDrawMode_SelectedIndexChanged);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel5.Text = "補間法:";
            // 
            // toolStripComboBoxInterpolationMethod
            // 
            this.toolStripComboBoxInterpolationMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxInterpolationMethod.Name = "toolStripComboBoxInterpolationMethod";
            this.toolStripComboBoxInterpolationMethod.Size = new System.Drawing.Size(150, 25);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel8,
            this.toolStripTextBoxMin,
            this.toolStripLabel7,
            this.toolStripTextBoxMax,
            this.toolStripLabel9});
            this.toolStrip3.Location = new System.Drawing.Point(0, 51);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(846, 25);
            this.toolStrip3.TabIndex = 3;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel8.Text = "最小値:";
            // 
            // toolStripTextBoxMin
            // 
            this.toolStripTextBoxMin.Name = "toolStripTextBoxMin";
            this.toolStripTextBoxMin.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel7.Text = "　最大値:";
            // 
            // toolStripTextBoxMax
            // 
            this.toolStripTextBoxMax.Name = "toolStripTextBoxMax";
            this.toolStripTextBoxMax.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(263, 22);
            this.toolStripLabel9.Text = "(Box内を空白にすると、最大値・最小値を自動決定)";
            // 
            // toolStripButtonMultiSave
            // 
            this.toolStripButtonMultiSave.AutoSize = false;
            this.toolStripButtonMultiSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMultiSave.Image")));
            this.toolStripButtonMultiSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMultiSave.Name = "toolStripButtonMultiSave";
            this.toolStripButtonMultiSave.Size = new System.Drawing.Size(100, 23);
            this.toolStripButtonMultiSave.Text = "一括して複数の画像を生成";
            this.toolStripButtonMultiSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonMultiSave.Click += new System.EventHandler(this.toolStripButtonMultiSave_Click);
            // 
            // FormImage
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 671);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.pictureBoxZMap);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormImage";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
            this.ShowInTaskbar = false;
            this.Text = "画像の生成";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZMap)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxWidth;
        private System.Windows.Forms.ToolStripButton toolStripButtonRedraw;
        private System.Windows.Forms.PictureBox pictureBoxZMap;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxColorMode;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxDrawMode;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxHeight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopyToClipboard;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxInterpolationMethod;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxConvertMode;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxMax;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxMin;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonMultiSave;
    }
}