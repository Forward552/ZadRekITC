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
        private DataBaseContext dbContext = new DataBaseContext();

        public DocumentList()
        {
            InitializeComponent();
        }

        private void DocumentList_Load(object sender, EventArgs e)
        {
            laTitle.Text = DocumentTitle;


            dbContext.Items.Load();
            itemBindingSource.DataSource = dbContext.Items.Local.Where(x => x.DocumentId == clientId).ToList();

        }
    }
}