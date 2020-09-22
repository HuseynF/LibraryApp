using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Admin : Form
    {
        private LibraryEntities _db;
        private Form _login;
        public Admin(Form login)
        {
            _db = new LibraryEntities();
            _login = login;
            InitializeComponent();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            FillDgv();
        }

        private void dgvAdmin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id =int.Parse (dgvAdmin.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
            Librarian librarian = _db.Librarians.First(t => t.Id == id);
            txtboxAdmin.Text = librarian.Email;
            HideInputs();
        }

        private void HideInputs()
        {
            btnAdminConfirm.Visible = true;
            btnAdminDelete.Visible = true;
        }

        private async void btnAdminDelete_Click(object sender, EventArgs e)
        {
            string email = txtboxAdmin.Text.Trim();
            Librarian librarian=_db.Librarians.First(l => l.Email == email);
            librarian.Deleted = true;
            await _db.SaveChangesAsync();
            MessageBox.Show("Deleted");
            FillDgv();
            HideInputs();
        }

        private async void btnAdminConfirm_Click(object sender, EventArgs e)
        {
            string email = txtboxAdmin.Text.Trim();
            Librarian librarian = _db.Librarians.First(l => l.Email == email);
            librarian.Confirmed = true;
            await _db.SaveChangesAsync();
            MessageBox.Show("Confirmed");
            FillDgv();
            HideInputs();
        }
        private void FillDgv()
        {
            dgvAdmin.DataSource = "";
            dgvAdmin.DataSource = _db.Librarians.Where(l => l.Confirmed == false && l.Deleted == false)
                .Select(l => new
                {
                    l.Id,
                    l.Name,
                    l.Lastname,

                }).ToList();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }
    }
}
