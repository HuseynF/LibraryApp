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
    public partial class Report : Form
    {
        private LibraryEntities _db;
        public Report()
        {
            _db = new LibraryEntities();
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            cmbReportCustomer.Items.AddRange(_db.Rents.Where(r => r.Overdue == true)
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

        private async void btnShowReport_Click(object sender, EventArgs e)
        {
           
        }
    }
}
