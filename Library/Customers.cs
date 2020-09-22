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
    public partial class Customers : Form
    {
        private LibraryEntities _db;
        public Customers()
        {
            _db = new LibraryEntities();
            InitializeComponent();
        }

        private async void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string name = txtCustomerAddName.Text.Trim();
            string lastname = txtCustomerAddLastName.Text.Trim();
            string phone = txtCustomerAddPhone.Text.Trim();
            string email = txtCustomerAddEmail.Text.Trim();

            if (name=="" ||lastname=="" ||phone=="" ||email=="")
            {
                MessageBox.Show("Please Fill All Inputs", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!email.IsMail())
            {
                MessageBox.Show("Write Email Address Correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Customer customer = new Customer() { Name = name, Lastname = lastname, Phone = phone, Email = email };
            _db.Customers.Add(customer);
            await _db.SaveChangesAsync();
            MessageBox.Show("Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FillCmb(cmbUpdateCustomer);
            FillCmb(cmbDeleteCustomer);
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            FillCmb(cmbDeleteCustomer);
            FillCmb(cmbUpdateCustomer);
        }

        private void FillCmb(ComboBox cmb)
        {
            cmb.Text = "";
            cmb.Items.Clear();
            cmb.Items.AddRange(_db.Customers.Where(c => c.Deleted == false).Select(c => new CB_Customer
            {
                Name = c.Name,
                Id = c.Id,
                Lastname = c.Lastname
            }).ToArray());
        }

        private async void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int id = ((CB_Customer)cmbDeleteCustomer.SelectedItem).Id;
            Customer customer = _db.Customers.First(c => c.Deleted == false && c.Id == id);
            customer.Deleted = true;
            await _db.SaveChangesAsync();
            MessageBox.Show("Deleted");
            FillCmb(cmbDeleteCustomer);
        }

        private async void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string name = txtCustomerUpdateName.Text.Trim();
            string lastname =txtCustomerUpdateLastName.Text.Trim();
            string phone = txtCustomerUpdatePhone.Text.Trim();
            string email = txtCustomerUpdateEmail.Text.Trim();

            if (name == "" || lastname == "" || phone == "" || email == "")
            {
                MessageBox.Show("Please Fill All Inputs", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!email.IsMail())
            {
                MessageBox.Show("Write Email Address Correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = ((CB_Customer)cmbUpdateCustomer.SelectedItem).Id;
            Customer selected_customer = _db.Customers.First(c => c.Id == id);
            selected_customer.Deleted = true;
            Customer updated_customer = new Customer() { Name = name, Lastname = lastname, Phone = phone, Email = email };

            _db.Customers.Add(updated_customer);
            await _db.SaveChangesAsync();
            MessageBox.Show("Updated");

            FillCmb(cmbDeleteCustomer);
        }

        private void cmbUpdateCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((CB_Customer)cmbUpdateCustomer.SelectedItem).Id;
            Customer customer = _db.Customers.First(c => c.Id == id);
            txtCustomerUpdateName.Text = customer.Name;
            txtCustomerUpdateEmail.Text = customer.Email;
            txtCustomerUpdateLastName.Text = customer.Lastname;
            txtCustomerUpdatePhone.Text = customer.Phone;
        }
    }
}
