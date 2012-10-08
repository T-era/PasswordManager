namespace PasswordManager.Individual.Policy
{
    partial class SettingView
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
            this.charset1 = new PasswordManager.Individual.Policy.Charset();
            this.length1 = new PasswordManager.Individual.Policy.Length();
            this.validLimit1 = new PasswordManager.Individual.Policy.ValidLimit();
            this.SuspendLayout();
            // 
            // charset1
            // 
            this.charset1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.charset1.Location = new System.Drawing.Point(3, 68);
            this.charset1.Name = "charset1";
            this.charset1.Size = new System.Drawing.Size(436, 231);
            this.charset1.TabIndex = 2;
            // 
            // length1
            // 
            this.length1.Location = new System.Drawing.Point(4, 37);
            this.length1.Name = "length1";
            this.length1.Size = new System.Drawing.Size(265, 25);
            this.length1.TabIndex = 1;
            // 
            // validLimit1
            // 
            this.validLimit1.Location = new System.Drawing.Point(4, 4);
            this.validLimit1.Name = "validLimit1";
            this.validLimit1.Size = new System.Drawing.Size(170, 26);
            this.validLimit1.TabIndex = 0;
            // 
            // SettingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.charset1);
            this.Controls.Add(this.length1);
            this.Controls.Add(this.validLimit1);
            this.Name = "SettingView";
            this.Size = new System.Drawing.Size(442, 302);
            this.ResumeLayout(false);

        }

        #endregion

        private ValidLimit validLimit1;
        private Length length1;
        private Charset charset1;

    }
}
