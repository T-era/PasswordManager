namespace PasswordManager.Individual
{
    partial class IndividualWindow
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
            this.Remarks = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.secretView1 = new PasswordManager.Individual.Alter.SecretView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.settingView1 = new PasswordManager.Individual.Policy.SettingView();
            this.targetSite1 = new PasswordManager.Individual.TargetSite();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Remarks
            // 
            this.Remarks.AcceptsReturn = true;
            this.Remarks.AcceptsTab = true;
            this.Remarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Remarks.Location = new System.Drawing.Point(12, 38);
            this.Remarks.Multiline = true;
            this.Remarks.Name = "Remarks";
            this.Remarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Remarks.Size = new System.Drawing.Size(480, 62);
            this.Remarks.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 106);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 294);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.secretView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "パスワード";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // secretView1
            // 
            this.secretView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.secretView1.Location = new System.Drawing.Point(-4, 0);
            this.secretView1.Name = "secretView1";
            this.secretView1.Size = new System.Drawing.Size(476, 278);
            this.secretView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.settingView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ポリシー";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // settingView1
            // 
            this.settingView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.settingView1.Location = new System.Drawing.Point(0, 0);
            this.settingView1.Name = "settingView1";
            this.settingView1.Size = new System.Drawing.Size(472, 262);
            this.settingView1.TabIndex = 0;
            // 
            // targetSite1
            // 
            this.targetSite1.Location = new System.Drawing.Point(12, 8);
            this.targetSite1.Name = "targetSite1";
            this.targetSite1.Size = new System.Drawing.Size(364, 24);
            this.targetSite1.TabIndex = 3;
            // 
            // IndividualWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 412);
            this.Controls.Add(this.targetSite1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Remarks);
            this.Name = "IndividualWindow";
            this.Text = "IndividualWindow";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Remarks;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Alter.SecretView secretView1;
        private System.Windows.Forms.TabPage tabPage2;
        private Policy.SettingView settingView1;
        private TargetSite targetSite1;

    }
}