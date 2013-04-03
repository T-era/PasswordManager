namespace PasswordManager.Individual.Password
{
    partial class GeneratorWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.useThis1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.useThis2 = new System.Windows.Forms.Button();
            this.useThis3 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 19);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            // 
            // useThis1
            // 
            this.useThis1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.useThis1.Location = new System.Drawing.Point(197, 12);
            this.useThis1.Name = "useThis1";
            this.useThis1.Size = new System.Drawing.Size(75, 23);
            this.useThis1.TabIndex = 1;
            this.useThis1.Text = "(&1) use this";
            this.useThis1.UseVisualStyleBackColor = true;
            this.useThis1.Click += new System.EventHandler(this.useThis1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 19);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(179, 19);
            this.textBox3.TabIndex = 3;
            // 
            // useThis2
            // 
            this.useThis2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.useThis2.Location = new System.Drawing.Point(197, 41);
            this.useThis2.Name = "useThis2";
            this.useThis2.Size = new System.Drawing.Size(75, 23);
            this.useThis2.TabIndex = 4;
            this.useThis2.Text = "(&2) use this";
            this.useThis2.UseVisualStyleBackColor = true;
            this.useThis2.Click += new System.EventHandler(this.useThis2_Click);
            // 
            // useThis3
            // 
            this.useThis3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.useThis3.Location = new System.Drawing.Point(197, 70);
            this.useThis3.Name = "useThis3";
            this.useThis3.Size = new System.Drawing.Size(75, 23);
            this.useThis3.TabIndex = 5;
            this.useThis3.Text = "(&3) use this";
            this.useThis3.UseVisualStyleBackColor = true;
            this.useThis3.Click += new System.EventHandler(this.useThis3_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(197, 99);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "(&C)ancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // GeneratorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(284, 127);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.useThis3);
            this.Controls.Add(this.useThis2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.useThis1);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GeneratorWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GeneratorWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button useThis1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button useThis2;
        private System.Windows.Forms.Button useThis3;
        private System.Windows.Forms.Button Cancel;
    }
}