namespace Asterism
{
    partial class FormDataView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataView));
            this.comboBoxColorMode = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.checkBoxUserMin = new System.Windows.Forms.CheckBox();
            this.checkBoxUserMax = new System.Windows.Forms.CheckBox();
            this.textBoxUserMin = new System.Windows.Forms.TextBox();
            this.textBoxUserMax = new System.Windows.Forms.TextBox();
            this.buttonCopyHorizontalLine = new System.Windows.Forms.Button();
            this.buttonCopyVerticalLine = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCursorValue = new System.Windows.Forms.TextBox();
            this.textBoxCursorXY = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPV = new System.Windows.Forms.TextBox();
            this.textBoxDataSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownHorizontal = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownVertical = new System.Windows.Forms.NumericUpDown();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zedGraphControlHorizontal = new ZedGraph.ZedGraphControl();
            this.zedGraphControlVertical = new ZedGraph.ZedGraphControl();
            this.pictureBoxZMap = new System.Windows.Forms.PictureBox();
            this.timerCheckCursorPosition = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBoxColorBar = new System.Windows.Forms.PictureBox();
            this.comboBoxConvertMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorBar)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxColorMode
            // 
            this.comboBoxColorMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColorMode.DropDownWidth = 110;
            this.comboBoxColorMode.FormattingEnabled = true;
            this.comboBoxColorMode.Location = new System.Drawing.Point(325, 404);
            this.comboBoxColorMode.Name = "comboBoxColorMode";
            this.comboBoxColorMode.Size = new System.Drawing.Size(16, 20);
            this.comboBoxColorMode.TabIndex = 46;
            this.comboBoxColorMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorMode_SelectedIndexChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefresh.Location = new System.Drawing.Point(225, 426);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(82, 23);
            this.buttonRefresh.TabIndex = 45;
            this.buttonRefresh.Text = "再描画";
            this.buttonRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // checkBoxUserMin
            // 
            this.checkBoxUserMin.AutoSize = true;
            this.checkBoxUserMin.Location = new System.Drawing.Point(14, 429);
            this.checkBoxUserMin.Name = "checkBoxUserMin";
            this.checkBoxUserMin.Size = new System.Drawing.Size(99, 16);
            this.checkBoxUserMin.TabIndex = 34;
            this.checkBoxUserMin.Text = "最小値を指定：";
            this.checkBoxUserMin.UseVisualStyleBackColor = true;
            this.checkBoxUserMin.CheckedChanged += new System.EventHandler(this.checkBoxUserMin_CheckedChanged);
            // 
            // checkBoxUserMax
            // 
            this.checkBoxUserMax.AutoSize = true;
            this.checkBoxUserMax.Location = new System.Drawing.Point(313, 429);
            this.checkBoxUserMax.Name = "checkBoxUserMax";
            this.checkBoxUserMax.Size = new System.Drawing.Size(99, 16);
            this.checkBoxUserMax.TabIndex = 36;
            this.checkBoxUserMax.Text = "最大値を指定：";
            this.checkBoxUserMax.UseVisualStyleBackColor = true;
            this.checkBoxUserMax.CheckedChanged += new System.EventHandler(this.checkBoxUserMax_CheckedChanged);
            // 
            // textBoxUserMin
            // 
            this.textBoxUserMin.Enabled = false;
            this.textBoxUserMin.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxUserMin.Location = new System.Drawing.Point(119, 428);
            this.textBoxUserMin.Name = "textBoxUserMin";
            this.textBoxUserMin.Size = new System.Drawing.Size(100, 19);
            this.textBoxUserMin.TabIndex = 35;
            this.textBoxUserMin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxUserMin_KeyUp);
            // 
            // textBoxUserMax
            // 
            this.textBoxUserMax.Enabled = false;
            this.textBoxUserMax.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxUserMax.Location = new System.Drawing.Point(418, 428);
            this.textBoxUserMax.Name = "textBoxUserMax";
            this.textBoxUserMax.Size = new System.Drawing.Size(100, 19);
            this.textBoxUserMax.TabIndex = 37;
            this.textBoxUserMax.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxUserMin_KeyUp);
            // 
            // buttonCopyHorizontalLine
            // 
            this.buttonCopyHorizontalLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopyHorizontalLine.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyHorizontalLine.Image")));
            this.buttonCopyHorizontalLine.Location = new System.Drawing.Point(697, 473);
            this.buttonCopyHorizontalLine.Name = "buttonCopyHorizontalLine";
            this.buttonCopyHorizontalLine.Size = new System.Drawing.Size(43, 23);
            this.buttonCopyHorizontalLine.TabIndex = 43;
            this.buttonCopyHorizontalLine.UseVisualStyleBackColor = true;
            this.buttonCopyHorizontalLine.Click += new System.EventHandler(this.buttonCopyHorizontalLine_Click);
            // 
            // buttonCopyVerticalLine
            // 
            this.buttonCopyVerticalLine.AccessibleDescription = "";
            this.buttonCopyVerticalLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopyVerticalLine.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyVerticalLine.Image")));
            this.buttonCopyVerticalLine.Location = new System.Drawing.Point(697, 448);
            this.buttonCopyVerticalLine.Name = "buttonCopyVerticalLine";
            this.buttonCopyVerticalLine.Size = new System.Drawing.Size(43, 23);
            this.buttonCopyVerticalLine.TabIndex = 44;
            this.buttonCopyVerticalLine.UseVisualStyleBackColor = true;
            this.buttonCopyVerticalLine.Click += new System.EventHandler(this.buttonCopyVerticalLine_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBoxPV);
            this.groupBox1.Controls.Add(this.textBoxDataSize);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(524, 505);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 138);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ファイル情報";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBoxCursorValue);
            this.groupBox2.Controls.Add(this.textBoxCursorXY);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(6, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 62);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "カーソル位置";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "値：";
            // 
            // textBoxCursorValue
            // 
            this.textBoxCursorValue.BackColor = System.Drawing.Color.Black;
            this.textBoxCursorValue.ForeColor = System.Drawing.Color.Lime;
            this.textBoxCursorValue.Location = new System.Drawing.Point(75, 33);
            this.textBoxCursorValue.Name = "textBoxCursorValue";
            this.textBoxCursorValue.ReadOnly = true;
            this.textBoxCursorValue.Size = new System.Drawing.Size(147, 19);
            this.textBoxCursorValue.TabIndex = 17;
            this.textBoxCursorValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCursorXY
            // 
            this.textBoxCursorXY.BackColor = System.Drawing.Color.Black;
            this.textBoxCursorXY.ForeColor = System.Drawing.Color.Lime;
            this.textBoxCursorXY.Location = new System.Drawing.Point(75, 12);
            this.textBoxCursorXY.Name = "textBoxCursorXY";
            this.textBoxCursorXY.ReadOnly = true;
            this.textBoxCursorXY.Size = new System.Drawing.Size(147, 19);
            this.textBoxCursorXY.TabIndex = 17;
            this.textBoxCursorXY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "座標：";
            // 
            // textBoxPV
            // 
            this.textBoxPV.BackColor = System.Drawing.Color.Black;
            this.textBoxPV.ForeColor = System.Drawing.Color.Lime;
            this.textBoxPV.Location = new System.Drawing.Point(81, 43);
            this.textBoxPV.Name = "textBoxPV";
            this.textBoxPV.ReadOnly = true;
            this.textBoxPV.Size = new System.Drawing.Size(147, 19);
            this.textBoxPV.TabIndex = 17;
            this.textBoxPV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDataSize
            // 
            this.textBoxDataSize.BackColor = System.Drawing.Color.Black;
            this.textBoxDataSize.ForeColor = System.Drawing.Color.Lime;
            this.textBoxDataSize.Location = new System.Drawing.Point(81, 18);
            this.textBoxDataSize.Name = "textBoxDataSize";
            this.textBoxDataSize.ReadOnly = true;
            this.textBoxDataSize.Size = new System.Drawing.Size(147, 19);
            this.textBoxDataSize.TabIndex = 17;
            this.textBoxDataSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "P-V：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "データサイズ：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 12);
            this.label5.TabIndex = 39;
            this.label5.Text = "選択行(Y)：";
            // 
            // numericUpDownHorizontal
            // 
            this.numericUpDownHorizontal.Location = new System.Drawing.Point(634, 476);
            this.numericUpDownHorizontal.Name = "numericUpDownHorizontal";
            this.numericUpDownHorizontal.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownHorizontal.TabIndex = 41;
            this.numericUpDownHorizontal.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 12);
            this.label4.TabIndex = 38;
            this.label4.Text = "選択列(X)：";
            // 
            // numericUpDownVertical
            // 
            this.numericUpDownVertical.Location = new System.Drawing.Point(634, 451);
            this.numericUpDownVertical.Name = "numericUpDownVertical";
            this.numericUpDownVertical.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownVertical.TabIndex = 40;
            this.numericUpDownVertical.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // textBoxMin
            // 
            this.textBoxMin.BackColor = System.Drawing.Color.Black;
            this.textBoxMin.ForeColor = System.Drawing.Color.White;
            this.textBoxMin.Location = new System.Drawing.Point(47, 404);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(129, 19);
            this.textBoxMin.TabIndex = 33;
            this.textBoxMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMax
            // 
            this.textBoxMax.BackColor = System.Drawing.Color.Black;
            this.textBoxMax.ForeColor = System.Drawing.Color.White;
            this.textBoxMax.Location = new System.Drawing.Point(385, 404);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(132, 19);
            this.textBoxMax.TabIndex = 32;
            this.textBoxMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 12);
            this.label9.TabIndex = 30;
            this.label9.Text = "(0, 0)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "左上座標";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "Min：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "Max：";
            // 
            // zedGraphControlHorizontal
            // 
            this.zedGraphControlHorizontal.Location = new System.Drawing.Point(14, 453);
            this.zedGraphControlHorizontal.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.zedGraphControlHorizontal.Name = "zedGraphControlHorizontal";
            this.zedGraphControlHorizontal.ScrollGrace = 0;
            this.zedGraphControlHorizontal.ScrollMaxX = 0;
            this.zedGraphControlHorizontal.ScrollMaxY = 0;
            this.zedGraphControlHorizontal.ScrollMaxY2 = 0;
            this.zedGraphControlHorizontal.ScrollMinX = 0;
            this.zedGraphControlHorizontal.ScrollMinY = 0;
            this.zedGraphControlHorizontal.ScrollMinY2 = 0;
            this.zedGraphControlHorizontal.Size = new System.Drawing.Size(504, 191);
            this.zedGraphControlHorizontal.TabIndex = 26;
            // 
            // zedGraphControlVertical
            // 
            this.zedGraphControlVertical.BackColor = System.Drawing.SystemColors.Control;
            this.zedGraphControlVertical.Location = new System.Drawing.Point(523, 3);
            this.zedGraphControlVertical.Name = "zedGraphControlVertical";
            this.zedGraphControlVertical.ScrollGrace = 0;
            this.zedGraphControlVertical.ScrollMaxX = 0;
            this.zedGraphControlVertical.ScrollMaxY = 0;
            this.zedGraphControlVertical.ScrollMaxY2 = 0;
            this.zedGraphControlVertical.ScrollMinX = 0;
            this.zedGraphControlVertical.ScrollMinY = 0;
            this.zedGraphControlVertical.ScrollMinY2 = 0;
            this.zedGraphControlVertical.Size = new System.Drawing.Size(247, 438);
            this.zedGraphControlVertical.TabIndex = 27;
            // 
            // pictureBoxZMap
            // 
            this.pictureBoxZMap.BackColor = System.Drawing.Color.White;
            this.pictureBoxZMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxZMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxZMap.Location = new System.Drawing.Point(67, 9);
            this.pictureBoxZMap.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxZMap.Name = "pictureBoxZMap";
            this.pictureBoxZMap.Size = new System.Drawing.Size(450, 390);
            this.pictureBoxZMap.TabIndex = 25;
            this.pictureBoxZMap.TabStop = false;
            this.pictureBoxZMap.Click += new System.EventHandler(this.pictureBoxZMap_Click);
            // 
            // timerCheckCursorPosition
            // 
            this.timerCheckCursorPosition.Interval = 200;
            this.timerCheckCursorPosition.Tick += new System.EventHandler(this.timerCheckCursorPosition_Tick);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(547, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 18);
            this.button1.TabIndex = 47;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(547, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 18);
            this.button2.TabIndex = 47;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(524, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(18, 34);
            this.button3.TabIndex = 47;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(587, 451);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(18, 34);
            this.button4.TabIndex = 47;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // pictureBoxColorBar
            // 
            this.pictureBoxColorBar.BackColor = System.Drawing.Color.White;
            this.pictureBoxColorBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxColorBar.Location = new System.Drawing.Point(182, 405);
            this.pictureBoxColorBar.Name = "pictureBoxColorBar";
            this.pictureBoxColorBar.Size = new System.Drawing.Size(143, 17);
            this.pictureBoxColorBar.TabIndex = 48;
            this.pictureBoxColorBar.TabStop = false;
            // 
            // comboBoxConvertMode
            // 
            this.comboBoxConvertMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConvertMode.FormattingEnabled = true;
            this.comboBoxConvertMode.Location = new System.Drawing.Point(11, 378);
            this.comboBoxConvertMode.Name = "comboBoxConvertMode";
            this.comboBoxConvertMode.Size = new System.Drawing.Size(53, 20);
            this.comboBoxConvertMode.TabIndex = 49;
            this.comboBoxConvertMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxConvertMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 31;
            this.label1.Text = "表示形式：";
            // 
            // FormDataView
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 646);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.comboBoxConvertMode);
            this.Controls.Add(this.pictureBoxColorBar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxColorMode);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.checkBoxUserMin);
            this.Controls.Add(this.checkBoxUserMax);
            this.Controls.Add(this.textBoxUserMin);
            this.Controls.Add(this.textBoxUserMax);
            this.Controls.Add(this.buttonCopyHorizontalLine);
            this.Controls.Add(this.buttonCopyVerticalLine);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownHorizontal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownVertical);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zedGraphControlHorizontal);
            this.Controls.Add(this.zedGraphControlVertical);
            this.Controls.Add(this.pictureBoxZMap);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "FormDataView";
            this.Text = "メインビュー";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxColorMode;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.CheckBox checkBoxUserMin;
        private System.Windows.Forms.CheckBox checkBoxUserMax;
        private System.Windows.Forms.TextBox textBoxUserMin;
        private System.Windows.Forms.TextBox textBoxUserMax;
        private System.Windows.Forms.Button buttonCopyHorizontalLine;
        private System.Windows.Forms.Button buttonCopyVerticalLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxCursorValue;
        private System.Windows.Forms.TextBox textBoxCursorXY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPV;
        private System.Windows.Forms.TextBox textBoxDataSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownHorizontal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownVertical;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ZedGraph.ZedGraphControl zedGraphControlHorizontal;
        private ZedGraph.ZedGraphControl zedGraphControlVertical;
        private System.Windows.Forms.PictureBox pictureBoxZMap;
        private System.Windows.Forms.Timer timerCheckCursorPosition;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBoxColorBar;
        private System.Windows.Forms.ComboBox comboBoxConvertMode;
        private System.Windows.Forms.Label label1;
    }
}