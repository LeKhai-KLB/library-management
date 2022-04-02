using System;
using System.Collections;
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
    public partial class IssueBookForm : Form
    {

        int currentId = 0;
        string currentISBN = "";
        public IssueBookForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainf = new MainForm();
            mainf.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IssueBookForm_Load(object sender, EventArgs e)
        {
            resetBookBox();
            resetReaderBox();
            ReaderBox.Text = boxBox.Text = "";
            dateTimePicker.Value = System.DateTime.Now;
            showView();
        }

        void resetReaderBox()
        {
            ReaderBox.Items.Clear();
            LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
            var readerList = db.READERs.Select(p => p);
            if (readerList != null)
            {
                foreach (READER re in readerList)
                {
                    ReaderBox.Items.Add(re.ReName + " - " + re.RePhone);
                }
            }
        }

        void resetBookBox()
        {
            boxBox.Items.Clear();
            LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
            var bookList = db.BOOKs.Select(p => p);
            if(bookList != null)
            {
                foreach (BOOK book in bookList)
                {
                    boxBox.Items.Add(book.BookName + " - " + book.ISBN);
                }
}
        }

        void showView()
        {
            LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
            issueBookDGV.DataSource = from p in db.ISSUEBOOKs select new {p.IssueID, p.IssueReader, p.IssueBook1, p.IssueDate };
        }

        private void ReaderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] temp = { "-" };
            string[] spl = ReaderBox.Text.Split(temp, 2, StringSplitOptions.RemoveEmptyEntries);
            phoneTbx.Text = spl[1].Trim();
        }

        private void boxBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] temp = { "-" };
            string[] spl = boxBox.Text.Split(temp, 2, StringSplitOptions.RemoveEmptyEntries);
            isbnTbx.Text = spl[1].Trim();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            showView();
        }

        bool validatingTextBox()
        {
            bool check = true;
            if(phoneTbx.Text == "")
            {
                errorProvider.SetError(phoneTbx, "does not empty");
                check = false;
            }
            if(isbnTbx.Text == "")
            {
                errorProvider.SetError(isbnTbx, "does not empty");
                check = false;
            }
            return check;
        }

        private void ReaderBox_TextChanged(object sender, EventArgs e)
        {
            if (ReaderBox.Items.Contains(ReaderBox.Text))
            {
                string[] temp = { "-" };
                string[] spl = ReaderBox.Text.Split(temp, 2, StringSplitOptions.RemoveEmptyEntries);
                phoneTbx.Text = spl[1].Trim();
            }
        }

        private void boxBox_TextChanged(object sender, EventArgs e)
        {
            if (boxBox.Items.Contains(boxBox.Text))
            {
                string[] temp = { "-" };
                string[] spl = boxBox.Text.Split(temp, 2, StringSplitOptions.RemoveEmptyEntries);
                isbnTbx.Text = spl[1].Trim();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            bool success = validatingTextBox();
            if (success)
            {
                try
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    BOOK book = db.BOOKs.Where(p => p.ISBN.Equals(isbnTbx.Text)).SingleOrDefault();
                    if (book.Quantity == 0)
                    {
                        MessageBox.Show("out of book", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        ISSUEBOOK add = new ISSUEBOOK();
                        add.IssueBook1 = isbnTbx.Text;
                        READER re = db.READERs.Where(p => p.RePhone.Equals(phoneTbx.Text)).SingleOrDefault();
                        add.IssueReader = re.ReID;
                        add.IssueDate = System.DateTime.Now;
                        db.ISSUEBOOKs.InsertOnSubmit(add);
                        book.Quantity -= 1;
                        db.SubmitChanges();
                        foreach (Control c in this.Controls)
                        {
                            if (c.GetType().ToString() == "Bunifu.Framework.UI.BunifuMaterialTextbox")
                            {
                                c.Text = "";
                            }
                        }
                        ReaderBox.Text = "";
                        boxBox.Text = "";
                        dateTimePicker.Value = System.DateTime.Now;
                        errorProvider.Clear();
                        showView();
                        MessageBox.Show("Successfully added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        currentId = 0;
                        currentISBN = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Something gone wrong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider.Clear();
                    currentId = 0;
                    currentISBN = "";
                }
            }
        }

        private void issueBookDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentId = Convert.ToInt32(issueBookDGV.SelectedRows[0].Cells[0].Value);
            LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
            READER re = db.READERs.Where(p => p.ReID.Equals(issueBookDGV.SelectedRows[0].Cells[1].Value.ToString())).SingleOrDefault();
            phoneTbx.Text = re.RePhone.ToString();
            currentISBN = isbnTbx.Text = issueBookDGV.SelectedRows[0].Cells[2].Value.ToString();
            DateTime time = DateTime.Parse(issueBookDGV.SelectedRows[0].Cells[3].Value.ToString());
            dateTimePicker.Value = time;
            errorProvider.Clear();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            bool success = validatingTextBox();
            if (success)
            {
                try
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    ISSUEBOOK edit = db.ISSUEBOOKs.Where(p => p.IssueID.Equals(currentId)).SingleOrDefault();
                    edit.IssueBook1 = isbnTbx.Text;
                    READER re = db.READERs.Where(p => p.RePhone.Equals(phoneTbx.Text)).SingleOrDefault();
                    if (currentISBN != isbnTbx.Text)
                    {
                        BOOK book = db.BOOKs.Where(p => p.ISBN.Equals(isbnTbx.Text)).SingleOrDefault();
                        book.Quantity -= 1;
                        BOOK book1 = db.BOOKs.Where(p => p.ISBN.Equals(currentISBN)).SingleOrDefault();
                        book1.Quantity += 1;
                    }
                    edit.IssueBook1 = isbnTbx.Text;
                    edit.IssueReader = re.ReID;
                    edit.IssueDate = dateTimePicker.Value;
                    db.SubmitChanges();
                    foreach (Control c in this.Controls)
                    {
                        if (c.GetType().ToString() == "Bunifu.Framework.UI.BunifuMaterialTextbox")
                        {
                            c.Text = "";
                        }
                    }
                    ReaderBox.Text = "";
                    boxBox.Text = "";
                    dateTimePicker.Value = System.DateTime.Now;
                    errorProvider.Clear();
                    showView();
                    MessageBox.Show("Successfully edited", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    currentId = 0;
                    currentISBN = "";
                }
                catch
                {
                    MessageBox.Show("Something gone wrong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider.Clear();
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(currentId == 0)
            {
                MessageBox.Show("No data to delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    ISSUEBOOK del = db.ISSUEBOOKs.Where(p => p.IssueID.Equals(currentId)).SingleOrDefault();
                    db.ISSUEBOOKs.DeleteOnSubmit(del);
                    db.ExecuteCommand("DBCC CHECKIDENT('ISSUEBOOK',RESEED,1);");
                    BOOK book = db.BOOKs.Where(p => p.ISBN.Equals(del.IssueBook1)).SingleOrDefault();
                    book.Quantity += 1;
                    db.SubmitChanges();
                    foreach (Control c in this.Controls)
                    {
                        if (c.GetType().ToString() == "Bunifu.Framework.UI.BunifuMaterialTextbox")
                        {
                            c.Text = "";
                        }
                    }
                    ReaderBox.Text = "";
                    boxBox.Text = "";
                    dateTimePicker.Value = System.DateTime.Now;
                    errorProvider.Clear();
                    showView();
                    MessageBox.Show("Successfully deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    currentId = 0;
                    currentISBN = "";
                }
                catch
                {
                    MessageBox.Show("Something gone wrong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider.Clear();
                }
            }
        }

        private void phoneSearchTbx_Enter(object sender, EventArgs e)
        {
            if (phoneSearchTbx.Text == "Phone...")
            {
                phoneSearchTbx.Text = "";
            }
        }

        private void phoneSearchTbx_Leave(object sender, EventArgs e)
        {
            if (phoneSearchTbx.Text == "")
            {
                phoneSearchTbx.Text = "Phone...";
            }
        }

        private void isbnSearchTbx_Enter(object sender, EventArgs e)
        {
            if (isbnSearchTbx.Text == "ISBN...")
            {
                isbnSearchTbx.Text = "";
            }
        }

        private void isbnSearchTbx_Leave(object sender, EventArgs e)
        {
            if (isbnSearchTbx.Text == "")
            {
                isbnSearchTbx.Text = "ISBN...";
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (isbnSearchTbx.Text != "ISBN...")
            {
                if(phoneSearchTbx.Text != "Phone...")
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    var issue = from p in db.ISSUEBOOKs
                                join q in db.READERs on p.IssueReader equals q.ReID
                                where SqlMethods.Like(q.RePhone, phoneSearchTbx.Text + "%")
                                where SqlMethods.Like(p.IssueBook1, isbnSearchTbx.Text + "%")
                                select new
                                { p.IssueID, p.IssueReader, p.IssueBook1, p.IssueDate };
                    issueBookDGV.DataSource = issue;
                    resetSearch();
                }
                else
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    var issue = from p in db.ISSUEBOOKs
                                where SqlMethods.Like(p.IssueBook1, isbnSearchTbx.Text + "%")
                                select new
                                { p.IssueID, p.IssueReader, p.IssueBook1, p.IssueDate };

                    issueBookDGV.DataSource = issue;
                    resetSearch();
                }
            }
            else
            {
                if (phoneSearchTbx.Text != "Phone...")
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    var issue = from p in db.ISSUEBOOKs
                                join q in db.READERs on p.IssueReader equals q.ReID
                                where SqlMethods.Like(q.RePhone, phoneSearchTbx.Text + "%")
                                select new
                                { p.IssueID, p.IssueReader, p.IssueBook1, p.IssueDate };
                    issueBookDGV.DataSource = issue;
                    resetSearch();
                }
            }
        }

        void resetSearch()
        {
            isbnSearchTbx.Text = "ISBN...";
            phoneSearchTbx.Text = "Phone...";
        }
    }
}
