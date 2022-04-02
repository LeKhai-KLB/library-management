using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class GuestBookForm : Form
    {
        string currentISBN = "";
        public GuestBookForm()
        {
            InitializeComponent();
        }

        private void GuestBookForm_Load(object sender, EventArgs e)
        {
            showView();
        }

        void showView()
        {
            LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
            bookDGV.DataSource = from p in db.BOOKs select new { p.ISBN, p.BookName, p.Author, p.Publisher, p.Quantity, p.Category };
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
                if (currentISBN != "")
                {
                    viewBookForm view = new viewBookForm(currentISBN);
                    view.Show();
                }
                else
                {
                    MessageBox.Show("No data to show", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (IBSNSearchTbx.Text != "ISBN...")
            {
                LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                bookDGV.DataSource = from p in db.BOOKs where SqlMethods.Like(p.ISBN, IBSNSearchTbx.Text + "%") select new { p.ISBN, p.BookName, p.Author, p.Publisher, p.Quantity, p.Category };
                resetSearch();
            }
            else
            {
                if (nameSearchTbx.Text != "Name...")
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    bookDGV.DataSource = from p in db.BOOKs where p.BookName.Contains(nameSearchTbx.Text) select new { p.ISBN, p.BookName, p.Author, p.Publisher, p.Quantity, p.Category };
                    resetSearch();
                }
                else
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    bookDGV.DataSource = from p in db.BOOKs where p.Author.Contains(authorSearchTbx.Text) select new { p.ISBN, p.BookName, p.Author, p.Publisher, p.Quantity, p.Category };
                    resetSearch();
                }
            }
        }

        void resetSearch()
        {
            IBSNSearchTbx.Text = "ISBN...";
            nameSearchTbx.Text = "Name...";
            authorSearchTbx.Text = "Author...";
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            showView();
        }

        private void bookDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                currentISBN = isbnTbx.Text = bookDGV.SelectedRows[0].Cells[0].Value.ToString();
                LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                BOOK currentBook = db.BOOKs.Where(p => p.ISBN.Equals(currentISBN)).SingleOrDefault();
                nameTbx.Text = currentBook.BookName.ToString();
                authorTbx.Text = currentBook.Author.ToString();
                publisherTbx.Text = currentBook.Publisher.ToString();
                quantityTbx.Text = currentBook.Quantity.ToString();
                categoryBox.Text = currentBook.Category.ToString();
                summaryTbx.Text = currentBook.Summary.ToString();
                errorProvider.Clear();
            }
            catch
            {
                MessageBox.Show("Something gone wrong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (Control c in this.Controls)
                {
                    if (c.GetType().ToString() == "Bunifu.Framework.UI.BunifuMaterialTextbox")
                    {
                        c.Text = "";
                    }
                }
                errorProvider.Clear();
                currentISBN = "";
            }
        }

        private void IBSNSearchTbx_Enter(object sender, EventArgs e)
        {
            if (IBSNSearchTbx.Text == "ISBN...")
            {
                IBSNSearchTbx.Text = "";
            }
        }

        private void IBSNSearchTbx_Leave(object sender, EventArgs e)
        {
            if (IBSNSearchTbx.Text == "")
            {
                IBSNSearchTbx.Text = "ISBN...";
            }
        }

        private void nameSearchTbx_Enter(object sender, EventArgs e)
        {
            if (nameSearchTbx.Text == "Name...")
            {
                nameSearchTbx.Text = "";
            }
        }

        private void nameSearchTbx_Leave(object sender, EventArgs e)
        {
            if (nameSearchTbx.Text == "")
            {
                nameSearchTbx.Text = "Name...";
            }
        }

        private void authorSearchTbx_Enter(object sender, EventArgs e)
        {
            if (authorSearchTbx.Text == "Author...")
            {
                authorSearchTbx.Text = "";
            }
        }

        private void authorSearchTbx_Leave(object sender, EventArgs e)
        {
            if (authorSearchTbx.Text == "")
            {
                authorSearchTbx.Text = "Author...";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm logf = new LoginForm();
            logf.Show();
        }
    }
}
