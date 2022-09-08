namespace ZadanieRekrutacyjneITC.Windows
{
    partial class CreateDocument
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.teTitle = new DevExpress.XtraEditors.TextEdit();
            this.dataGridViewDocumentList = new System.Windows.Forms.DataGridView();
            this.clientNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelNag = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sbAdd = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbDelete = new DevExpress.XtraEditors.CheckButton();
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocumentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // teTitle
            // 
            this.teTitle.Location = new System.Drawing.Point(183, 38);
            this.teTitle.Name = "teTitle";
            this.teTitle.Properties.MaxLength = 49;
            this.teTitle.Size = new System.Drawing.Size(234, 20);
            this.teTitle.TabIndex = 0;
            // 
            // dataGridViewDocumentList
            // 
            this.dataGridViewDocumentList.AllowUserToDeleteRows = false;
            this.dataGridViewDocumentList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDocumentList.AutoGenerateColumns = false;
            this.dataGridViewDocumentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocumentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.priceNDataGridViewTextBoxColumn,
            this.priceBDataGridViewTextBoxColumn});
            this.dataGridViewDocumentList.DataSource = this.documentBindingSource;
            this.dataGridViewDocumentList.Location = new System.Drawing.Point(12, 75);
            this.dataGridViewDocumentList.Name = "dataGridViewDocumentList";
            this.dataGridViewDocumentList.RowTemplate.Height = 25;
            this.dataGridViewDocumentList.Size = new System.Drawing.Size(744, 198);
            this.dataGridViewDocumentList.TabIndex = 2;
            this.dataGridViewDocumentList.SelectionChanged += new System.EventHandler(this.dataGridViewDocumentList_SelectionChanged);
            // 
            // clientNumberDataGridViewTextBoxColumn
            // 
            this.clientNumberDataGridViewTextBoxColumn.DataPropertyName = "ClientNumber";
            this.clientNumberDataGridViewTextBoxColumn.HeaderText = "ClientNumber";
            this.clientNumberDataGridViewTextBoxColumn.Name = "clientNumberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            // 
            // priceNDataGridViewTextBoxColumn
            // 
            this.priceNDataGridViewTextBoxColumn.DataPropertyName = "PriceN";
            this.priceNDataGridViewTextBoxColumn.HeaderText = "PriceN";
            this.priceNDataGridViewTextBoxColumn.Name = "priceNDataGridViewTextBoxColumn";
            // 
            // priceBDataGridViewTextBoxColumn
            // 
            this.priceBDataGridViewTextBoxColumn.DataPropertyName = "PriceB";
            this.priceBDataGridViewTextBoxColumn.HeaderText = "PriceB";
            this.priceBDataGridViewTextBoxColumn.Name = "priceBDataGridViewTextBoxColumn";
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataSource = typeof(ZadanieRekrutacyjneITC.Entities.Document);
            // 
            // labelNag
            // 
            this.labelNag.Location = new System.Drawing.Point(12, 15);
            this.labelNag.Name = "labelNag";
            this.labelNag.Size = new System.Drawing.Size(26, 13);
            this.labelNag.TabIndex = 3;
            this.labelNag.Text = "Klient";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Tytuł";
            // 
            // sbAdd
            // 
            this.sbAdd.Location = new System.Drawing.Point(622, 12);
            this.sbAdd.Name = "sbAdd";
            this.sbAdd.Size = new System.Drawing.Size(134, 23);
            this.sbAdd.TabIndex = 5;
            this.sbAdd.Text = "Dodaj Dokument";
            this.sbAdd.Click += new System.EventHandler(this.sbAdd_Click);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(183, 11);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(234, 21);
            this.comboBoxClient.TabIndex = 8;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(ZadanieRekrutacyjneITC.Entities.Client);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.documentBindingSource;
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataSource = typeof(ZadanieRekrutacyjneITC.Entities.Client);
            // 
            // cbDelete
            // 
            this.cbDelete.Location = new System.Drawing.Point(622, 41);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(134, 23);
            this.cbDelete.TabIndex = 18;
            this.cbDelete.Text = "Usuń Dokument";
            // 
            // sbSave
            // 
            this.sbSave.Location = new System.Drawing.Point(482, 12);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(134, 23);
            this.sbSave.TabIndex = 19;
            this.sbSave.Text = "Zapisz zmiany";
            this.sbSave.Click += new System.EventHandler(this.sbSave_Click);
            // 
            // CreateDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 285);
            this.Controls.Add(this.sbSave);
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.sbAdd);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelNag);
            this.Controls.Add(this.dataGridViewDocumentList);
            this.Controls.Add(this.teTitle);
            this.MinimumSize = new System.Drawing.Size(2, 310);
            this.Name = "CreateDocument";
            this.Text = "Create_Document";
            this.Load += new System.EventHandler(this.CreateDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocumentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teTitle;
        private System.Windows.Forms.DataGridView dataGridViewDocumentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceBDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private DevExpress.XtraEditors.LabelControl labelNag;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton sbAdd;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private DevExpress.XtraEditors.CheckButton cbDelete;
        private DevExpress.XtraEditors.SimpleButton sbSave;
    }
}