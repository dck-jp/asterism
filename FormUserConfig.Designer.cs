namespace Asterism
{
    partial class FormUserConfig
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
            this.buttonSelectInitialDirectory = new System.Windows.Forms.Button();
            this.textBoxInitialDirectory = new System.Windows.Forms.TextBox();
            this.numericUpDownFileMaskNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxEnablesOutOfRangeColor = new System.Windows.Forms.CheckBox();
            this.pictureBoxOutOfRangeColor = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonUserDefine = new System.Windows.Forms.RadioButton();
            this.radioButtonAutoSave = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownAlarmFileSize = new System.Windows.Forms.NumericUpDown();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBoxShowStrings = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFileMaskNumber)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutOfRangeColor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlarmFileSize)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSelectInitialDirectory
            // 
            this.buttonSelectInitialDirectory.Location = new System.Drawing.Point(480, 37);
            this.buttonSelectInitialDirectory.Name = "buttonSelectInitialDirectory";
            this.buttonSelectInitialDirectory.Size = new System.Drawing.Size(29, 23);
            this.buttonSelectInitialDirectory.TabIndex = 1;
            this.buttonSelectInitialDirectory.Text = "...";
            this.buttonSelectInitialDirectory.UseVisualStyleBackColor = true;
            this.buttonSelectInitialDirectory.Click += new System.EventHandler(this.buttonSelectInitialDirectory_Click);
            // 
            // textBoxInitialDirectory
            // 
            this.textBoxInitialDirectory.Location = new System.Drawing.Point(141, 39);
            this.textBoxInitialDirectory.Name = "textBoxInitialDirectory";
            this.textBoxInitialDirectory.Size = new System.Drawing.Size(333, 19);
            this.textBoxInitialDirectory.TabIndex = 2;
            // 
            // numericUpDownFileMaskNumber
            // 
            this.numericUpDownFileMaskNumber.Location = new System.Drawing.Point(174, 81);
            this.numericUpDownFileMaskNumber.Name = "numericUpDownFileMaskNumber";
            this.numericUpDownFileMaskNumber.Size = new System.Drawing.Size(56, 19);
            this.numericUpDownFileMaskNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "ファイルマスク履歴保持数：";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(291, 320);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(116, 27);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 314);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.checkBoxShowStrings);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numericUpDownAlarmFileSize);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numericUpDownFileMaskNumber);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(531, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "全般";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.checkBoxEnablesOutOfRangeColor);
            this.groupBox2.Controls.Add(this.pictureBoxOutOfRangeColor);
            this.groupBox2.Location = new System.Drawing.Point(8, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 72);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "コンター図の配色";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "（クリックで色の変更可能）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "範囲外の場合に表示する色：";
            // 
            // checkBoxEnablesOutOfRangeColor
            // 
            this.checkBoxEnablesOutOfRangeColor.AutoSize = true;
            this.checkBoxEnablesOutOfRangeColor.Location = new System.Drawing.Point(6, 18);
            this.checkBoxEnablesOutOfRangeColor.Name = "checkBoxEnablesOutOfRangeColor";
            this.checkBoxEnablesOutOfRangeColor.Size = new System.Drawing.Size(277, 16);
            this.checkBoxEnablesOutOfRangeColor.TabIndex = 5;
            this.checkBoxEnablesOutOfRangeColor.Text = "範囲外の数値が含まれる箇所は以下の色を表示する";
            this.checkBoxEnablesOutOfRangeColor.UseVisualStyleBackColor = true;
            // 
            // pictureBoxOutOfRangeColor
            // 
            this.pictureBoxOutOfRangeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOutOfRangeColor.Location = new System.Drawing.Point(166, 40);
            this.pictureBoxOutOfRangeColor.Name = "pictureBoxOutOfRangeColor";
            this.pictureBoxOutOfRangeColor.Size = new System.Drawing.Size(32, 26);
            this.pictureBoxOutOfRangeColor.TabIndex = 7;
            this.pictureBoxOutOfRangeColor.TabStop = false;
            this.pictureBoxOutOfRangeColor.Click += new System.EventHandler(this.pictureBoxOutOfRangeColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonUserDefine);
            this.groupBox1.Controls.Add(this.radioButtonAutoSave);
            this.groupBox1.Controls.Add(this.buttonSelectInitialDirectory);
            this.groupBox1.Controls.Add(this.textBoxInitialDirectory);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "起動時の表示フォルダ";
            // 
            // radioButtonUserDefine
            // 
            this.radioButtonUserDefine.AutoSize = true;
            this.radioButtonUserDefine.Location = new System.Drawing.Point(6, 40);
            this.radioButtonUserDefine.Name = "radioButtonUserDefine";
            this.radioButtonUserDefine.Size = new System.Drawing.Size(82, 16);
            this.radioButtonUserDefine.TabIndex = 3;
            this.radioButtonUserDefine.TabStop = true;
            this.radioButtonUserDefine.Text = "指定フォルダ";
            this.radioButtonUserDefine.UseVisualStyleBackColor = true;
            // 
            // radioButtonAutoSave
            // 
            this.radioButtonAutoSave.AutoSize = true;
            this.radioButtonAutoSave.Location = new System.Drawing.Point(6, 18);
            this.radioButtonAutoSave.Name = "radioButtonAutoSave";
            this.radioButtonAutoSave.Size = new System.Drawing.Size(128, 16);
            this.radioButtonAutoSave.TabIndex = 3;
            this.radioButtonAutoSave.TabStop = true;
            this.radioButtonAutoSave.Text = "前回終了時のフォルダ";
            this.radioButtonAutoSave.UseVisualStyleBackColor = true;
            this.radioButtonAutoSave.CheckedChanged += new System.EventHandler(this.radioButtonAutoSave_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "MB以上";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "読み込み時警告ファイルサイズ：";
            // 
            // numericUpDownAlarmFileSize
            // 
            this.numericUpDownAlarmFileSize.Location = new System.Drawing.Point(174, 109);
            this.numericUpDownAlarmFileSize.Name = "numericUpDownAlarmFileSize";
            this.numericUpDownAlarmFileSize.Size = new System.Drawing.Size(56, 19);
            this.numericUpDownAlarmFileSize.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(413, 320);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(116, 27);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxShowStrings
            // 
            this.checkBoxShowStrings.AutoSize = true;
            this.checkBoxShowStrings.Location = new System.Drawing.Point(14, 154);
            this.checkBoxShowStrings.Name = "checkBoxShowStrings";
            this.checkBoxShowStrings.Size = new System.Drawing.Size(159, 16);
            this.checkBoxShowStrings.TabIndex = 5;
            this.checkBoxShowStrings.Text = "ツールバーの文字を表示する";
            this.checkBoxShowStrings.UseVisualStyleBackColor = true;
            // 
            // FormUserConfig
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 359);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormUserConfig";
            this.Text = "設定";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFileMaskNumber)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutOfRangeColor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlarmFileSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectInitialDirectory;
        private System.Windows.Forms.TextBox textBoxInitialDirectory;
        private System.Windows.Forms.NumericUpDown numericUpDownFileMaskNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonUserDefine;
        private System.Windows.Forms.RadioButton radioButtonAutoSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownAlarmFileSize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxEnablesOutOfRangeColor;
        private System.Windows.Forms.PictureBox pictureBoxOutOfRangeColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxShowStrings;
    }
}