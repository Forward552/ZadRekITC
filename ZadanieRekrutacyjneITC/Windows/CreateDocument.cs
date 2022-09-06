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
        private DataBaseContext dbcontex = new DataBaseContext();


        public CreateDocument()
        {
            InitializeComponent();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateDocument_Load(object sender, EventArgs e)
        {
            Client client = new Client();
            dbcontex.Clients.Load();
            comboBoxClient.DataSource = dbcontex.Clients.ToList();
            comboBoxClient.DisplayMember = "Name";

        }

        private void sbAdd_Click(object sender, EventArgs e)
        {
            using (Document document = new Document())
            {
                document.clientId = comboBoxClient.SelectedIndex + 1;
                document.clientName = comboBoxClient.Text;
                document.ShowDialog();
            }
        }
    }
}