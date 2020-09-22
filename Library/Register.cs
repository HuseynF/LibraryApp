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
    public partial class Register : Form
    {
        private LibraryEntities _db;
        private Form _login;
        public Register(Form login)
        {
            _db = new LibraryEntities();
            _login = login;
            InitializeComponent();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Show();
        }

        private async void btnRegistration_Click(object sender, EventArgs e)
        {
            string name = txtRegisterName.Text.Trim();
            string surname = txtRegisterSurname.Text.Trim();
            string email = txtRegisterEmail.Text.Trim();
            string password = txtRegisterPassword.Text.Trim();

            if (name=="" || password=="" || surname=="" || email=="")
            {
                MessageBox.Show("Please Fill All Inputs", "Warning", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }
            if (_db.Librarians.Any(l =>l.Email==email))
            {
                MessageBox.Show("This Email Address Already Exists", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
                return;
            }
            if (!email.IsMail())
            {
                MessageBox.Show("Please Write Email Address Correctly", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string passHash = password.HashPassword();
            Librarian librarian = new Librarian
            {
                Name = name,
                Lastname = surname,
                Email = email,
                Password = passHash
            };
            _db.Librarians.Add(librarian);
            await _db.SaveChangesAsync();
            MessageBox.Show("Succesfully Saved","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
