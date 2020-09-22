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
    public partial class Status : Form
    {
        private LibraryEntities _db;
        public Status()
        {
            _db = new LibraryEntities();
            InitializeComponent();
        }

        private void Status_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            cmbStatusToday.Items.AddRange(_db.Rents.Where(r => r.Overdue == true && r.Returndate==today)
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

          
            DateTime tomorrow = DateTime.Today.AddDays(1);
            cmbStatusTomorrow.Items.AddRange(_db.Rents.Where(r => r.Overdue == true && r.Returndate == tomorrow)
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

            DateTime late = DateTime.Today.AddDays(-1);
           
            cmbStatusLate.Items.AddRange(_db.Rents.Where(r => r.Overdue == true &&  r.Returndate < late)
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

        private void cmbStatusToday_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((CB_Rent)cmbStatusToday.SelectedItem).Id;
            string name = ((CB_Rent)cmbStatusToday.SelectedItem).CustomerName;
            string lastname = ((CB_Rent)cmbStatusToday.SelectedItem).CustomerLastName;
            string bookname = ((CB_Rent)cmbStatusToday.SelectedItem).BookName;
            int count = ((CB_Rent)cmbStatusToday.SelectedItem).Count;
            decimal price = ((CB_Rent)cmbStatusToday.SelectedItem).Price;
            DateTime returndate = ((CB_Rent)cmbStatusToday.SelectedItem).ReturnDate;
            DateTime pickupdate = ((CB_Rent)cmbStatusToday.SelectedItem).PickUpDate;
            bool status = ((CB_Rent)cmbStatusToday.SelectedItem).Status;
            bool overdue = ((CB_Rent)cmbStatusToday.SelectedItem).Overdue;
            lsbStatusToday.Items.Add(new LS_Status
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
        }

        private void cmbStatusTomorrow_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((CB_Rent)cmbStatusTomorrow.SelectedItem).Id;
            string name = ((CB_Rent)cmbStatusTomorrow.SelectedItem).CustomerName;
            string lastname = ((CB_Rent)cmbStatusTomorrow.SelectedItem).CustomerLastName;
            string bookname = ((CB_Rent)cmbStatusTomorrow.SelectedItem).BookName;
            int count = ((CB_Rent)cmbStatusTomorrow.SelectedItem).Count;
            decimal price = ((CB_Rent)cmbStatusTomorrow.SelectedItem).Price;
            DateTime returndate = ((CB_Rent)cmbStatusTomorrow.SelectedItem).ReturnDate;
            DateTime pickupdate = ((CB_Rent)cmbStatusTomorrow.SelectedItem).PickUpDate;
            bool status = ((CB_Rent)cmbStatusTomorrow.SelectedItem).Status;
            bool overdue = ((CB_Rent)cmbStatusTomorrow.SelectedItem).Overdue;

            lsbStatusTomorrow.Items.Add(new LS_Status
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
        }

        private void cmbStatusLate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((CB_Rent)cmbStatusLate.SelectedItem).Id;
            string name = ((CB_Rent)cmbStatusLate.SelectedItem).CustomerName;
            string lastname = ((CB_Rent)cmbStatusLate.SelectedItem).CustomerLastName;
            string bookname = ((CB_Rent)cmbStatusLate.SelectedItem).BookName;
            int count = ((CB_Rent)cmbStatusLate.SelectedItem).Count;
            decimal price = ((CB_Rent)cmbStatusLate.SelectedItem).Price;
            DateTime returndate = ((CB_Rent)cmbStatusLate.SelectedItem).ReturnDate;
            DateTime pickupdate = ((CB_Rent)cmbStatusLate.SelectedItem).PickUpDate;
            bool status = ((CB_Rent)cmbStatusLate.SelectedItem).Status;
            bool overdue = ((CB_Rent)cmbStatusLate.SelectedItem).Overdue;

            lsbStatusLate.Items.Add(new LS_Status
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
        }
    }
}
