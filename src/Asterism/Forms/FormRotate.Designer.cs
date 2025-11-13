namespace Asterism
{
    partial class FormRotate
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRadian = new System.Windows.Forms.TextBox();
            this.numericUpDownDegree = new System.Windows.Forms.NumericUpDown();
            this.radioButtonRadian = new System.Windows.Forms.RadioButton();
            this.radioButtonDegree = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDegree)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(117, 135);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(95, 32);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(218, 135);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 32);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxRadian);
            this.groupBox1.Controls.Add(this.numericUpDownDegree);
            this.groupBox1.Controls.Add(this.radioButtonRadian);
            this.groupBox1.Controls.Add(this.radioButtonDegree);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "オリジナルに対しての回転角指定　（プラスで反時計回り）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "[rad]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "[°]";
            // 
            // textBoxRadian
            // 
            this.textBoxRadian.Enabled = false;
            this.textBoxRadian.Location = new System.Drawing.Point(104, 71);
            this.textBoxRadian.Name = "textBoxRadian";
            this.textBoxRadian.Size = new System.Drawing.Size(120, 19);
            this.textBoxRadian.TabIndex = 2;
            // 
            // numericUpDownDegree
            // 
            this.numericUpDownDegree.Location = new System.Drawing.Point(104, 33);
            this.numericUpDownDegree.Name = "numericUpDownDegree";
            this.numericUpDownDegree.Size = new System.Drawing.Size(120, 19);
            this.numericUpDownDegree.TabIndex = 1;
            // 
            // radioButtonRadian
            // 
            this.radioButtonRadian.AutoSize = true;
            this.radioButtonRadian.Location = new System.Drawing.Point(27, 71);
            this.radioButtonRadian.Name = "radioButtonRadian";
            this.radioButtonRadian.Size = new System.Drawing.Size(63, 16);
            this.radioButtonRadian.TabIndex = 0;
            this.radioButtonRadian.Text = "rad指定";
            this.radioButtonRadian.UseVisualStyleBackColor = true;
            this.radioButtonRadian.CheckedChanged += new System.EventHandler(this.radioButtonRadian_CheckedChanged);
            // 
            // radioButtonDegree
            // 
            this.radioButtonDegree.AutoSize = true;
            this.radioButtonDegree.Checked = true;
            this.radioButtonDegree.Location = new System.Drawing.Point(27, 36);
            this.radioButtonDegree.Name = "radioButtonDegree";
            this.radioButtonDegree.Size = new System.Drawing.Size(71, 16);
            this.radioButtonDegree.TabIndex = 0;
            this.radioButtonDegree.TabStop = true;
            this.radioButtonDegree.Text = "度数指定";
            this.radioButtonDegree.UseVisualStyleBackColor = true;
            this.radioButtonDegree.CheckedChanged += new System.EventHandler(this.radioButtonDegree_CheckedChanged);
            // 
            // FormRotate
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(324, 173);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRotate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "回転角指定";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDegree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRadian;
        private System.Windows.Forms.NumericUpDown numericUpDownDegree;
        private System.Windows.Forms.RadioButton radioButtonRadian;
        private System.Windows.Forms.RadioButton radioButtonDegree;
    }
}