namespace PasswordManager.Individual.Policy
{
    partial class Charset
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
            this.groupedCheckBox = new PasswordManager.GuiParts.Utility.GroupedCheckBox();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupedCheckBox
            // 
            this.groupedCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupedCheckBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.groupedCheckBox.Location = new System.Drawing.Point(60, 0);
            this.groupedCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupedCheckBox.Name = "groupedCheckBox";
            this.groupedCheckBox.Size = new System.Drawing.Size(347, 150);
            this.groupedCheckBox.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(3, 10);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(53, 12);
            this.Title.TabIndex = 1;
            this.Title.Text = "使用文字";
            // 
            // Charset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Title);
            this.Controls.Add(this.groupedCheckBox);
            this.Name = "Charset";
            this.Size = new System.Drawing.Size(410, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PasswordManager.GuiParts.Utility.GroupedCheckBox groupedCheckBox;
        private System.Windows.Forms.Label Title;
    }
}
