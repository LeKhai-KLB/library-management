using Microsoft.Office.Interop.Excel;
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
    public partial class ReturnBookForm : Form
    {

        int currentId = 0;
        string currentISBN = "";
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            showIssueView();
            showReturnView();
            returnDate.Value = System.DateTime.Now;
            returnedCheckBox.Checked = false;
        }

        void showReturnView()
        {
            LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
            var returnBookList = from p in db.RETURNBOOKs select new { p.ReturnID, p.ReturnDate };
            returnDGV.DataSource = returnBookList;
        }

        void showIssueView()
        {
            LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
            var issueBookList = from p in db.ISSUEBOOKs select new { p.IssueID, p.IssueReader, p.IssueBook1, p.IssueDate };
            issueDGV.DataSource = issueBookList;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainf = new MainForm();
            mainf.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void issueDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentId = Convert.ToInt32(issueDGV.SelectedRows[0].Cells[0].Value);
            LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
            READER re = db.READERs.Where(p => p.ReID.Equals(issueDGV.SelectedRows[0].Cells[1].Value.ToString())).SingleOrDefault();
            phoneTbx.Text = re.RePhone.ToString();
            currentISBN = isbnTbx.Text = issueDGV.SelectedRows[0].Cells[2].Value.ToString();
            DateTime time = DateTime.Parse(issueDGV.SelectedRows[0].Cells[3].Value.ToString());
            issueDate.Value = time;
            RETURNBOOK returnBook = db.RETURNBOOKs.Where(p => p.ReturnID.Equals(currentId)).SingleOrDefault();
            if(returnBook != null)
            {
                returnedCheckBox.Checked = true;
            }
            else
            {
                returnedCheckBox.Checked = false;
            }
            errorProvider.Clear();
        }

        private void returnDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentId = Convert.ToInt32(returnDGV.SelectedRows[0].Cells[0].Value);
            LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
            ISSUEBOOK issue = db.ISSUEBOOKs.Where(p => p.IssueID.Equals(currentId)).SingleOrDefault();
            READER re = db.READERs.Where(p => p.ReID.Equals(issue.IssueReader)).SingleOrDefault();
            phoneTbx.Text = re.RePhone.ToString();
            currentISBN = isbnTbx.Text = issue.IssueBook1;
            returnedCheckBox.Checked = true;
            DateTime time = DateTime.Parse(issue.IssueDate.ToString());
            issueDate.Value = time;
            DateTime time1 = DateTime.Parse(returnDGV.SelectedRows[0].Cells[1].Value.ToString());
            returnDate.Value = time1;
            errorProvider.Clear();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            if (currentId == 0)
            {
                errorProvider.SetError(phoneTbx, "does not empty");
                errorProvider.SetError(isbnTbx, "does not empty");
            }
            else
            {
                if(returnedCheckBox.Checked == true)
                {
                    MessageBox.Show("Book had been returned", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                        RETURNBOOK returned = new RETURNBOOK();
                        returned.ReturnID = currentId;
                        returned.ReturnDate = System.DateTime.Now;
                        ISSUEBOOK issue = db.ISSUEBOOKs.Where(p => p.IssueID.Equals(currentId)).SingleOrDefault();
                        BOOK book = db.BOOKs.Where(p => p.ISBN.Equals(issue.IssueBook1)).SingleOrDefault();
                        book.Quantity += 1;
                        db.RETURNBOOKs.InsertOnSubmit(returned);
                        db.SubmitChanges();
                        foreach (Control c in this.Controls)
                        {
                            if (c.GetType().ToString() == "Bunifu.Framework.UI.BunifuMaterialTextbox")
                            {
                                c.Text = "";
                            }
                        }
                        returnDate.Value = System.DateTime.Now;
                        showReturnView();
                        returnedCheckBox.Checked = false;
                        currentId = 0;
                        currentISBN = "";
                        MessageBox.Show("Successfully returned", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorProvider.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Something gone wrong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider.Clear();
                    }
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

        private void idSearchTbx_Enter(object sender, EventArgs e)
        {
            if (idSearchTbx.Text == "ID...")
            {
                idSearchTbx.Text = "";
            }
        }

        private void idSearchTbx_Leave(object sender, EventArgs e)
        {
            if (idSearchTbx.Text == "")
            {
                idSearchTbx.Text = "ID...";
            }
        }

        private void searchIssueBtn_Click(object sender, EventArgs e)
        {
            if (isbnSearchTbx.Text != "ISBN...")
            {
                if (phoneSearchTbx.Text != "Phone...")
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    var issue = from p in db.ISSUEBOOKs
                                join q in db.READERs on p.IssueReader equals q.ReID
                                where SqlMethods.Like(q.RePhone, phoneSearchTbx.Text + "%")
                                where SqlMethods.Like(p.IssueBook1, isbnSearchTbx.Text + "%")
                                select new
                                { p.IssueID, p.IssueReader, p.IssueBook1, p.IssueDate };
                    issueDGV.DataSource = issue;
                    resetIssueSearch();
                }
                else
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    var issue = from p in db.ISSUEBOOKs
                                where SqlMethods.Like(p.IssueBook1, isbnSearchTbx.Text + "%")
                                select new
                                { p.IssueID, p.IssueReader, p.IssueBook1, p.IssueDate };

                    issueDGV.DataSource = issue;
                    resetIssueSearch();
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
                    issueDGV.DataSource = issue;
                    resetIssueSearch();
                }
            }
        }

        void resetIssueSearch()
        {
            isbnSearchTbx.Text = "ISBN...";
            phoneSearchTbx.Text = "Phone...";
        }

        private void loadIssueBtn_Click(object sender, EventArgs e)
        {
            showIssueView();
        }

        private void loadReturnBtn_Click(object sender, EventArgs e)
        {
            showReturnView();
        }

        private void searchReturnBtn_Click(object sender, EventArgs e)
        {
            if (idSearchTbx.Text != "ID...")
            {
                LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                var returned = from p in db.RETURNBOOKs
                               where p.ReturnID.Equals(Convert.ToInt32(idSearchTbx.Text))
                               select new { p.ReturnID, p.ReturnDate};
                returnDGV.DataSource = returned;
                idSearchTbx.Text = "ID...";
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (currentId == 0)
            {
                errorProvider.SetError(phoneTbx, "does not empty");
                errorProvider.SetError(isbnTbx, "does not empty");
            }
            else
            {
                if (returnedCheckBox.Checked == false)
                {
                    MessageBox.Show("does not have returned book data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                        RETURNBOOK del = db.RETURNBOOKs.Where(p => p.ReturnID.Equals(currentId)).SingleOrDefault();
                        db.RETURNBOOKs.DeleteOnSubmit(del);
                        ISSUEBOOK issue = db.ISSUEBOOKs.Where(p => p.IssueID.Equals(currentId)).SingleOrDefault();
                        BOOK book = db.BOOKs.Where(p => p.ISBN.Equals(issue.IssueBook1)).SingleOrDefault();
                        book.Quantity -= 1;
                        db.SubmitChanges();
                        foreach (Control c in this.Controls)
                        {
                            if (c.GetType().ToString() == "Bunifu.Framework.UI.BunifuMaterialTextbox")
                            {
                                c.Text = "";
                            }
                        }
                        returnDate.Value = System.DateTime.Now;
                        showReturnView();
                        returnedCheckBox.Checked = false;
                        currentId = 0;
                        currentISBN = "";
                        MessageBox.Show("Successfully deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorProvider.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Something gone wrong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider.Clear();
                    }
                }
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
            var IssueList = db.ISSUEBOOKs.Select(p => p);
            var returnList = db.RETURNBOOKs.Select(p => p);
            Microsoft.Office.Interop.Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = ex.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)ex.ActiveSheet;
            ex.Visible = true;
            ex.ErrorCheckingOptions.NumberAsText = false;
            int index = 2;
            int progress = IssueList.Count();
            ws.Cells[1, 1] = "Issue id";
            ws.Cells[1, 2] = "Reader id";
            ws.Cells[1, 3] = "ISBN";
            ws.Cells[1, 4] = "Issue date";
            ws.Cells[1, 5] = "Return date";
            foreach (ISSUEBOOK i in IssueList)
            {
                ws.Cells[index, 1] = i.IssueID.ToString();
                ws.Cells[index, 2] = i.IssueReader.ToString();
                ws.Cells[index, 3] = "'" + i.IssueBook1.ToString(); 
                ws.Cells[index, 4] = i.IssueDate.ToLongDateString();
                index++;
            }
            foreach(RETURNBOOK r in returnList)
            {
                ws.Cells[r.ReturnID, 5] = r.ReturnDate.ToLongDateString();
            }
            ws.Columns.AutoFit();
            ws.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
    }
}
