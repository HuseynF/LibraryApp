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
    public partial class Books : Form
    {
        private LibraryEntities _db;
        public Books()
        {
            _db = new LibraryEntities();
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            txtAddGenre.Text = "";
            cmbAddBookGenre.Items.Clear();
            cmbAddBookGenre.Items.AddRange(_db.Genres.Select(g => new CB_Genre
            {
                Name = g.Name,
                Id = g.Id

            }).ToArray());

            cmbBooksGenre.Items.Clear();
            cmbBooksGenre.Items.AddRange(_db.Genres.Select(g => new CB_Genre
            {
                Id = g.Id,
                Name = g.Name
            }).ToArray());
            

            cmbBooksUpdate.Items.AddRange(_db.Books.Select(b => new CB_Books
            {
                Id = b.Id,
                Name = b.Name,
                GenreId = b.GenreId
               }).ToArray());

            cmbAddBookAuthor.Items.AddRange(_db.Authors.Select(a => new CB_Authors {
                Name = a.Name, Lastname = a.Lastname, Id = a.Id }
            ).ToArray());

            
        }

        private void cmbBooksGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((CB_Genre)cmbBooksGenre.SelectedItem).Id;
            FillCmb(id);
        }

        private void FillCmb(int id)
        {
            cmbBooks.Text = "";
            cmbBooks.Items.Clear();
            cmbBooks.Items.AddRange(_db.Books.Where(b => b.GenreId == id &&b.Deleted==false)
                .Select(b => new CB_Books
            {
                Name = b.Name,
                Id = id,
                GenreId = b.GenreId
            }).ToArray());
        }

        private async void btnBooksDelete_Click(object sender, EventArgs e)
        {
            int id = ((CB_Genre)cmbBooksGenre.SelectedItem).Id;
            var book= _db.Books.FirstOrDefault(b => b.Deleted == false && b.GenreId == id);
            book.Deleted = true;

           await _db.SaveChangesAsync();
           MessageBox.Show("Deleted","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private async void btnBooksAdd_Click(object sender, EventArgs e)
        {
            string name = txtBooksName.Text.Trim();
            int? year = int.Parse(txtBooksYear.Text.Trim());
            int? pagecount = int.Parse(txtBooksPage.Text.Trim());
            int price = int.Parse(txtBooksPrice.Text.Trim());
            int count =int.Parse(numBooksCount.Value.ToString());
            int id = ((CB_Genre)cmbAddBookGenre.SelectedItem).Id;
            int authorid = ((CB_Authors)cmbAddBookAuthor.SelectedItem).Id;

            if (name=="")
            {
                MessageBox.Show("Please Fill All Inputs", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (_db.Books.Any(b=>b.Name==name))
            {
                MessageBox.Show("This Book Already Exists", "Warning", MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                return;
            }
            Book book = new Book() { Name = name, Year = year, Pagecount = pagecount, Price = price
                ,Count=count,GenreId=id,AuthorId=authorid };
           _db.Books.Add(book);
           await _db.SaveChangesAsync();
            MessageBox.Show("Successfully Added", "Success", MessageBoxButtons.OK
               , MessageBoxIcon.Information);

            cmbBooksUpdate.Items.Clear();
            cmbBooksUpdate.Items.AddRange(_db.Books.Select(b => new CB_Books
            {
                Id = b.Id,
                Name = b.Name,
                GenreId = b.GenreId
            }).ToArray());
        }

        private void cmbBooksUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((CB_Books)cmbBooksUpdate.SelectedItem).Id;
            var book = _db.Books.FirstOrDefault(b => b.Id == id);
            txtUpdateBookName.Text = book.Name;
            txtUpdateBookPage.Text =book.Pagecount.ToString();
            txtUpdateBookPrice.Text = book.Price.ToString();
            txtUpdateBookYear.Text = book.Year.ToString();
            numUpdateBookCount.Value = decimal.Parse(book.Count.ToString());

         }

        private async void btnBooksUpdate_Click(object sender, EventArgs e)
        {
            string name = txtUpdateBookName.Text.Trim();
            int? year = int.Parse(txtUpdateBookYear.Text.Trim());
            int? pagecount = int.Parse(txtUpdateBookPage.Text.Trim());
            decimal price = decimal.Parse(txtUpdateBookPrice.Text.Trim());
            int count = int.Parse(numUpdateBookCount.Value.ToString());


            int id = ((CB_Books)cmbBooksUpdate.SelectedItem).Id;
            Book book = _db.Books.First(b => b.Id == id);
            book.Deleted = true;
            Book updated_book = new Book()
            {
                Name = name,
                Year = year,
                Pagecount = pagecount,
                Price = price,
                Count = count
            };
            _db.Books.Add(updated_book);
            await _db.SaveChangesAsync();
            MessageBox.Show("Updated");

        }

        private async void btnAddGenre_Click(object sender, EventArgs e)
        {
            string genre = txtAddGenre.Text.Trim();
            if (genre=="")
            {
                MessageBox.Show("Please fill input");
                return;
            }
            Genre newgenre = new Genre() { Name = genre };
            _db.Genres.Add(newgenre);
            await _db.SaveChangesAsync();
            MessageBox.Show("Successfully Added");

            txtAddGenre.Text = "";
            cmbAddBookGenre.Items.Clear();
            cmbAddBookGenre.Items.AddRange(_db.Genres.Select(g => new CB_Genre
            {
                Name = g.Name,
                Id = g.Id

            }).ToArray());

            cmbBooksGenre.Items.Clear();
            cmbBooksGenre.Items.AddRange(_db.Genres.Select(g => new CB_Genre
            {
                Id = g.Id,
                Name = g.Name
            }).ToArray());
        }

        private async void btnAddAuthor_Click(object sender, EventArgs e)
        {
            string name = txtAddAuthorName.Text.Trim();
            string lastname = txtAddAuthorLastName.Text.Trim();

            if (name=="" || lastname=="")
            {
                MessageBox.Show("Please Fill All Inputs");
                return;
            }
            if (_db.Authors.Any(a=>a.Name==name && a.Lastname==lastname))
            {
                MessageBox.Show("This Author Already Exists");
                return;
            }
            Author author = new Author() { Name = name, Lastname = lastname };
            _db.Authors.Add(author);
            await _db.SaveChangesAsync();
            MessageBox.Show("Successfully Added");

            cmbAddBookAuthor.Items.Clear();
            cmbAddBookAuthor.Items.AddRange(_db.Authors.Select(a => new CB_Authors
            {
                Name = a.Name,
                Lastname = a.Lastname,
                Id = a.Id
            }
           ).ToArray());
        }
    }
}
