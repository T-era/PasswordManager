namespace PasswordManager.Individual.Policy
{
    partial class ValidLimit
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
            this.Title = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.NumericUpDown();
            this.Unit = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(3, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(53, 12);
            this.Title.TabIndex = 0;
            this.Title.Text = "警告期限";
            // 
            // Number
            // 
            this.Number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.Number.Location = new System.Drawing.Point(60, 3);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(47, 19);
            this.Number.TabIndex = 1;
            this.Number.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Unit
            // 
            this.Unit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Unit.AutoCompleteCustomSource.AddRange(new string[] {
            "週",
            "月",
            "年"});
            this.Unit.FormattingEnabled = true;
            this.Unit.Items.AddRange(new object[] {
            "週",
            "月",
            "年"});
            this.Unit.Location = new System.Drawing.Point(113, 2);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(58, 20);
            this.Unit.TabIndex = 2;
            // 
            // ValidLimit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Title);
            this.Name = "ValidLimit";
            this.Size = new System.Drawing.Size(190, 26);
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.NumericUpDown Number;
        private System.Windows.Forms.ComboBox Unit;
    }
}
