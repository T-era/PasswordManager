namespace PasswordManager.Individual.Alter
{
    partial class SecretView
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.password1 = new PasswordManager.Individual.Alter.Password();
            this.timestamp1 = new PasswordManager.Individual.Alter.Timestamp();
            this.Generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password1
            // 
            this.password1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.password1.Location = new System.Drawing.Point(3, 3);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(316, 21);
            this.password1.TabIndex = 0;
            // 
            // timestamp1
            // 
            this.timestamp1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.timestamp1.Location = new System.Drawing.Point(3, 30);
            this.timestamp1.Name = "timestamp1";
            this.timestamp1.Size = new System.Drawing.Size(316, 20);
            this.timestamp1.TabIndex = 1;
            // 
            // Generate
            // 
            this.Generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Generate.Location = new System.Drawing.Point(244, 56);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 2;
            this.Generate.Text = "生成";
            this.Generate.UseVisualStyleBackColor = true;
            // 
            // SecretView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.timestamp1);
            this.Controls.Add(this.password1);
            this.Name = "SecretView";
            this.Size = new System.Drawing.Size(322, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private Password password1;
        private Timestamp timestamp1;
        private System.Windows.Forms.Button Generate;

    }
}
