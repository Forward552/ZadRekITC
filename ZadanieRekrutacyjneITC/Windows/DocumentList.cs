using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
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
            Logging.Log($"Otwarto okno z listą pozycji w dokumencie ", documentID);
        }
        private void RefreshTable()
        {
            itemBindingSource.DataSource = dbContext.Items.Local.Where(x => x.DocumentId == documentID).ToList();
        }
        private void gridControl1_DockChanged(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
        }
        private void spAdd_Click(object sender, EventArgs e)
        {
            if (teName.Text == "")
            {
                XtraMessageBox.Show("Nazwa nie może być pusta!", "Brak Danych.");
                return;
            }

            //item.Document = null;
            item.DocumentId = documentID;
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
            item.Id = 0;
            dbContext.Items.Add(item);
            dbContext.SaveChanges();
            RefreshTable();
            Clear();
            Logging.Log($"Dodano Nową pozycje {item.Name} w ilości {item.Count} u klienta: {clientName} w okumencie", documentID);
        }
        private void Clear()
        {
            teName.Text = "";
            teCount.Text = "";
            tePriceNetto.Text = "";
            tePriceBrutto.Text = "";
        }
        private void sbSave_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
            Logging.Log($"Zapisano zmiany w Dokumenice", documentID);

        }

        private void sbDelete_Click(object sender, EventArgs e)
        {
            var result = XtraMessageBox.Show("Czy na pewno chcesz usunąc tego klienta?", "Usuwanie klienta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                item = (Item)itemBindingSource.Current;
                itemBindingSource.RemoveCurrent();
                Logging.Log($"Usunięto pozycje: {item.Name}");
                dbContext.Items.Remove(item);
                dbContext.SaveChanges();
                Clear();
            }
        }
    }
}