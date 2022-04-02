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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReaderForm readf = new ReaderForm();
            readf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BooksForm bookf = new BooksForm();
            bookf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianForm librarianf = new LibrarianForm();
            librarianf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueBookForm issuef = new IssueBookForm();
            issuef.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnBookForm returnf = new ReturnBookForm();
            returnf.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm logf = new LoginForm();
            logf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InfomationForm info = new InfomationForm();
            info.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DashBoardForm dashF = new DashBoardForm();
            dashF.Show();
        }
    }
}
