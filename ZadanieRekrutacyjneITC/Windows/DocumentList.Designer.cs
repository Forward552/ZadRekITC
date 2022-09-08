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
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.laNumberClient = new DevExpress.XtraEditors.LabelControl();
            this.laClientName = new DevExpress.XtraEditors.LabelControl();
            this.laCreateDate = new DevExpress.XtraEditors.LabelControl();
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.teCount = new DevExpress.XtraEditors.TextEdit();
            this.tePriceNetto = new DevExpress.XtraEditors.TextEdit();
            this.tePriceBrutto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.spAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.sbDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePriceNetto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePriceBrutto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laTitle.Appearance.Options.UseFont = true;
            this.laTitle.Appearance.Options.UseTextOptions = true;
            this.laTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.laTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.laTitle.Location = new System.Drawing.Point(12, 12);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(935, 52);
            this.laTitle.TabIndex = 0;
            this.laTitle.Text = "Nagłówek";
            this.laTitle.UseMnemonic = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.itemBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 227);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(935, 337);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DockChanged += new System.EventHandler(this.gridControl1_DockChanged);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(ZadanieRekrutacyjneITC.Entities.Item);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colCount,
            this.colPriceN,
            this.colPriceB});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // laNumberClient
            // 
            this.laNumberClient.Location = new System.Drawing.Point(98, 70);
            this.laNumberClient.Name = "laNumberClient";
            this.laNumberClient.Size = new System.Drawing.Size(66, 13);
            this.laNumberClient.TabIndex = 2;
            this.laNumberClient.Text = "Numer Klienta";
            // 
            // laClientName
            // 
            this.laClientName.Location = new System.Drawing.Point(98, 89);
            this.laClientName.Name = "laClientName";
            this.laClientName.Size = new System.Drawing.Size(66, 13);
            this.laClientName.TabIndex = 3;
            this.laClientName.Text = "Nazwa klienta";
            // 
            // laCreateDate
            // 
            this.laCreateDate.Appearance.Options.UseTextOptions = true;
            this.laCreateDate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.laCreateDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.laCreateDate.Location = new System.Drawing.Point(776, 70);
            this.laCreateDate.Name = "laCreateDate";
            this.laCreateDate.Size = new System.Drawing.Size(171, 13);
            this.laCreateDate.TabIndex = 4;
            this.laCreateDate.Text = "Data powstania";
            this.laCreateDate.UseMnemonic = false;
            // 
            // teName
            // 
            this.teName.Location = new System.Drawing.Point(98, 119);
            this.teName.Name = "teName";
            this.teName.Properties.MaxLength = 99;
            this.teName.Size = new System.Drawing.Size(369, 20);
            this.teName.TabIndex = 5;
            // 
            // teCount
            // 
            this.teCount.Location = new System.Drawing.Point(98, 145);
            this.teCount.Name = "teCount";
            this.teCount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.teCount.Properties.MaskSettings.Set("mask", "f");
            this.teCount.Properties.MaxLength = 5;
            this.teCount.Size = new System.Drawing.Size(369, 20);
            this.teCount.TabIndex = 6;
            // 
            // tePriceNetto
            // 
            this.tePriceNetto.Location = new System.Drawing.Point(583, 119);
            this.tePriceNetto.Name = "tePriceNetto";
            this.tePriceNetto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.tePriceNetto.Properties.MaskSettings.Set("mask", "c");
            this.tePriceNetto.Properties.MaxLength = 5;
            this.tePriceNetto.Size = new System.Drawing.Size(364, 20);
            this.tePriceNetto.TabIndex = 7;
            // 
            // tePriceBrutto
            // 
            this.tePriceBrutto.Location = new System.Drawing.Point(583, 145);
            this.tePriceBrutto.Name = "tePriceBrutto";
            this.tePriceBrutto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.tePriceBrutto.Properties.MaskSettings.Set("mask", "c");
            this.tePriceBrutto.Properties.MaxLength = 6;
            this.tePriceBrutto.Size = new System.Drawing.Size(364, 20);
            this.tePriceBrutto.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 148);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Ilość:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 122);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Nazwa Produktu:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(473, 148);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Cena produktu Brutto:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(473, 122);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(105, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Cena produktu Netto:";
            // 
            // spAdd
            // 
            this.spAdd.Location = new System.Drawing.Point(98, 171);
            this.spAdd.Name = "spAdd";
            this.spAdd.Size = new System.Drawing.Size(369, 23);
            this.spAdd.TabIndex = 13;
            this.spAdd.Text = "Dodaj Produkt";
            this.spAdd.Click += new System.EventHandler(this.spAdd_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 89);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 13);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Nazwa klienta:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 70);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(70, 13);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Numer Klienta:";
            // 
            // sbSave
            // 
            this.sbSave.Location = new System.Drawing.Point(583, 171);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(364, 23);
            this.sbSave.TabIndex = 16;
            this.sbSave.Text = "Zapisz Zmiany";
            this.sbSave.Click += new System.EventHandler(this.sbSave_Click);
            // 
            // sbDelete
            // 
            this.sbDelete.Location = new System.Drawing.Point(583, 200);
            this.sbDelete.Name = "sbDelete";
            this.sbDelete.Size = new System.Drawing.Size(364, 23);
            this.sbDelete.TabIndex = 17;
            this.sbDelete.Text = "Delete";
            this.sbDelete.Click += new System.EventHandler(this.sbDelete_Click);
            // 
            // DocumentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 576);
            this.Controls.Add(this.sbDelete);
            this.Controls.Add(this.sbSave);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.spAdd);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tePriceBrutto);
            this.Controls.Add(this.tePriceNetto);
            this.Controls.Add(this.teCount);
            this.Controls.Add(this.teName);
            this.Controls.Add(this.laCreateDate);
            this.Controls.Add(this.laClientName);
            this.Controls.Add(this.laNumberClient);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.laTitle);
            this.Name = "DocumentList";
            this.Text = "Document";
            this.Load += new System.EventHandler(this.DocumentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePriceNetto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePriceBrutto.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl laNumberClient;
        private DevExpress.XtraEditors.LabelControl laClientName;
        private DevExpress.XtraEditors.LabelControl laCreateDate;
        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraEditors.TextEdit teCount;
        private DevExpress.XtraEditors.TextEdit tePriceNetto;
        private DevExpress.XtraEditors.TextEdit tePriceBrutto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton spAdd;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton sbSave;
        private DevExpress.XtraEditors.SimpleButton sbDelete;
    }
}