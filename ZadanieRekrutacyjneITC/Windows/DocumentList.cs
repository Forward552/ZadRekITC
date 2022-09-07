using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZadanieRekrutacyjneITC.Entities;

namespace ZadanieRekrutacyjneITC.Windows
{
    public partial class DocumentList : DevExpress.XtraEditors.XtraForm
    {
        public int clientId;
        public string clientName;
        public string DocumentTitle;
        public string createData;
        public int documentID;
        private DataBaseContext dbContext = new DataBaseContext();
        private Item item = new Item();
        public Document ReadDocument;

        public DocumentList()
        {
            InitializeComponent();
        }

        private void DocumentList_Load(object sender, EventArgs e)
        {
            laTitle.Text = DocumentTitle;
            laNumberClient.Text = clientId.ToString();
            laClientName.Text = clientName.ToString();
            laCreateDate.Text = createData;

            dbContext.Items.Load();
            RefreshTable();
        }

        private void RefreshTable()
        {
            itemBindingSource.DataSource = dbContext.Items.Local.Where(x => x.Document == ReadDocument).ToList();
        }

        private void gridControl1_DockChanged(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
        }

        private void gridControl1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void spAdd_Click(object sender, EventArgs e)
        {
            if (teName.Text == "")
            {
                XtraMessageBox.Show("Nazwa nie może być pusta!", "Brak Danych.");
                return;
            }

            item.Document = ReadDocument;
            item.Name = teName.Text;
            if (decimal.TryParse(teCount.Text, out decimal count))
            {
                item.Count = count;
            }
            else item.Count = 0;
            if (decimal.TryParse(tePriceNetto.Text, out decimal priceN))
            {
                item.PriceN = priceN;
            }
            else item.PriceN = 0;
            if (decimal.TryParse(tePriceBrutto.Text, out decimal priceB))
            {
                item.PriceB = priceB;
            }
            else item.PriceB = 0;
            dbContext.Items.Add(item);
            dbContext.SaveChanges();
            RefreshTable();
            Clear();
        }

        private void Clear()
        {
            teName.Text = "";
            teCount.Text = "";
            tePriceNetto.Text = "";
            tePriceBrutto.Text = "";
        }

    }
}