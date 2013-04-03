namespace PasswordManager.Individual.Policy
{
    partial class Length
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
            this.FromTo = new System.Windows.Forms.CheckBox();
            this.To = new System.Windows.Forms.NumericUpDown();
            this.From = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.To)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.From)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(3, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(25, 12);
            this.Title.TabIndex = 0;
            this.Title.Text = "長さ";
            // 
            // FromTo
            // 
            this.FromTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FromTo.AutoSize = true;
            this.FromTo.Location = new System.Drawing.Point(184, 3);
            this.FromTo.Name = "FromTo";
            this.FromTo.Size = new System.Drawing.Size(72, 16);
            this.FromTo.TabIndex = 1;
            this.FromTo.Text = "範囲指定";
            this.FromTo.UseVisualStyleBackColor = true;
            this.FromTo.CheckedChanged += new System.EventHandler(this.FromTo_CheckedChanged);
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(133, 2);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(45, 19);
            this.To.TabIndex = 2;
            this.To.ValueChanged += new System.EventHandler(this.To_ValueChanged);
            // 
            // From
            // 
            this.From.Location = new System.Drawing.Point(60, 2);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(45, 19);
            this.From.TabIndex = 3;
            this.From.ValueChanged += new System.EventHandler(this.From_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "～";
            // 
            // Length
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.From);
            this.Controls.Add(this.To);
            this.Controls.Add(this.FromTo);
            this.Controls.Add(this.Title);
            this.Name = "Length";
            this.Size = new System.Drawing.Size(259, 25);
            ((System.ComponentModel.ISupportInitialize)(this.To)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.From)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.CheckBox FromTo;
        private System.Windows.Forms.NumericUpDown To;
        private System.Windows.Forms.NumericUpDown From;
        private System.Windows.Forms.Label label1;
    }
}
