namespace ZadanieRekrutacyjneITC.Windows
{
    partial class DocumentList
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
            this.laTitle = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laTitle.Appearance.Options.UseFont = true;
            this.laTitle.Location = new System.Drawing.Point(381, 13);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(188, 52);
            this.laTitle.TabIndex = 0;
            this.laTitle.Text = "Nagłówek";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.itemBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 172);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(935, 392);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colCount,
            this.colPriceN,
            this.colPriceB,
            this.colDocumentId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(ZadanieRekrutacyjneITC.Entities.Item);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colCount
            // 
            this.colCount.FieldName = "Count";
            this.colCount.Name = "colCount";
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 1;
            // 
            // colPriceN
            // 
            this.colPriceN.FieldName = "PriceN";
            this.colPriceN.Name = "colPriceN";
            this.colPriceN.Visible = true;
            this.colPriceN.VisibleIndex = 2;
            // 
            // colPriceB
            // 
            this.colPriceB.FieldName = "PriceB";
            this.colPriceB.Name = "colPriceB";
            this.colPriceB.Visible = true;
            this.colPriceB.VisibleIndex = 3;
            // 
            // colDocumentId
            // 
            this.colDocumentId.FieldName = "DocumentId";
            this.colDocumentId.Name = "colDocumentId";
            // 
            // DocumentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 576);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.laTitle);
            this.Name = "DocumentList";
            this.Text = "Document";
            this.Load += new System.EventHandler(this.DocumentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl laTitle;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceN;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceB;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentId;
    }
}