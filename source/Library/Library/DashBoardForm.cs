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
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
            var readers = db.READERs.Count();
            var books = db.BOOKs.Count();
            var librarians = db.LIBRARIANs.Count();
            var returnBooks = db.RETURNBOOKs.Count();
            var issueBooks = db.ISSUEBOOKs.Count();
            ReaderLabel.Text = readers.ToString();
            bookLabel.Text = books.ToString();
            LibLabel.Text = librarians.ToString();
            returnLabel.Text = returnBooks.ToString();
            issueLabel.Text = issueBooks.ToString(); 
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
