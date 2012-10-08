namespace PasswordManager.Master.Listup
{
    partial class IndividualList
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
            this.components = new System.ComponentModel.Container();
            this.ListView = new System.Windows.Forms.DataGridView();
            this.AddNew = new System.Windows.Forms.Button();
            this.backend = new PasswordManager.Master.Listup.Backend();
            this.backendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backendBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ListView
            // 
            this.ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView.AutoGenerateColumns = false;
            this.ListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.limitDataGridViewTextBoxColumn,
            this.pathDataGridViewTextBoxColumn});
            this.ListView.DataMember = "ListItems";
            this.ListView.DataSource = this.backendBindingSource;
            this.ListView.Location = new System.Drawing.Point(0, 0);
            this.ListView.Name = "ListView";
            this.ListView.RowTemplate.Height = 21;
            this.ListView.Size = new System.Drawing.Size(226, 135);
            this.ListView.TabIndex = 0;
            // 
            // AddNew
            // 
            this.AddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNew.Location = new System.Drawing.Point(148, 141);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(75, 23);
            this.AddNew.TabIndex = 1;
            this.AddNew.Text = "追加";
            this.AddNew.UseVisualStyleBackColor = true;
            // 
            // backend
            // 
            this.backend.DataSetName = "Backend";
            this.backend.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backendBindingSource
            // 
            this.backendBindingSource.DataSource = this.backend;
            this.backendBindingSource.Position = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "名前";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // limitDataGridViewTextBoxColumn
            // 
            this.limitDataGridViewTextBoxColumn.DataPropertyName = "Limit";
            this.limitDataGridViewTextBoxColumn.HeaderText = "期限";
            this.limitDataGridViewTextBoxColumn.Name = "limitDataGridViewTextBoxColumn";
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "パス";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            // 
            // IndividualList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddNew);
            this.Controls.Add(this.ListView);
            this.Name = "IndividualList";
            this.Size = new System.Drawing.Size(226, 167);
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backendBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListView;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.BindingSource backendBindingSource;
        private Backend backend;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
    }
}
