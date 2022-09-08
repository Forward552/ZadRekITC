using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ZadanieRekrutacyjneITC.Entities;
using Microsoft.EntityFrameworkCore;

namespace ZadanieRekrutacyjneITC.Windows
{
    public partial class CreateClient : DevExpress.XtraEditors.XtraForm
    {

        private DataBaseContext dbContext = new DataBaseContext();
        private Client client = new Client();
        public CreateClient()
        {
            InitializeComponent();
        }
        private void sBAdd_Click(object sender, EventArgs e)
        {
            if (TEName.Text == "")
            {
                XtraMessageBox.Show("Nazwa nie może być pusta!", "Brak Danych.");
                return;
            }
            client.Name = TEName.Text;
            client.Nip = tENip.Text.Trim();
            using (DataBaseContext db = new DataBaseContext())
            {
                db.Clients.Add(client);
                db.SaveChanges();
                Logging.Log($"Dodano Nowego Klienta: {client.Name}");
            }
            MessageBox.Show($"Dodano klienta: {client.Name}", "Dodano", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gridControl1.Refresh();
            Clear();
        }
        private void sbDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz usunąc tego klienta?", "Usuwanie klienta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                client = (Client)clientBindingSource.Current;
                clientBindingSource.RemoveCurrent();
                Logging.Log($"Usunięto Klienta: {client.Name}");
                dbContext.Clients.Remove(client);
                dbContext.SaveChanges();
                Clear();
            }
        }
        private void Clear()
        {
            TEName.Text = "";
            tENip.Text = "";
            sbDelete.Enabled = false;
            //client.Id = 0;
        }
        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            sbDelete.Enabled = true;
        }
        private void CreateClient_Load(object sender, EventArgs e)
        {
            Logging.Log($"Otwarto okno do edycji klientów");
            dbContext.Clients.Load();
            RefreshTab();
        }
        private void RefreshTab()
        {
            clientBindingSource.DataSource = dbContext.Clients.Local.ToList();
        }
        private void sBCancel_Click(object sender, EventArgs e)
        {
            var changed = dbContext.ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged).ToList();
            foreach (var entry in changed)
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.CurrentValues.SetValues(entry.OriginalValues);
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Unchanged;
                        break;
                }
            }
            clientBindingSource.ResetBindings(false);
            Clear();
            Logging.Log($"Anulowano wprowadzanie zmian w klientach");
        }
        private void gridControl1_Load(object sender, EventArgs e)
        {
            sbDelete.Enabled = false;

        }
        private void sBZapisz_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
            Logging.Log($"Zapisano zmiany w klientach");
        }
    }
}