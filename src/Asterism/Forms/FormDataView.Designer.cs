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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataView));
            comboBoxColorMode = new System.Windows.Forms.ComboBox();
            buttonRefresh = new System.Windows.Forms.Button();
            checkBoxUserMin = new System.Windows.Forms.CheckBox();
            checkBoxUserMax = new System.Windows.Forms.CheckBox();
            textBoxUserMin = new System.Windows.Forms.TextBox();
            textBoxUserMax = new System.Windows.Forms.TextBox();
            buttonCopyHorizontalLine = new System.Windows.Forms.Button();
            buttonCopyVerticalLine = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label11 = new System.Windows.Forms.Label();
            textBoxCursorValue = new System.Windows.Forms.TextBox();
            textBoxCursorXY = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            textBoxPV = new System.Windows.Forms.TextBox();
            textBoxDataSize = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            numericUpDownHorizontal = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            numericUpDownVertical = new System.Windows.Forms.NumericUpDown();
            textBoxMin = new System.Windows.Forms.TextBox();
            textBoxMax = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            zedGraphControlHorizontal = new ZedGraph.ZedGraphControl();
            zedGraphControlVertical = new ZedGraph.ZedGraphControl();
            pictureBoxZMap = new System.Windows.Forms.PictureBox();
            timerCheckCursorPosition = new System.Windows.Forms.Timer(components);
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            pictureBoxColorBar = new System.Windows.Forms.PictureBox();
            comboBoxConvertMode = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHorizontal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVertical).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxZMap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxColorBar).BeginInit();
            SuspendLayout();
            // 
            // comboBoxColorMode
            // 
            comboBoxColorMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxColorMode.DropDownWidth = 110;
            comboBoxColorMode.FormattingEnabled = true;
            comboBoxColorMode.Location = new System.Drawing.Point(325, 404);
            comboBoxColorMode.Name = "comboBoxColorMode";
            comboBoxColorMode.Size = new System.Drawing.Size(16, 20);
            comboBoxColorMode.TabIndex = 46;
            comboBoxColorMode.SelectedIndexChanged += comboBoxColorMode_SelectedIndexChanged;
            // 
            // buttonRefresh
            // 
            buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonRefresh.Image = (System.Drawing.Image)resources.GetObject("buttonRefresh.Image");
            buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonRefresh.Location = new System.Drawing.Point(225, 426);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new System.Drawing.Size(82, 23);
            buttonRefresh.TabIndex = 45;
            buttonRefresh.Text = "再描画";
            buttonRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // checkBoxUserMin
            // 
            checkBoxUserMin.AutoSize = true;
            checkBoxUserMin.Location = new System.Drawing.Point(14, 429);
            checkBoxUserMin.Name = "checkBoxUserMin";
            checkBoxUserMin.Size = new System.Drawing.Size(99, 16);
            checkBoxUserMin.TabIndex = 34;
            checkBoxUserMin.Text = "最小値を指定：";
            checkBoxUserMin.UseVisualStyleBackColor = true;
            checkBoxUserMin.CheckedChanged += checkBoxUserMin_CheckedChanged;
            // 
            // checkBoxUserMax
            // 
            checkBoxUserMax.AutoSize = true;
            checkBoxUserMax.Location = new System.Drawing.Point(313, 429);
            checkBoxUserMax.Name = "checkBoxUserMax";
            checkBoxUserMax.Size = new System.Drawing.Size(99, 16);
            checkBoxUserMax.TabIndex = 36;
            checkBoxUserMax.Text = "最大値を指定：";
            checkBoxUserMax.UseVisualStyleBackColor = true;
            checkBoxUserMax.CheckedChanged += checkBoxUserMax_CheckedChanged;
            // 
            // textBoxUserMin
            // 
            textBoxUserMin.Enabled = false;
            textBoxUserMin.ImeMode = System.Windows.Forms.ImeMode.Disable;
            textBoxUserMin.Location = new System.Drawing.Point(119, 428);
            textBoxUserMin.Name = "textBoxUserMin";
            textBoxUserMin.Size = new System.Drawing.Size(100, 19);
            textBoxUserMin.TabIndex = 35;
            textBoxUserMin.KeyUp += textBoxUserMin_KeyUp;
            // 
            // textBoxUserMax
            // 
            textBoxUserMax.Enabled = false;
            textBoxUserMax.ImeMode = System.Windows.Forms.ImeMode.Disable;
            textBoxUserMax.Location = new System.Drawing.Point(418, 428);
            textBoxUserMax.Name = "textBoxUserMax";
            textBoxUserMax.Size = new System.Drawing.Size(100, 19);
            textBoxUserMax.TabIndex = 37;
            textBoxUserMax.KeyUp += textBoxUserMin_KeyUp;
            // 
            // buttonCopyHorizontalLine
            // 
            buttonCopyHorizontalLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCopyHorizontalLine.Image = (System.Drawing.Image)resources.GetObject("buttonCopyHorizontalLine.Image");
            buttonCopyHorizontalLine.Location = new System.Drawing.Point(697, 473);
            buttonCopyHorizontalLine.Name = "buttonCopyHorizontalLine";
            buttonCopyHorizontalLine.Size = new System.Drawing.Size(43, 23);
            buttonCopyHorizontalLine.TabIndex = 43;
            buttonCopyHorizontalLine.UseVisualStyleBackColor = true;
            buttonCopyHorizontalLine.Click += buttonCopyHorizontalLine_Click;
            // 
            // buttonCopyVerticalLine
            // 
            buttonCopyVerticalLine.AccessibleDescription = "";
            buttonCopyVerticalLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCopyVerticalLine.Image = (System.Drawing.Image)resources.GetObject("buttonCopyVerticalLine.Image");
            buttonCopyVerticalLine.Location = new System.Drawing.Point(697, 448);
            buttonCopyVerticalLine.Name = "buttonCopyVerticalLine";
            buttonCopyVerticalLine.Size = new System.Drawing.Size(43, 23);
            buttonCopyVerticalLine.TabIndex = 44;
            buttonCopyVerticalLine.UseVisualStyleBackColor = true;
            buttonCopyVerticalLine.Click += buttonCopyVerticalLine_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(textBoxPV);
            groupBox1.Controls.Add(textBoxDataSize);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new System.Drawing.Point(524, 505);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(250, 138);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            groupBox1.Text = "ファイル情報";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textBoxCursorValue);
            groupBox2.Controls.Add(textBoxCursorXY);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new System.Drawing.Point(6, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(222, 62);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "カーソル位置";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(46, 36);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(23, 12);
            label11.TabIndex = 16;
            label11.Text = "値：";
            // 
            // textBoxCursorValue
            // 
            textBoxCursorValue.BackColor = System.Drawing.Color.Black;
            textBoxCursorValue.ForeColor = System.Drawing.Color.Lime;
            textBoxCursorValue.Location = new System.Drawing.Point(75, 33);
            textBoxCursorValue.Name = "textBoxCursorValue";
            textBoxCursorValue.ReadOnly = true;
            textBoxCursorValue.Size = new System.Drawing.Size(147, 19);
            textBoxCursorValue.TabIndex = 17;
            textBoxCursorValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCursorXY
            // 
            textBoxCursorXY.BackColor = System.Drawing.Color.Black;
            textBoxCursorXY.ForeColor = System.Drawing.Color.Lime;
            textBoxCursorXY.Location = new System.Drawing.Point(75, 12);
            textBoxCursorXY.Name = "textBoxCursorXY";
            textBoxCursorXY.ReadOnly = true;
            textBoxCursorXY.Size = new System.Drawing.Size(147, 19);
            textBoxCursorXY.TabIndex = 17;
            textBoxCursorXY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(34, 15);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(35, 12);
            label10.TabIndex = 16;
            label10.Text = "座標：";
            // 
            // textBoxPV
            // 
            textBoxPV.BackColor = System.Drawing.Color.Black;
            textBoxPV.ForeColor = System.Drawing.Color.Lime;
            textBoxPV.Location = new System.Drawing.Point(81, 43);
            textBoxPV.Name = "textBoxPV";
            textBoxPV.ReadOnly = true;
            textBoxPV.Size = new System.Drawing.Size(147, 19);
            textBoxPV.TabIndex = 17;
            textBoxPV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDataSize
            // 
            textBoxDataSize.BackColor = System.Drawing.Color.Black;
            textBoxDataSize.ForeColor = System.Drawing.Color.Lime;
            textBoxDataSize.Location = new System.Drawing.Point(81, 18);
            textBoxDataSize.Name = "textBoxDataSize";
            textBoxDataSize.ReadOnly = true;
            textBoxDataSize.Size = new System.Drawing.Size(147, 19);
            textBoxDataSize.TabIndex = 17;
            textBoxDataSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(43, 46);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(32, 12);
            label7.TabIndex = 16;
            label7.Text = "P-V：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(7, 21);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(68, 12);
            label6.TabIndex = 16;
            label6.Text = "データサイズ：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(555, 478);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(62, 12);
            label5.TabIndex = 39;
            label5.Text = "選択行(Y)：";
            // 
            // numericUpDownHorizontal
            // 
            numericUpDownHorizontal.Location = new System.Drawing.Point(634, 476);
            numericUpDownHorizontal.Name = "numericUpDownHorizontal";
            numericUpDownHorizontal.Size = new System.Drawing.Size(57, 19);
            numericUpDownHorizontal.TabIndex = 41;
            numericUpDownHorizontal.ValueChanged += numericUpDown_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(555, 453);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 12);
            label4.TabIndex = 38;
            label4.Text = "選択列(X)：";
            // 
            // numericUpDownVertical
            // 
            numericUpDownVertical.Location = new System.Drawing.Point(634, 451);
            numericUpDownVertical.Name = "numericUpDownVertical";
            numericUpDownVertical.Size = new System.Drawing.Size(57, 19);
            numericUpDownVertical.TabIndex = 40;
            numericUpDownVertical.ValueChanged += numericUpDown_ValueChanged;
            // 
            // textBoxMin
            // 
            textBoxMin.BackColor = System.Drawing.Color.Black;
            textBoxMin.ForeColor = System.Drawing.Color.White;
            textBoxMin.Location = new System.Drawing.Point(47, 404);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.Size = new System.Drawing.Size(129, 19);
            textBoxMin.TabIndex = 33;
            textBoxMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMax
            // 
            textBoxMax.BackColor = System.Drawing.Color.Black;
            textBoxMax.ForeColor = System.Drawing.Color.White;
            textBoxMax.Location = new System.Drawing.Point(385, 404);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new System.Drawing.Size(132, 19);
            textBoxMax.TabIndex = 32;
            textBoxMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(21, 25);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(31, 12);
            label9.TabIndex = 30;
            label9.Text = "(0, 0)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(12, 9);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(53, 12);
            label8.TabIndex = 29;
            label8.Text = "左上座標";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 407);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(29, 12);
            label3.TabIndex = 31;
            label3.Text = "Min：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(347, 407);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(32, 12);
            label2.TabIndex = 28;
            label2.Text = "Max：";
            // 
            // zedGraphControlHorizontal
            // 
            zedGraphControlHorizontal.Location = new System.Drawing.Point(14, 453);
            zedGraphControlHorizontal.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            zedGraphControlHorizontal.Name = "zedGraphControlHorizontal";
            zedGraphControlHorizontal.ScrollGrace = 0D;
            zedGraphControlHorizontal.ScrollMaxX = 0D;
            zedGraphControlHorizontal.ScrollMaxY = 0D;
            zedGraphControlHorizontal.ScrollMaxY2 = 0D;
            zedGraphControlHorizontal.ScrollMinX = 0D;
            zedGraphControlHorizontal.ScrollMinY = 0D;
            zedGraphControlHorizontal.ScrollMinY2 = 0D;
            zedGraphControlHorizontal.Size = new System.Drawing.Size(504, 191);
            zedGraphControlHorizontal.TabIndex = 26;
            zedGraphControlHorizontal.UseExtendedPrintDialog = true;
            // 
            // zedGraphControlVertical
            // 
            zedGraphControlVertical.BackColor = System.Drawing.SystemColors.Control;
            zedGraphControlVertical.Location = new System.Drawing.Point(523, 3);
            zedGraphControlVertical.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            zedGraphControlVertical.Name = "zedGraphControlVertical";
            zedGraphControlVertical.ScrollGrace = 0D;
            zedGraphControlVertical.ScrollMaxX = 0D;
            zedGraphControlVertical.ScrollMaxY = 0D;
            zedGraphControlVertical.ScrollMaxY2 = 0D;
            zedGraphControlVertical.ScrollMinX = 0D;
            zedGraphControlVertical.ScrollMinY = 0D;
            zedGraphControlVertical.ScrollMinY2 = 0D;
            zedGraphControlVertical.Size = new System.Drawing.Size(247, 438);
            zedGraphControlVertical.TabIndex = 27;
            zedGraphControlVertical.UseExtendedPrintDialog = true;
            // 
            // pictureBoxZMap
            // 
            pictureBoxZMap.BackColor = System.Drawing.Color.White;
            pictureBoxZMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBoxZMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBoxZMap.Location = new System.Drawing.Point(67, 9);
            pictureBoxZMap.Margin = new System.Windows.Forms.Padding(0);
            pictureBoxZMap.Name = "pictureBoxZMap";
            pictureBoxZMap.Size = new System.Drawing.Size(450, 390);
            pictureBoxZMap.TabIndex = 25;
            pictureBoxZMap.TabStop = false;
            pictureBoxZMap.Click += pictureBoxZMap_Click;
            // 
            // timerCheckCursorPosition
            // 
            timerCheckCursorPosition.Interval = 200;
            timerCheckCursorPosition.Tick += timerCheckCursorPosition_Tick;
            // 
            // button1
            // 
            button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
            button1.Location = new System.Drawing.Point(547, 447);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(34, 18);
            button1.TabIndex = 47;
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // button2
            // 
            button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
            button2.Location = new System.Drawing.Point(547, 471);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(34, 18);
            button2.TabIndex = 47;
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            // 
            // button3
            // 
            button3.Image = (System.Drawing.Image)resources.GetObject("button3.Image");
            button3.Location = new System.Drawing.Point(524, 451);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(18, 34);
            button3.TabIndex = 47;
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            // 
            // button4
            // 
            button4.Image = (System.Drawing.Image)resources.GetObject("button4.Image");
            button4.Location = new System.Drawing.Point(587, 451);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(18, 34);
            button4.TabIndex = 47;
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            // 
            // pictureBoxColorBar
            // 
            pictureBoxColorBar.BackColor = System.Drawing.Color.White;
            pictureBoxColorBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBoxColorBar.Location = new System.Drawing.Point(182, 405);
            pictureBoxColorBar.Name = "pictureBoxColorBar";
            pictureBoxColorBar.Size = new System.Drawing.Size(143, 17);
            pictureBoxColorBar.TabIndex = 48;
            pictureBoxColorBar.TabStop = false;
            // 
            // comboBoxConvertMode
            // 
            comboBoxConvertMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxConvertMode.FormattingEnabled = true;
            comboBoxConvertMode.Location = new System.Drawing.Point(11, 378);
            comboBoxConvertMode.Name = "comboBoxConvertMode";
            comboBoxConvertMode.Size = new System.Drawing.Size(53, 20);
            comboBoxConvertMode.TabIndex = 49;
            comboBoxConvertMode.SelectedIndexChanged += comboBoxConvertMode_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(5, 363);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 12);
            label1.TabIndex = 31;
            label1.Text = "表示形式：";
            // 
            // FormDataView
            // 
            AllowEndUserDocking = false;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(781, 657);
            CloseButton = false;
            CloseButtonVisible = false;
            Controls.Add(comboBoxConvertMode);
            Controls.Add(pictureBoxColorBar);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBoxColorMode);
            Controls.Add(buttonRefresh);
            Controls.Add(checkBoxUserMin);
            Controls.Add(checkBoxUserMax);
            Controls.Add(textBoxUserMin);
            Controls.Add(textBoxUserMax);
            Controls.Add(buttonCopyHorizontalLine);
            Controls.Add(buttonCopyVerticalLine);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(numericUpDownHorizontal);
            Controls.Add(label4);
            Controls.Add(numericUpDownVertical);
            Controls.Add(textBoxMin);
            Controls.Add(textBoxMax);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(zedGraphControlHorizontal);
            Controls.Add(zedGraphControlVertical);
            Controls.Add(pictureBoxZMap);
            DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            MaximumSize = new System.Drawing.Size(797, 696);
            Name = "FormDataView";
            Text = "メインビュー";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHorizontal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVertical).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxZMap).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxColorBar).EndInit();
            ResumeLayout(false);
            PerformLayout();

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