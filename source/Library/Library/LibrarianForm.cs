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
    public partial class LibrarianForm : Form
    {
        int currentId = 0;
        public LibrarianForm()
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

        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            showView();
        }

        void showView()
        {
            try
            {
                LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                librarianDGV.DataSource = db.LIBRARIANs.Select(d => d);
            }
            catch
            {
                MessageBox.Show("Something gone wrong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentId = 0;
            }
        }

        bool validatingTextBox()
        {
            bool check = true;
            if (idTbx.Text == "")
            {
                errorProvider.SetError(idTbx, "does not empty");
                check = false;
            }
            else
            {
                if (!idTbx.Text.All(char.IsDigit))
                {
                    errorProvider.SetError(idTbx, "id must be number");
                    check = false;
                }
            }
            if (NameTbx.Text == "")
            {
                errorProvider.SetError(NameTbx, "does not empty");
                check = false;
            }
            if (passTbx.Text == "")
            {
                errorProvider.SetError(passTbx, "does not empty");
                check = false;
            }
            if (confirmTbx.Text == "")
            {
                errorProvider.SetError(confirmTbx, "does not empty");
                check = false;
            }
            else
            {
                if (confirmTbx.Text != passTbx.Text)
                {
                    errorProvider.SetError(confirmTbx, "does not match password");
                    check = false;
                }
            }
            if (phoneTbx.Text == "")
            {
                errorProvider.SetError(phoneTbx, "does not empty");
                check = false;
            }
            else
            {
                long temp = 0;
                if (!phoneTbx.Text.All(char.IsDigit))
                {
                    errorProvider.SetError(phoneTbx, "phone must be number");
                    check = false;
                }
                else
                {
                    if (phoneTbx.Text.Length != 10)
                    {
                        errorProvider.SetError(phoneTbx, "phone must have 10 digits");
                        check = false;
                    }
                }
            }
            return check;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            bool success = validatingTextBox();

            if (success)
            {
                try
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    LIBRARIAN libran = new LIBRARIAN();
                    libran.LibID = Convert.ToInt32(idTbx.Text);
                    libran.LibName = NameTbx.Text;
                    libran.LibPass = passTbx.Text;
                    libran.LibPhone = phoneTbx.Text;
                    db.LIBRARIANs.InsertOnSubmit(libran);
                    db.SubmitChanges();
                    foreach (Control c in this.Controls)
                    {
                        if (c.GetType().ToString() == "Bunifu.Framework.UI.BunifuMaterialTextbox")
                        {
                            c.Text = "";
                        }
                    }
                    errorProvider.Clear();
                    currentId = 0;
                    MessageBox.Show("Successfully added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showView();
                }
                catch
                {
                    MessageBox.Show("duplicated data / others error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    idTbx.Text = "";
                    errorProvider.Clear();
                    idTbx.Focus();
                    currentId = 0;
                }
            }
        }

        private void librarianDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTbx.Text = librarianDGV.SelectedRows[0].Cells[0].Value.ToString();
            NameTbx.Text = librarianDGV.SelectedRows[0].Cells[1].Value.ToString();
            passTbx.Text = librarianDGV.SelectedRows[0].Cells[2].Value.ToString();
            confirmTbx.Text = librarianDGV.SelectedRows[0].Cells[2].Value.ToString();
            phoneTbx.Text = librarianDGV.SelectedRows[0].Cells[3].Value.ToString();
            currentId = Convert.ToInt32(idTbx.Text);
            errorProvider.Clear();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if(idTbx.Text.Length == 0)
            {
                errorProvider.SetError(idTbx, "does not empty");
            }
            else
            {
                try
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    int id = currentId;
                    LIBRARIAN del = db.LIBRARIANs.Where(p => p.LibID.Equals(id)).SingleOrDefault();
                    db.LIBRARIANs.DeleteOnSubmit(del);
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
                    currentId = 0;
                    MessageBox.Show("Successfully deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Something gone wrong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void idTbx_OnValueChanged(object sender, EventArgs e)
        {
            if (idTbx.Text == "")
            {
                errorProvider.SetError(idTbx, "does not empty");
            }
            else
            {
                if (!idTbx.Text.All(char.IsDigit))
                {
                    errorProvider.SetError(idTbx, "id must be number");
                }
                else
                {
                    errorProvider.SetError(idTbx, null);
                }
            }
        }

        private void NameTbx_OnValueChanged(object sender, EventArgs e)
        {
            if (NameTbx.Text == "")
            {
                errorProvider.SetError(NameTbx, "does not empty");
            }
            else
            {
                errorProvider.SetError(NameTbx, null);
            }
        }

        private void passTbx_OnValueChanged(object sender, EventArgs e)
        {
            if (passTbx.Text == "")
            {
                errorProvider.SetError(passTbx, "does not empty");
            }
            else
            {
                errorProvider.SetError(passTbx, null);
            }
        }

        private void confirmTbx_OnValueChanged(object sender, EventArgs e)
        {
            if (confirmTbx.Text == "")
            {
                errorProvider.SetError(confirmTbx, "does not empty");
            }
            else
            {
                if (confirmTbx.Text != passTbx.Text)
                {
                    errorProvider.SetError(confirmTbx, "does not match password");
                }
                else
                {
                    errorProvider.SetError(confirmTbx, null);
                }
            }
        }

        private void phoneTbx_OnValueChanged(object sender, EventArgs e)
        {
            if (phoneTbx.Text == "")
            {
                errorProvider.SetError(phoneTbx, "does not empty");
            }
            else
            {
                if (!phoneTbx.Text.All(char.IsDigit))
                {
                    errorProvider.SetError(phoneTbx, "phone must be number");
                }
                else
                {
                    if (phoneTbx.Text.Length != 10)
                    {
                        errorProvider.SetError(phoneTbx, "phone must have 10 digits");
                    }
                    else
                    {
                        errorProvider.SetError(phoneTbx, null);
                    }
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            bool success = validatingTextBox();

            if (success)
            {
                try
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    int id = currentId;
                    LIBRARIAN edit = db.LIBRARIANs.Where(p => p.LibID.Equals(id)).SingleOrDefault();
                    if(edit.LibID != Convert.ToInt32(idTbx.Text))
                    {

                        LIBRARIAN oldLibrarian = edit;
                        db.LIBRARIANs.DeleteOnSubmit(oldLibrarian);
                        db.SubmitChanges();
                        edit = new LIBRARIAN();
                        edit.LibID = Convert.ToInt32(idTbx.Text);
                        edit.LibName = NameTbx.Text;
                        edit.LibPass = passTbx.Text;
                        edit.LibPhone = phoneTbx.Text;
                        db.LIBRARIANs.InsertOnSubmit(edit);
                    }
                    else
                    {
                        edit.LibName = NameTbx.Text;
                        edit.LibPass = passTbx.Text;
                        edit.LibPhone = phoneTbx.Text;
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
                    currentId = 0;
                    MessageBox.Show("Successfully edited", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showView();
                }
                catch
                {
                    MessageBox.Show("duplicated data / others error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    idTbx.Text = "";
                    errorProvider.Clear();
                    idTbx.Focus();
                }
            }
        }

        private void idSearchTbx_Enter(object sender, EventArgs e)
        {
            if(idSearchTbx.Text == "ID...")
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

        private void nameSearchTbx_Enter(object sender, EventArgs e)
        {
            if(nameSearchTbx.Text == "Name...")
            {
                nameSearchTbx.Text = "";
            }
        }

        private void nameSearchTbx_Leave(object sender, EventArgs e)
        {
            if(nameSearchTbx.Text == "")
            {
                nameSearchTbx.Text = "Name...";
            }
        }

        private void phoneSearchTbx_Enter(object sender, EventArgs e)
        {
            if(phoneSearchTbx.Text == "Phone...")
            {
                phoneSearchTbx.Text = "";
            }
        }

        private void phoneSearchTbx_Leave(object sender, EventArgs e)
        {
            if(phoneSearchTbx.Text == "")
            {
                phoneSearchTbx.Text = "Phone...";
            }
        }

        void resetSearch()
        {
            nameSearchTbx.Text = "Name...";
            idSearchTbx.Text = "ID...";
            phoneSearchTbx.Text = "Phone...";
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            int id = 0;
            if(idSearchTbx.Text != "ID...")
            {
                id = Convert.ToInt32(idSearchTbx.Text);
            }
            string name = "", phone = "";
            if(nameSearchTbx.Text != "Name...")
            {
                name = nameSearchTbx.Text;
            }
            if(phoneSearchTbx.Text != "Phone...")
            {
                phone = phoneSearchTbx.Text;
            }

            LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
            if(id == 0 && phone == "")
            {
                var li = from p in db.LIBRARIANs where p.LibName.ToString().Contains(name) select p;
                librarianDGV.DataSource = li;
                resetSearch();
            }
            else
            {
                if(id == 0)
                {
                    var li = from p in db.LIBRARIANs where p.LibPhone.ToString().Contains(phone) select p;
                    librarianDGV.DataSource = li;
                    resetSearch();
                }
                else
                {
                    librarianDGV.DataSource = db.LIBRARIANs.Select(p=>p).Where(p=>SqlMethods.Like(p.LibID.ToString(), id + "%"));
                    resetSearch();
                }
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            resetSearch();
            showView();
        }
    }
}
