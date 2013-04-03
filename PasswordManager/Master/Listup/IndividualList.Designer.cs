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
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backend = new PasswordManager.Master.Listup.Backend();
            this.AddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backendBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backend)).BeginInit();
            this.SuspendLayout();
            // 
            // ListView
            // 
            this.ListView.AllowUserToAddRows = false;
            this.ListView.AllowUserToDeleteRows = false;
            this.ListView.AllowUserToOrderColumns = true;
            this.ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView.AutoGenerateColumns = false;
            this.ListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.limitDataGridViewTextBoxColumn});
            this.ListView.DataMember = "ListItems";
            this.ListView.DataSource = this.backendBindingSource;
            this.ListView.Location = new System.Drawing.Point(0, 0);
            this.ListView.Name = "ListView";
            this.ListView.ReadOnly = true;
            this.ListView.RowTemplate.Height = 21;
            this.ListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListView.Size = new System.Drawing.Size(226, 135);
            this.ListView.TabIndex = 0;
            this.ListView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ListViewShowAlert);
            this.ListView.DoubleClick += new System.EventHandler(this.ListView_DoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "名前";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // limitDataGridViewTextBoxColumn
            // 
            this.limitDataGridViewTextBoxColumn.DataPropertyName = "Limit";
            this.limitDataGridViewTextBoxColumn.HeaderText = "期限";
            this.limitDataGridViewTextBoxColumn.Name = "limitDataGridViewTextBoxColumn";
            this.limitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // backendBindingSource
            // 
            this.backendBindingSource.DataSource = this.backend;
            this.backendBindingSource.Position = 0;
            // 
            // backend
            // 
            this.backend.DataSetName = "Backend";
            this.backend.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.backendBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListView;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.BindingSource backendBindingSource;
        private Backend backend;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitDataGridViewTextBoxColumn;
    }
}
