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
            document = null;
            document.ClientNumber = comboBoxClient.SelectedIndex + 1;
            document.Name = comboBoxClient.Text;
            document.Title = teTitle.Text;
            dbContext.Documents.Add(document);
            dbContext.SaveChanges();
            RefreshDGV();


            using (DocumentList document = new DocumentList())
            {

                document.clientId = comboBoxClient.SelectedIndex + 1;
                document.clientName = comboBoxClient.Text;
                document.DocumentTitle = teTitle.Text;
                document.ShowDialog();
            }
        }

        private void dataGridViewDocumentList_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDocumentList.SelectedRows.Count > 0)
            {
                var doc = (Document)dataGridViewDocumentList.SelectedRows[0].DataBoundItem;
                comboBoxClient.SelectedIndex = doc.ClientNumber; 
                teTitle.Text = doc.Name;
                document = doc;
            }
        }
    }
}