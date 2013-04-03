namespace PasswordManager.MasterPassword
{
    partial class InitForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ViewName = new System.Windows.Forms.TextBox();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.InputAgain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.selectRoot = new System.Windows.Forms.Button();
            this.rootFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.DataFolder = new System.Windows.Forms.TextBox();
            this.selectDataFolder = new System.Windows.Forms.Button();
            this.dataFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ViewMasterFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名前";
            // 
            // ViewName
            // 
            this.ViewName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewName.Location = new System.Drawing.Point(100, 12);
            this.ViewName.Name = "ViewName";
            this.ViewName.Size = new System.Drawing.Size(280, 19);
            this.ViewName.TabIndex = 1;
            this.ViewName.TextChanged += new System.EventHandler(this.ViewName_TextChanged);
            // 
            // InputPassword
            // 
            this.InputPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputPassword.Location = new System.Drawing.Point(100, 62);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.PasswordChar = '*';
            this.InputPassword.Size = new System.Drawing.Size(280, 19);
            this.InputPassword.TabIndex = 2;
            this.InputPassword.UseSystemPasswordChar = true;
            // 
            // InputAgain
            // 
            this.InputAgain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputAgain.Location = new System.Drawing.Point(100, 87);
            this.InputAgain.Name = "InputAgain";
            this.InputAgain.PasswordChar = '*';
            this.InputAgain.Size = new System.Drawing.Size(280, 19);
            this.InputAgain.TabIndex = 3;
            this.InputAgain.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "マスタ パスワード";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "再入力";
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(224, 151);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 6;
            this.OK.Text = "(&O)K";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(305, 150);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "(&C)ancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // selectRoot
            // 
            this.selectRoot.Location = new System.Drawing.Point(346, 35);
            this.selectRoot.Name = "selectRoot";
            this.selectRoot.Size = new System.Drawing.Size(34, 23);
            this.selectRoot.TabIndex = 8;
            this.selectRoot.Text = "...";
            this.selectRoot.UseVisualStyleBackColor = true;
            this.selectRoot.Click += new System.EventHandler(this.selectRoot_Click);
            // 
            // rootFolderDialog
            // 
            this.rootFolderDialog.Description = "ルートディレクトリを選択します";
            this.rootFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "データフォルダ";
            // 
            // DataFolder
            // 
            this.DataFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataFolder.Location = new System.Drawing.Point(100, 112);
            this.DataFolder.Name = "DataFolder";
            this.DataFolder.Size = new System.Drawing.Size(240, 19);
            this.DataFolder.TabIndex = 10;
            this.DataFolder.Text = "./YPass";
            // 
            // selectDataFolder
            // 
            this.selectDataFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectDataFolder.Location = new System.Drawing.Point(346, 110);
            this.selectDataFolder.Name = "selectDataFolder";
            this.selectDataFolder.Size = new System.Drawing.Size(34, 23);
            this.selectDataFolder.TabIndex = 11;
            this.selectDataFolder.Text = "...";
            this.selectDataFolder.UseVisualStyleBackColor = true;
            this.selectDataFolder.Click += new System.EventHandler(this.selectDataFolder_Click);
            // 
            // dataFolderDialog
            // 
            this.dataFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // ViewMasterFile
            // 
            this.ViewMasterFile.Location = new System.Drawing.Point(100, 37);
            this.ViewMasterFile.Name = "ViewMasterFile";
            this.ViewMasterFile.ReadOnly = true;
            this.ViewMasterFile.Size = new System.Drawing.Size(240, 19);
            this.ViewMasterFile.TabIndex = 12;
            // 
            // InitForm
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(392, 182);
            this.Controls.Add(this.ViewMasterFile);
            this.Controls.Add(this.selectDataFolder);
            this.Controls.Add(this.DataFolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectRoot);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputAgain);
            this.Controls.Add(this.InputPassword);
            this.Controls.Add(this.ViewName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "InitForm";
            this.Text = "InitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ViewName;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.TextBox InputAgain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button selectRoot;
        private System.Windows.Forms.FolderBrowserDialog rootFolderDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DataFolder;
        private System.Windows.Forms.Button selectDataFolder;
        private System.Windows.Forms.FolderBrowserDialog dataFolderDialog;
        private System.Windows.Forms.TextBox ViewMasterFile;
    }
}