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
    public partial class Login : Form
    {
        private LibraryEntities _db;
        public Login()
        {
            _db = new LibraryEntities();
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            this.Hide();
            register.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtboxLoginEmail.Text.Trim();
            string password = txtboxLoginPassword.Text.Trim().HashPassword();

            if (email=="" || password=="")
            {
                MessageBox.Show("Please Fill All Inputs", "Warning", MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
                return;
            }
           var librarian= _db.Librarians.FirstOrDefault(l => l.Email == email && l.Password == password);

            if (librarian==null)
            {
                MessageBox.Show("Incorrect Email or Password");
                return;
            }
            if (!librarian.Confirmed)
            {
                MessageBox.Show("Please Confirm This Account");
                return;
            }
            if (librarian.Deleted)
            {
                MessageBox.Show("This Account was deleted");
                return;
            }
            if (!librarian.Email.IsMail())
            {
                MessageBox.Show("Write Email Correctly");
                return;
            }
            if (librarian.IsAdmin)
            {
                Admin admin = new Admin(this);
                this.Hide();
                admin.Show();
            }
            else
            {
                DashBoard form1 = new DashBoard(this,librarian.Id);
                form1.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtboxLoginPassword.UseSystemPasswordChar = false;

            }
            else
            {
                txtboxLoginPassword.UseSystemPasswordChar = true;

            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
