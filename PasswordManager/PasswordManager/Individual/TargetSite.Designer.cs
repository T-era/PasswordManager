namespace PasswordManager.Individual
{
    partial class TargetSite
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
            this.Change = new System.Windows.Forms.Button();
            this.switchView1 = new PasswordManager.GuiParts.Utility.SwitchView();
            this.SuspendLayout();
            // 
            // Change
            // 
            this.Change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Change.Location = new System.Drawing.Point(287, 0);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(43, 23);
            this.Change.TabIndex = 1;
            this.Change.Text = "変更";
            this.Change.UseVisualStyleBackColor = true;
            // 
            // switchView1
            // 
            this.switchView1.Location = new System.Drawing.Point(0, 0);
            this.switchView1.Name = "switchView1";
            this.switchView1.Size = new System.Drawing.Size(281, 23);
            this.switchView1.TabIndex = 0;
            // 
            // TargetSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Change);
            this.Controls.Add(this.switchView1);
            this.Name = "TargetSite";
            this.Size = new System.Drawing.Size(330, 24);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Change;
        public GuiParts.Utility.SwitchView switchView1;
    }
}
