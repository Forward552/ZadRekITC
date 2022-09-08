using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;
using ZadanieRekrutacyjneITC.Entities;

namespace ZadanieRekrutacyjneITC.Windows
{
    public partial class CreateDocument : DevExpress.XtraEditors.XtraForm
    {
        private DataBaseContext dbContext = new DataBaseContext();
        private Document document = new Document();

        public CreateDocument()
        {
            InitializeComponent();
        }
        private void CreateDocument_Load(object sender, EventArgs e)
        {
            //dbContext.Documents.Load();
            comboBoxClient.DataSource = dbContext.Clients.ToList();
            comboBoxClient.DisplayMember = "Name";
            RefreshTable();
            Logging.Log("Otwarto okno z dokumentami");
        }

        private void RefreshTable()
        {
            dataGridViewDocumentList.DataSource = dbContext.Documents.ToList();
        }

        private void sbAdd_Click(object sender, EventArgs e)
        {
            if (teTitle.Text == "")
            {
                XtraMessageBox.Show("Brak tytułu dokumentu");
                return;
            }
            document = new Document();
            document.ClientNumber = comboBoxClient.SelectedIndex + 1;
            document.Name = comboBoxClient.Text;
            document.Title = teTitle.Text;
            document.CreateDate = DateTime.Now;
            dbContext.Documents.Add(document);
            dbContext.SaveChanges();
            RefreshTable();
            using (DocumentList doc = new DocumentList())
            {
                var tmp = dbContext.Documents.Local.Last();
                doc.documentID = tmp.Id;
                doc.createData = document.CreateDate.ToString();
                doc.clientId = comboBoxClient.SelectedIndex + 1;
                doc.clientName = comboBoxClient.Text;
                doc.DocumentTitle = teTitle.Text;
                doc.ReadDocument = document;
                Logging.Log($"Dodano nowy dokument u klienta {doc.clientName}", tmp.Id);
                doc.ShowDialog();
            }
        }

        private void dataGridViewDocumentList_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDocumentList.SelectedRows.Count > 0)
            {
                var selected = (Document)dataGridViewDocumentList.SelectedRows[0].DataBoundItem;
                document = selected;
            if (document.ClientNumber < 1)
            {
                XtraMessageBox.Show("Krytyczny bład wybrano dokument bez przypisanego klienta!");
                return;
                //throw new Exception("Wybrano dokument bez przypisanego klienta!");
            }
                switch (cbDelete.Checked)
                {
                    case true:
                        var result = XtraMessageBox.Show($"Czy na pewno chcesz usunąć dokument:{document.Title}", "Kasowanie Dokumentu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Logging.Log($"Usunięto dokument Klienta{document.Name}", document.Id);
                            dbContext.Documents.Remove(document);
                            dbContext.SaveChanges();
                            cbDelete.Checked = false;
                            RefreshTable();
                        }
                        break;

                    case false:
                        using (DocumentList doc = new DocumentList())
                        {
                            doc.ReadDocument = document;
                            doc.documentID = document.Id;
                            doc.createData = document.CreateDate.ToString();
                            doc.clientId = document.ClientNumber;
                            doc.clientName = document.Name;
                            doc.DocumentTitle = document.Title;
                            Logging.Log($"Przeglądanie Dokumentu Klienta {document.Name}", document.Id);

                            doc.ShowDialog();
                        }
                        break;
                }
            }
        }

        private void sbSave_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
            Logging.Log("Edytowano Dokumenty!");
        }
    }
}