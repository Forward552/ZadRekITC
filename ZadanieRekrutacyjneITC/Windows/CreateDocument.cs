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
            dbContext.Documents.Load();
            comboBoxClient.DataSource = dbContext.Clients.ToList();
            comboBoxClient.DisplayMember = "Name";
            RefreshDGV();

        }

        private void RefreshDGV()
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
            RefreshDGV();


            using (DocumentList doc = new DocumentList())
            {

                var tmp = dbContext.Documents.Local.Last();
                doc.documentID = tmp.Id;
                doc.createData = document.CreateDate.ToString();
                doc.clientId = comboBoxClient.SelectedIndex + 1;
                doc.clientName = comboBoxClient.Text;
                doc.DocumentTitle = teTitle.Text;
                doc.ReadDocument = document;
                doc.ShowDialog();
            }
        }

        private void dataGridViewDocumentList_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDocumentList.SelectedRows.Count > 0)
            {
               
                var selected = (Document)dataGridViewDocumentList.SelectedRows[0].DataBoundItem;
                //comboBoxClient.SelectedIndex = selected.ClientNumber; 
                //teTitle.Text = selected.Name;
                document = selected;
                if (document.ClientNumber == 0 )
                {
                    XtraMessageBox.Show("Krytyczny bład wybrano dokument bez przypisanego klienta!");
                    return;
                }
                using (DocumentList doc = new DocumentList())
                {
                    doc.ReadDocument = document;
                    doc.documentID = document.ClientNumber;
                    doc.createData = document.CreateDate.ToString();
                    doc.clientId = document.ClientNumber;
                    doc.clientName = document.Name;
                    doc.DocumentTitle = document.Title;
                    doc.ShowDialog();
                }
            }
        }
    }
}