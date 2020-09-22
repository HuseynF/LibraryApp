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
    public partial class DashBoard : Form
    {
        private LibraryEntities _db;
        private Form _login;
        private int _userid;
        public DashBoard(Form login, int userid)
        {
            _userid = userid;
            _login = login;
            _db = new LibraryEntities();
            InitializeComponent();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            cmbDashboardCustomers.Items.AddRange(_db.Customers.Where(c => c.Deleted == false).Select(c => new CB_Customer
            {
                Name = c.Name,
                Lastname = c.Lastname,
                Id = c.Id
            }).ToArray());
            cmbDashBoardBooks.Items.AddRange(_db.Books.Where(b => b.Deleted == false).Select(b => new CB_Books
            {
                Name = b.Name,
                Id = b.Id,
                GenreId = b.GenreId,
                Price = b.Price
            }).ToArray());
            FillCmbReturnCustomer();
        }
        private void FillCmbReturnCustomer()
        {
            cmbDashBoardReturnCustomer.Items.AddRange(_db.Rents.Where(r => r.Status == false && r.Overdue == false)
             .Select(r => new CB_Rent
             {
                 CustomerName = r.CustomerName,
                 CustomerLastName = r.CustomerLastName,
                 Id = r.Id,
                 BookName = r.BookName,
                 ReturnDate = r.Returndate,
                 PickUpDate = r.Date,
                 Status = r.Status,
                 Overdue = r.Overdue,
                 Count = r.Count,
                 Price = r.Price
             }).ToArray());
        }
        private async void btnDashBoardRent_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Info",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                DateTime date = DateTime.Today;
                int selected_customerid = ((CB_Customer)cmbDashboardCustomers.SelectedItem).Id;
                int selected_bookid = ((CB_Books)cmbDashBoardBooks.SelectedItem).Id;
                DateTime return_date = DateTime.Parse(txtDashBoardReturn.Text.ToString());
                int selected_count = int.Parse(numDashBoardCount.Value.ToString());
                string selected_customerName = ((CB_Customer)cmbDashboardCustomers.SelectedItem).Name;
                string selected_customerLastName = ((CB_Customer)cmbDashboardCustomers.SelectedItem).Lastname;
                decimal selected_bookPrice = ((CB_Books)cmbDashBoardBooks.SelectedItem).Price;
                string selected_bookName = ((CB_Books)cmbDashBoardBooks.SelectedItem).Name;

                Rent rent = new Rent()
                {
                    Count = selected_count,
                    BookId = selected_bookid,
                    CustomerId = selected_customerid,
                    Returndate = return_date,
                    Date = date,
                    LibrarianId = _userid,
                    CustomerName = selected_customerName,
                    CustomerLastName = selected_customerLastName,
                    Price = selected_bookPrice,
                    BookName = selected_bookName
                };

                _db.Rents.Add(rent);
                await _db.SaveChangesAsync();
                MessageBox.Show("Successfully Rented");
                FillCmbReturnCustomer();
            }
        }

        private void cmbDashBoardReturnCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((CB_Rent)cmbDashBoardReturnCustomer.SelectedItem).Id;
            string name = ((CB_Rent)cmbDashBoardReturnCustomer.SelectedItem).CustomerName;
            string lastname = ((CB_Rent)cmbDashBoardReturnCustomer.SelectedItem).CustomerLastName;
            string bookname = ((CB_Rent)cmbDashBoardReturnCustomer.SelectedItem).BookName;
            decimal price = ((CB_Rent)cmbDashBoardReturnCustomer.SelectedItem).Price;
            int count = ((CB_Rent)cmbDashBoardReturnCustomer.SelectedItem).Count;
            DateTime pickupdate = ((CB_Rent)cmbDashBoardReturnCustomer.SelectedItem).PickUpDate;
            DateTime returndate = ((CB_Rent)cmbDashBoardReturnCustomer.SelectedItem).ReturnDate;
            bool status = ((CB_Rent)cmbDashBoardReturnCustomer.SelectedItem).Status;
            bool overdue = ((CB_Rent)cmbDashBoardReturnCustomer.SelectedItem).Overdue;
            

            lsbDashBoardReturnCustomerInfo.Items.Add(new LS_Rent
            {
                CustomerId = id,
                CustomerName = name,
                CustomerLastName = lastname,
                BookName = bookname,
                Count = count,
                Price = price,
                ReturnDate = returndate,
                PickUpDate = pickupdate,
                Status=status,
                Overdue=overdue
            }).ToString();

            lsbDashBoardReturnCustomerInfo.Items.Clear();
            lsbDashBoardReturnCustomerInfo.Items.Add(new LS_Rent
            {
                CustomerId = id,
                CustomerName = name,
                CustomerLastName = lastname,
                BookName = bookname,
                Count = count,
                Price = price,
                ReturnDate = returndate,
                PickUpDate = pickupdate,
                Status = status,
                Overdue = overdue
            }).ToString();
            FillCmbReturnCustomer();
        }

        private async void btnDashBoardShow_Click(object sender, EventArgs e)
        {
            DateTime returndate = ((CB_Rent)cmbDashBoardReturnCustomer.SelectedItem).ReturnDate;
            DateTime today = DateTime.Now;
            if (today > returndate)
            {
                decimal price_penalty = ((CB_Rent)cmbDashBoardReturnCustomer.SelectedItem).Price;
                int compare = DateTime.Compare(today, returndate);
                decimal percent = (decimal)0.005;
                decimal penalty = price_penalty * percent * compare;
                txtPenalty.Text = penalty.ToString();
            }
            int id = ((CB_Rent)cmbDashBoardReturnCustomer.SelectedItem).Id;
            Rent overdue = _db.Rents.First(r => r.Id == id && r.Overdue == false);
            overdue.Overdue = true;
            overdue.Penalty = decimal.Parse(txtPenalty.Text);
            await _db.SaveChangesAsync();
            MessageBox.Show("Penalty Calculated");
        }

        private async void btnDashBoardReturn_Click(object sender, EventArgs e)
        {
            int id = ((CB_Rent)cmbDashBoardReturnCustomer.SelectedItem).Id;
            Rent rent = _db.Rents.First(r => r.Status == false && r.Id == id);
            rent.Status = true;
            await _db.SaveChangesAsync();
            MessageBox.Show("Returned");
            FillCmbReturnCustomer();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status status = new Status();
            status.Show();
        }
    }
    }