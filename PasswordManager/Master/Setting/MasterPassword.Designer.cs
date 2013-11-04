namespace PasswordManager.Master.Setting
{
    partial class MasterPassword
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
            this.Label = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Button();
            this.SignInButton = new PasswordManager.GuiParts.LogonManageButton();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(3, 5);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(60, 12);
            this.Label.TabIndex = 0;
            this.Label.Text = "マスターパス";
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(156, 0);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(75, 23);
            this.Change.TabIndex = 2;
            this.Change.Text = "変更";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignInButton.Location = new System.Drawing.Point(75, 0);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(75, 23);
            this.SignInButton.TabIndex = 3;
            this.SignInButton.Text = "Not logged";
            this.SignInButton.UseVisualStyleBackColor = false;
            // 
            // MasterPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Label);
            this.Name = "MasterPassword";
            this.Size = new System.Drawing.Size(308, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button Change;
        private GuiParts.LogonManageButton SignInButton;
    }
}
