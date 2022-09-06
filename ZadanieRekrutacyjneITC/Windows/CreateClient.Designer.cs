namespace ZadanieRekrutacyjneITC.Windows
{
    partial class CreateClient
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
            this.sBAdd = new DevExpress.XtraEditors.SimpleButton();
            this.TEName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tENip = new DevExpress.XtraEditors.TextEdit();
            this.sbDelete = new DevExpress.XtraEditors.SimpleButton();
            this.sBCancel = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sBZapisz = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TEName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sBAdd
            // 
            this.sBAdd.Location = new System.Drawing.Point(12, 8);
            this.sBAdd.Name = "sBAdd";
            this.sBAdd.Size = new System.Drawing.Size(158, 23);
            this.sBAdd.TabIndex = 2;
            this.sBAdd.Text = "Dodaj Klienta";
            this.sBAdd.Click += new System.EventHandler(this.sBOperration_Click);
            // 
            // TEName
            // 
            this.TEName.Location = new System.Drawing.Point(72, 37);
            this.TEName.Name = "TEName";
            this.TEName.Size = new System.Drawing.Size(270, 20);
            this.TEName.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Nazwa";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(368, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(15, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Nip";
            // 
            // tENip
            // 
            this.tENip.Location = new System.Drawing.Point(427, 37);
            this.tENip.Name = "tENip";
            this.tENip.Size = new System.Drawing.Size(270, 20);
            this.tENip.TabIndex = 5;
            // 
            // sbDelete
            // 
            this.sbDelete.Location = new System.Drawing.Point(368, 8);
            this.sbDelete.Name = "sbDelete";
            this.sbDelete.Size = new System.Drawing.Size(158, 23);
            this.sbDelete.TabIndex = 8;
            this.sbDelete.Text = "Usuń Klienta";
            this.sbDelete.Click += new System.EventHandler(this.sbDelete_Click);
            // 
            // sBCancel
            // 
            this.sBCancel.Location = new System.Drawing.Point(193, 8);
            this.sBCancel.Name = "sBCancel";
            this.sBCancel.Size = new System.Drawing.Size(158, 23);
            this.sBCancel.TabIndex = 7;
            this.sBCancel.Text = "Anuluj";
            this.sBCancel.Click += new System.EventHandler(this.sBCancel_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.clientBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 63);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(686, 309);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Load += new System.EventHandler(this.gridControl1_Load);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(ZadanieRekrutacyjneITC.Entities.Client);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colNip});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colNip
            // 
            this.colNip.FieldName = "Nip";
            this.colNip.Name = "colNip";
            this.colNip.Visible = true;
            this.colNip.VisibleIndex = 1;
            // 
            // sBZapisz
            // 
            this.sBZapisz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sBZapisz.Location = new System.Drawing.Point(540, 8);
            this.sBZapisz.Name = "sBZapisz";
            this.sBZapisz.Size = new System.Drawing.Size(158, 23);
            this.sBZapisz.TabIndex = 10;
            this.sBZapisz.Text = "Zapisz";
            this.sBZapisz.Click += new System.EventHandler(this.sBZapisz_Click);
            // 
            // CreateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 384);
            this.Controls.Add(this.sBZapisz);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.sbDelete);
            this.Controls.Add(this.sBCancel);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tENip);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TEName);
            this.Controls.Add(this.sBAdd);
            this.Name = "CreateClient";
            this.Text = "Klienci";
            this.Load += new System.EventHandler(this.CreateClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TEName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton sBAdd;
        private DevExpress.XtraEditors.TextEdit TEName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tENip;
        private DevExpress.XtraEditors.SimpleButton sbDelete;
        private DevExpress.XtraEditors.SimpleButton sBCancel;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colNip;
        private DevExpress.XtraEditors.SimpleButton sBZapisz;
    }
}