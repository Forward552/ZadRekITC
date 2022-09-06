using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieRekrutacyjneITC.Windows
{
    public partial class Document : DevExpress.XtraEditors.XtraForm
    {
        public int clientId;
        public string clientName;
        public Document()
        {
            InitializeComponent();
        }
    }
}