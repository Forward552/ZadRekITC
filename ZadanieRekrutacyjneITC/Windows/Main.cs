using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZadanieRekrutacyjneITC.Windows;

namespace ZadanieRekrutacyjneITC
{
    public partial class MainView : DevExpress.XtraEditors.XtraForm
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void sBClients_Click(object sender, EventArgs e)
        {
            using (CreateClient createClient = new CreateClient())
            {
                createClient.ShowDialog();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (CreateDocument createDocument = new CreateDocument())
            {
                createDocument.ShowDialog();
            }
        }
    }
}
