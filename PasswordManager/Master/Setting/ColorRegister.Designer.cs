namespace PasswordManager.Master.Setting
{
    partial class ColorRegister
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
            this.Sample = new System.Windows.Forms.TextBox();
            this.buttonFore = new System.Windows.Forms.Button();
            this.foreColorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonBack = new System.Windows.Forms.Button();
            this.backColorDialog = new System.Windows.Forms.ColorDialog();
            this.Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sample
            // 
            this.Sample.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Sample.Location = new System.Drawing.Point(75, 2);
            this.Sample.Name = "Sample";
            this.Sample.ReadOnly = true;
            this.Sample.Size = new System.Drawing.Size(193, 19);
            this.Sample.TabIndex = 0;
            this.Sample.Text = "Sample";
            // 
            // buttonFore
            // 
            this.buttonFore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFore.Location = new System.Drawing.Point(270, 0);
            this.buttonFore.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFore.Name = "buttonFore";
            this.buttonFore.Size = new System.Drawing.Size(41, 23);
            this.buttonFore.TabIndex = 1;
            this.buttonFore.Text = "変更";
            this.buttonFore.UseVisualStyleBackColor = true;
            this.buttonFore.Click += new System.EventHandler(this.buttonFore_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(311, 0);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(41, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "変更";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(3, 5);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(28, 12);
            this.Label.TabIndex = 3;
            this.Label.Text = "Title";
            // 
            // ColorRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonFore);
            this.Controls.Add(this.Sample);
            this.Name = "ColorRegister";
            this.Size = new System.Drawing.Size(352, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Sample;
        private System.Windows.Forms.Button buttonFore;
        private System.Windows.Forms.ColorDialog foreColorDialog;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ColorDialog backColorDialog;
        private System.Windows.Forms.Label Label;
    }
}
