namespace PasswordManager.Individual.Alter
{
    partial class Password
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
            this.View = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // View
            // 
            this.View.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.View.Location = new System.Drawing.Point(60, 0);
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Size = new System.Drawing.Size(100, 19);
            this.View.TabIndex = 0;
            this.View.Enter += new System.EventHandler(this.View_Enter);
            this.View.Leave += new System.EventHandler(this.View_Leave);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(3, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(54, 12);
            this.Title.TabIndex = 1;
            this.Title.Text = "Password";
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Title);
            this.Controls.Add(this.View);
            this.Name = "Password";
            this.Size = new System.Drawing.Size(150, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox View;
        private System.Windows.Forms.Label Title;
    }
}
