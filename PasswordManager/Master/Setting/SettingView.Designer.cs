namespace PasswordManager.Master.Setting
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
            this.Colors = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.RemarksInput = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.masterPassword1 = new PasswordManager.Master.Setting.MasterPassword();
            this.baseFolder = new PasswordManager.Master.Setting.FolderSelector();
            this.focusColorRegister = new PasswordManager.Master.Setting.ColorRegister();
            this.hideColorRegister = new PasswordManager.Master.Setting.ColorRegister();
            this.Colors.SuspendLayout();
            this.SuspendLayout();
            // 
            // Colors
            // 
            this.Colors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Colors.Controls.Add(this.label2);
            this.Colors.Controls.Add(this.label1);
            this.Colors.Controls.Add(this.focusColorRegister);
            this.Colors.Controls.Add(this.hideColorRegister);
            this.Colors.Location = new System.Drawing.Point(3, 3);
            this.Colors.Name = "Colors";
            this.Colors.Size = new System.Drawing.Size(538, 77);
            this.Colors.TabIndex = 0;
            this.Colors.TabStop = false;
            this.Colors.Text = "色設定";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(494, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 11);
            this.label2.TabIndex = 2;
            this.label2.Text = "背景色";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(451, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 11);
            this.label1.TabIndex = 1;
            this.label1.Text = "前景色";
            // 
            // RemarksInput
            // 
            this.RemarksInput.AcceptsReturn = true;
            this.RemarksInput.AcceptsTab = true;
            this.RemarksInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.RemarksInput.Location = new System.Drawing.Point(85, 146);
            this.RemarksInput.Multiline = true;
            this.RemarksInput.Name = "RemarksInput";
            this.RemarksInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RemarksInput.Size = new System.Drawing.Size(450, 31);
            this.RemarksInput.TabIndex = 3;
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Location = new System.Drawing.Point(466, 183);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "保存";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "備考";
            // 
            // masterPassword1
            // 
            this.masterPassword1.Location = new System.Drawing.Point(9, 115);
            this.masterPassword1.Name = "masterPassword1";
            this.masterPassword1.Size = new System.Drawing.Size(308, 25);
            this.masterPassword1.TabIndex = 2;
            // 
            // baseFolder
            // 
            this.baseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.baseFolder.FolderPath = "";
            this.baseFolder.Location = new System.Drawing.Point(9, 86);
            this.baseFolder.Name = "baseFolder";
            this.baseFolder.Size = new System.Drawing.Size(470, 23);
            this.baseFolder.TabIndex = 1;
            this.baseFolder.Title = "データフォルダ";
            // 
            // focusColorRegister
            // 
            this.focusColorRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.focusColorRegister.BackColorPointed = System.Drawing.SystemColors.Control;
            this.focusColorRegister.ForeColorPointed = System.Drawing.SystemColors.WindowText;
            this.focusColorRegister.Location = new System.Drawing.Point(6, 49);
            this.focusColorRegister.Name = "focusColorRegister";
            this.focusColorRegister.Size = new System.Drawing.Size(526, 24);
            this.focusColorRegister.TabIndex = 1;
            this.focusColorRegister.Title = "フォーカス時";
            // 
            // hideColorRegister
            // 
            this.hideColorRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hideColorRegister.BackColorPointed = System.Drawing.SystemColors.Control;
            this.hideColorRegister.ForeColorPointed = System.Drawing.SystemColors.WindowText;
            this.hideColorRegister.Location = new System.Drawing.Point(6, 18);
            this.hideColorRegister.Name = "hideColorRegister";
            this.hideColorRegister.Size = new System.Drawing.Size(526, 25);
            this.hideColorRegister.TabIndex = 0;
            this.hideColorRegister.Title = "伏表示";
            // 
            // SettingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.RemarksInput);
            this.Controls.Add(this.masterPassword1);
            this.Controls.Add(this.baseFolder);
            this.Controls.Add(this.Colors);
            this.Name = "SettingView";
            this.Size = new System.Drawing.Size(544, 209);
            this.Colors.ResumeLayout(false);
            this.Colors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Colors;
        private ColorRegister hideColorRegister;
        private ColorRegister focusColorRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private FolderSelector baseFolder;
        private MasterPassword masterPassword1;
        private System.Windows.Forms.TextBox RemarksInput;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label3;
    }
}
