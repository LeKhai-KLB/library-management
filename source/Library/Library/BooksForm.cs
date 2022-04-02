using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class BooksForm : Form
    {
        string currentISBN = "";
        public BooksForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool validatingTextBox()
        {
            bool check = true;
            if (isbnTbx.Text.Length == 0)
            {
                errorProvider.SetError(isbnTbx, "does not empty");
                check = false;
            }
            else
            {
                if (!isbnTbx.Text.All(char.IsDigit) || isbnTbx.Text.Length != 13)
                {
                    errorProvider.SetError(isbnTbx, "incorrect ISBN format");
                    check = false;
                }
            }
            if (nameTbx.Text.Length == 0)
            {
                errorProvider.SetError(nameTbx, "does not empty");
                check = false;
            }
            if (authorTbx.Text.Length == 0)
            {
                errorProvider.SetError(authorTbx, "does not empty");
                check = false;
            }
            if (publisherTbx.Text.Length == 0)
            {
                errorProvider.SetError(publisherTbx, "does not empty");
                check = false;
            }
            if (quantityTbx.Text.Length == 0)
            {
                errorProvider.SetError(quantityTbx, "does not empty");
                check = false;
            }
            else
            {
                if (!quantityTbx.Text.All(char.IsDigit) || Convert.ToInt32(quantityTbx.Text) < 1)
                {
                    errorProvider.SetError(isbnTbx, "quantity must be number and bigger 1");
                    check = false;
                }
            }
            if (summaryTbx.Text.Length == 0)
            {
                errorProvider.SetError(summaryTbx, "does not empty");
                check = false;
            }
            if (categoryBox.Text.Length == 0)
            {
                errorProvider.SetError(categoryBox, "does not empty");
                check = false;
            }
            return check;
        }

        void showView()
        {
            LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
            bookDGV.DataSource = from p in db.BOOKs select new { p.ISBN, p.BookName, p.Author, p.Publisher, p.Quantity, p.Category };
        }

        void showCategory()
        {
            LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
            var categoryList = (from p in db.CATEGORies select p).ToList();
            foreach(var c in categoryList)
            {
                categoryBox.Items.Add(c.Title.ToString());
            }
            if(categoryBox.Items.Count != 0)
            {
                categoryBox.SelectedItem = categoryBox.Items[0];
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            addCategory();
        }

        void addCategory()
        {
            if (categoryBox.Text.Length == 0)
            {
                errorProvider.SetError(categoryBox, "does not empty");
            }
            else
            {
                try
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    CATEGORY ca = new CATEGORY();
                    ca.Title = categoryBox.Text;
                    db.CATEGORies.InsertOnSubmit(ca);
                    db.SubmitChanges();
                    errorProvider.Clear();
                    categoryBox.Items.Add(ca.Title.ToString());
                    MessageBox.Show("Successfully added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Duplicated data / orther errors", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    categoryBox.Text = "";
                    errorProvider.Clear();
                    categoryBox.Focus();
                }
            }
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            showView();
            showCategory();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                string title = categoryBox.Text;
                CATEGORY c = db.CATEGORies.Where(p => p.Title.Equals(title)).SingleOrDefault();
                db.CATEGORies.DeleteOnSubmit(c);
                db.SubmitChanges();
                categoryBox.Items.Remove(categoryBox.Text);
                categoryBox.SelectedItem = categoryBox.Items[0];
                MessageBox.Show("Successfully deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showView();
            }
            catch
            {
                MessageBox.Show("Something gone wrong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void isbnTbx_OnValueChanged(object sender, EventArgs e)
        {
            if(isbnTbx.Text.Length == 0)
            {
                errorProvider.SetError(isbnTbx, "does not empty");
            }
            else
            {
                if(!isbnTbx.Text.All(char.IsDigit) || isbnTbx.Text.Length != 13)
                {
                    errorProvider.SetError(isbnTbx, "incorrect ISBN format");
                }
                else
                {
                    errorProvider.SetError(isbnTbx, null);
                }
            }
        }

        private void nameTbx_OnValueChanged(object sender, EventArgs e)
        {
            if(nameTbx.Text.Length == 0)
            {
                errorProvider.SetError(nameTbx, "does not empty");
            }
            else
            {
                errorProvider.SetError(nameTbx, null);
            }
        }

        private void authorTbx_OnValueChanged(object sender, EventArgs e)
        {
            if (authorTbx.Text.Length == 0)
            {
                errorProvider.SetError(authorTbx, "does not empty");
            }
            else
            {
                errorProvider.SetError(authorTbx, null);
            }
        }

        private void publisherTbx_OnValueChanged(object sender, EventArgs e)
        {
            if (publisherTbx.Text.Length == 0)
            {
                errorProvider.SetError(publisherTbx, "does not empty");
            }
            else
            {
                errorProvider.SetError(publisherTbx, null);
            }
        }

        private void quantityTbx_OnValueChanged(object sender, EventArgs e)
        {
            if (quantityTbx.Text.Length == 0)
            {
                errorProvider.SetError(quantityTbx, "does not empty");
            }
            else
            {
                if (!quantityTbx.Text.All(char.IsDigit) || Convert.ToInt32(quantityTbx.Text) < 1)
                {
                    errorProvider.SetError(quantityTbx, "quantity must be number and bigger 1");
                }
                else
                {
                    errorProvider.SetError(quantityTbx, null);
                }
            }
        }

        private void summaryTbx_OnValueChanged(object sender, EventArgs e)
        {
            if (summaryTbx.Text.Length == 0)
            {
                errorProvider.SetError(summaryTbx, "does not empty");
            }
            else
            {
                errorProvider.SetError(summaryTbx, null);
            }
        }


        byte[] convertImagetoBytes()
        {
            FileStream fs = new FileStream(imageTbx.Text, FileMode.Open, FileAccess.Read);
            byte[] pic = new byte[fs.Length];
            fs.Read(pic, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            return pic;
        }

        private void categoryBox_TextChanged(object sender, EventArgs e)
        {
            if(categoryBox.Text.Length == 0)
            {
                errorProvider.SetError(categoryBox, "does not empty");
            }
            else
            {
                errorProvider.SetError(categoryBox, null);
            }
        }

        private void browserBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "All file(*.*)|*.*|PNG files(*.png)|*.png|JPG files(*.jpg)|*.jpg|JPEG files(*.jpeg)|*.jpeg|JFIF files(*.jfif)|*.jfif";
            if (o.ShowDialog() == DialogResult.OK)
            {
                imageTbx.Text = o.FileName.ToString();
            }
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(isbnTbx.Text.Length == 0)
            {
                errorProvider.SetError(isbnTbx, "does not empty");
            }
            else
            {
                try
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    BOOK del = db.BOOKs.Where(p => p.ISBN.Equals(currentISBN)).SingleOrDefault();
                    db.BOOKs.DeleteOnSubmit(del);
                    db.SubmitChanges();
                    showView();
                    foreach (Control c in this.Controls)
                    {
                        if (c.GetType().ToString() == "Bunifu.Framework.UI.BunifuMaterialTextbox")
                        {
                            c.Text = "";
                        }
                    }
                    errorProvider.Clear();
                    MessageBox.Show("Successfully deleted", "Mesagge", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showView();
                    currentISBN = "";
                }
                catch
                {
                    MessageBox.Show("Something gone wrong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider.Clear();
                }
            }
        }


        BOOK newBook(BOOK oldBook)
        {
            LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
            BOOK book = new BOOK();
            book.ISBN = isbnTbx.Text;
            book.BookName = nameTbx.Text;
            book.Author = authorTbx.Text;
            book.Publisher = publisherTbx.Text;
            book.Quantity = Convert.ToInt32(quantityTbx.Text);
            bool check = false;
            foreach (string test in categoryBox.Items)
            {
                if (test == categoryBox.Text)
                {
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                addCategory();
            }
            book.Category = categoryBox.Text;
            if (imageTbx.Text.Length != 0)
            {
                book.BookImage = convertImagetoBytes();
            }
            else
            {
                book.BookImage = oldBook.BookImage;
            }
            book.Summary = summaryTbx.Text;
            return book;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            bool success = validatingTextBox();
            if (success)
            {
                try
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    BOOK book = db.BOOKs.Where(p => p.ISBN.Equals(currentISBN)).SingleOrDefault();
                    if(book.ISBN != isbnTbx.Text)
                    {
                        BOOK oldBook = book;
                        book = newBook(book);
                        db.BOOKs.InsertOnSubmit(book);
                        var issue = db.ISSUEBOOKs.Where(p => p.IssueBook1.Equals(oldBook.ISBN));
                        if(issue != null)
                        {
                            foreach (var ise in issue)
                            {
                                ise.IssueBook1 = book.ISBN;
                            }
                        }
                        db.BOOKs.DeleteOnSubmit(oldBook);
                    }
                    else
                    {
                        book.ISBN = isbnTbx.Text;
                        book.BookName = nameTbx.Text;
                        book.Author = authorTbx.Text;
                        book.Publisher = publisherTbx.Text;
                        book.Quantity = Convert.ToInt32(quantityTbx.Text);
                        bool check = false;
                        foreach (string test in categoryBox.Items)
                        {
                            if (test == categoryBox.Text)
                            {
                                check = true;
                                break;
                            }
                        }
                        if (!check)
                        {
                            addCategory();
                        }
                        book.Category = categoryBox.Text;
                        if (imageTbx.Text.Length != 0)
                        {
                            book.BookImage = convertImagetoBytes();
                        }
                        book.Summary = summaryTbx.Text;
                    }
                    
                    db.SubmitChanges();
                    foreach (Control c in this.Controls)
                    {
                        if (c.GetType().ToString() == "Bunifu.Framework.UI.BunifuMaterialTextbox")
                        {
                            c.Text = "";
                        }
                    }
                    errorProvider.Clear();
                    currentISBN = "";
                    MessageBox.Show("Successfully edited", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Duplicated data/ other error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isbnTbx.Text = "";
                    errorProvider.Clear();
                    isbnTbx.Focus();
                }
                showView();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            bool success = validatingTextBox();
            if (imageTbx.Text.Length == 0)
            {
                errorProvider.SetError(imageTbx, "does not empty");
                success = false;
            }
            if (success)
            {
                try
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    BOOK book = new BOOK();
                    book.ISBN = isbnTbx.Text;
                    book.BookName = nameTbx.Text;
                    book.Author = authorTbx.Text;
                    book.Publisher = publisherTbx.Text;
                    book.Quantity = Convert.ToInt32(quantityTbx.Text);
                    bool check = false;
                    foreach (string test in categoryBox.Items)
                    {
                        if (test == categoryBox.Text)
                        {
                            check = true;
                            break;
                        }
                    }
                    if (!check)
                    {
                        addCategory();
                    }
                    book.Category = categoryBox.Text;
                    book.BookImage = convertImagetoBytes();
                    book.Summary = summaryTbx.Text;
                    db.BOOKs.InsertOnSubmit(book);
                    db.SubmitChanges();
                    foreach (Control c in this.Controls)
                    {
                        if (c.GetType().ToString() == "Bunifu.Framework.UI.BunifuMaterialTextbox")
                        {
                            c.Text = "";
                        }
                    }
                    errorProvider.Clear();
                    currentISBN = "";
                    MessageBox.Show("Successfully added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Duplicated data/ other error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    currentISBN = "";
                    isbnTbx.Text = "";
                    errorProvider.Clear();
                    isbnTbx.Focus();
                }
                showView();
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            showView();
        }

        private void IBSNSearchTbx_Enter(object sender, EventArgs e)
        {
            if(IBSNSearchTbx.Text == "ISBN...")
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(IBSNSearchTbx.Text != "ISBN...")
            {
                LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                bookDGV.DataSource = from p in db.BOOKs where SqlMethods.Like(p.ISBN, IBSNSearchTbx.Text + "%") select new { p.ISBN, p.BookName, p.Author, p.Publisher, p.Quantity, p.Category };
                resetSearch();
            }
            else
            {
                if(nameSearchTbx.Text != "Name...")
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

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if(currentISBN != "")
            {
                viewBookForm view = new viewBookForm(currentISBN);
                view.Show();
            }
            else
            {
                MessageBox.Show("No data to show", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
