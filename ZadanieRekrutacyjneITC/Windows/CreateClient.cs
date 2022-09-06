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
            /*DataBaseContext dbContext = new DataBaseContext();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Clients.LoadAsync().ContinueWith(loadTask =>
            {
                    gridControlClients.DataSource = dbContext.Clients.Local.ToBindingList();
            }, TaskScheduler.FromCurrentSynchronizationContext());
            //Refresh();*/
        }



        private void sBOperration_Click(object sender, EventArgs e)
        {
            if (TEName.Text == "") 
            {
            XtraMessageBox.Show("Nazwa nie może być pusta!","Brak Danych.");
                return;
            }
            client.Name = TEName.Text;
            client.Nip = tENip.Text.Trim();
            using(DataBaseContext db = new DataBaseContext())
            {
                db.Clients.Add(client);
                db.SaveChanges();
            }
            MessageBox.Show($"Dodano klienta: {client.Name}", "Dodano",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Clear();
        }
        private void gridControlClients_Enter(object sender, EventArgs e)
        {
            //using (DataBaseContext db = new DataBaseContext())
            //{
               // client = gridControlClients.;
                //db.Clients.Update(client);
                //db.SaveChanges();
            //}
        }
        private void sbDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz usunąc tego klienta?", "Usuwanie klienta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                clientBindingSource.RemoveCurrent();
                Clear();
            }

        }
        private void Clear()
        {
            TEName.Text = "";
            tENip.Text = "";
            sbDelete.Enabled = false;
            sBAdd.Text = "Dodaj Klienta";
            //client.Id = 0;
        }
        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            sbDelete.Enabled = true;
        }
        private void CreateClient_Load(object sender, EventArgs e)
        {
            dbContext.Clients.Load();
            clientBindingSource.DataSource = dbContext.Clients.Local.ToList();
        }
        private void sBCancel_Click(object sender, EventArgs e)
        {
            var changed = dbContext.ChangeTracker.Entries().Where(x=>x.State!=EntityState.Unchanged).ToList();  
            foreach(var entry in changed)
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
                        entry.State= EntityState.Unchanged;
                        break;
                }
            }
            clientBindingSource.ResetBindings(false);
            Clear();
        }
        private void gridControl1_Load(object sender, EventArgs e)
        {
            sbDelete.Enabled = false;

        }
        private void sBZapisz_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
        }
    }



}