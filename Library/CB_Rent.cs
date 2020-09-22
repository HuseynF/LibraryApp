using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class CB_Rent
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerLastName { get; set; }

        public string BookName { get; set; }

        public bool Status { get; set; }

        public bool Overdue { get; set; }

        public DateTime PickUpDate { get; set; }

        public int Count { get; set; }

        public decimal Price { get; set; }

        public DateTime ReturnDate { get; set; }

        public int? BookId { get; set; }
        public override string ToString()
        {
            return CustomerName + " " + CustomerLastName;
        }
    }
}
