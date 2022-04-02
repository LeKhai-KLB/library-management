using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class viewBookForm : Form
    {
        
        string currentIsbn { get; set; }
        public viewBookForm(string isbn)
        {
            InitializeComponent();
            this.currentIsbn = isbn;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Image byteToImage(string currentImageByteString)
        {
            byte[] imgBytes = Convert.FromBase64String(currentImageByteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void viewBookForm_Load(object sender, EventArgs e)
        {
            try
            {
                LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                BOOK book = db.BOOKs.Where(p => p.ISBN.Equals(currentIsbn)).SingleOrDefault();
                isbnTbx.Text = book.ISBN.ToString();
                nameTbx.Text = book.BookName.ToString();
                publisherTbx.Text = book.Publisher.ToString();
                authorTbx.Text = book.Author.ToString();
                categoryTbx.Text = book.Category.ToString();
                string currentStringImage = Convert.ToBase64String(book.BookImage.ToArray());
                gunaPictureBox1.Image = byteToImage(currentStringImage);
                sumaryTbx.Text = book.Summary.ToString();
            }
            catch
            {
                MessageBox.Show("Something gone wrong" + " " + currentIsbn, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
