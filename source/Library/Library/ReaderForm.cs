using System;
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
    public partial class ReaderForm : Form
    {
        string currentPhone = "";
        public ReaderForm()
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

        private void ReaderForm_Load(object sender, EventArgs e)
        {
            showView();
        }

        bool validatingTextBox()
        {
            bool check = true;
            if(nameTbx.Text.Length == 0)
            {
                check = false;
                errorProvider.SetError(nameTbx, "does not empty");
            }
            if(adrTbx.Text.Length == 0)
            {
                check = false;
                errorProvider.SetError(adrTbx, "does not empty");
            }
            if (phoneTbx.Text.Length == 0)
            {
                check = false;
                errorProvider.SetError(phoneTbx, "does not empty");
            }
            else
            {
                if(!phoneTbx.Text.All(char.IsDigit) || phoneTbx.Text.Length != 10)
                {
                    check = false;
                    errorProvider.SetError(phoneTbx, "incorrect phone number format");
                }
            }
            return check;
        }



        void showView()
        {
            try
            {
                LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                librarianDGV.DataSource = from p in db.READERs select new { p.ReName, p.ReAddress, p.RePhone };
            }
            catch
            {
                MessageBox.Show("Something gone wrong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentPhone = "";
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            bool susscess = validatingTextBox();
            if (ImgTbx.Text.Length == 0)
            {
                susscess = false;
                errorProvider.SetError(browserBtn, "does not empty");
            }
            if (susscess)
            {
                try
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    READER rea = new READER();
                    rea.ReName = nameTbx.Text;
                    rea.ReAddress = adrTbx.Text;
                    rea.RePhone = phoneTbx.Text;
                    rea.ReImage = convertImagetoBytes();
                    db.READERs.InsertOnSubmit(rea);
                    db.SubmitChanges();
                    foreach (Control c in this.Controls)
                    {
                        if (c.GetType().ToString() == "Bunifu.Framework.UI.BunifuMaterialTextbox")
                        {
                            c.Text = "";
                        }
                    }
                    errorProvider.Clear();
                    currentPhone = "";
                    showView();
                    MessageBox.Show("Successfully added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Duplicated data / others errors", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    phoneTbx.Text = "";
                    errorProvider.Clear();
                    phoneTbx.Focus();
                    currentPhone = "";
                }
            }
        }

        private void browserBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "All file(*.*)|*.*|PNG files(*.png)|*.png|JPG files(*.jpg)|*.jpg|JPEG files(*.jpeg)|*.jpeg|JFIF files(*.jfif)|*.jfif";
            if(o.ShowDialog() == DialogResult.OK)
            {
                ImgTbx.Text = o.FileName.ToString();
            }
        }

        byte[] convertImagetoBytes()
        {
            FileStream fs = new FileStream(ImgTbx.Text, FileMode.Open, FileAccess.Read);
            byte[] pic = new byte[fs.Length];
            fs.Read(pic, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            return pic;
        }

        private void librarianDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nameTbx.Text = librarianDGV.SelectedRows[0].Cells[0].Value.ToString();
            adrTbx.Text = librarianDGV.SelectedRows[0].Cells[1].Value.ToString();
            phoneTbx.Text = librarianDGV.SelectedRows[0].Cells[2].Value.ToString();
            currentPhone = phoneTbx.Text;
            errorProvider.Clear();
        }

        private void nameTbx_OnValueChanged(object sender, EventArgs e)
        {
            if (nameTbx.Text.Length == 0)
            {
                errorProvider.SetError(nameTbx, "does not empty");
            }
            else
            {
                errorProvider.SetError(nameTbx, null);
            }
        }

        private void adrTbx_OnValueChanged(object sender, EventArgs e)
        {
            if (adrTbx.Text.Length == 0)
            {
                errorProvider.SetError(adrTbx, "does not empty");
            }
            else
            {
                errorProvider.SetError(adrTbx, null);
            }
        }

        private void phoneTbx_OnValueChanged(object sender, EventArgs e)
        {
            if (phoneTbx.Text.Length == 0)
            {
                errorProvider.SetError(phoneTbx, "does not empty");
            }
            else
            {
                if (!phoneTbx.Text.All(char.IsDigit) || phoneTbx.Text.Length != 10)
                {
                    errorProvider.SetError(phoneTbx, "incorrect phone number format");
                }
                else
                {
                    errorProvider.SetError(phoneTbx, null);
                }
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            bool success = validatingTextBox();
            if (success)
            {
                try
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    READER r = db.READERs.Where(p => p.RePhone.Equals(currentPhone)).SingleOrDefault();
                    r.ReName = nameTbx.Text;
                    r.ReAddress = adrTbx.Text;
                    r.RePhone = phoneTbx.Text;
                    if(ImgTbx.Text.Length != 0)
                    {
                        r.ReImage = convertImagetoBytes();
                    }
                    db.SubmitChanges();
                    foreach(Control c in this.Controls)
                    {
                        if (c.GetType().ToString() == "Bunifu.Framework.UI.BunifuMaterialTextbox")
                        {
                            c.Text = "";
                        }
                    }
                    errorProvider.Clear();
                    currentPhone = "";
                    MessageBox.Show("Successfully edited", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showView();
                }
                catch
                {
                    MessageBox.Show("duplicated data / others error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    phoneTbx.Text = "";
                    errorProvider.Clear();
                    phoneTbx.Focus();
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if(phoneTbx.Text.Length == 0)
            {
                errorProvider.SetError(phoneTbx, "does not empty");
            }
            else
            {
                try
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    READER del = db.READERs.Where(p => p.RePhone.Equals(phoneTbx.Text)).SingleOrDefault();
                    db.READERs.DeleteOnSubmit(del);
                    db.ExecuteCommand("DBCC CHECKIDENT('READER',RESEED,1);");
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
                    currentPhone = "";
                }
                catch
                {
                    MessageBox.Show("Something gone wrong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            resetSearch();
            showView();
        }

        private void resetSearch()
        {
            nameSearchTbx.Text = "Name...";
            phoneSearchTbx.Text = "Phone...";
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
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
            if(phone != "")
            {
                librarianDGV.DataSource = from p in db.READERs where SqlMethods.Like(p.RePhone, phone + "%") select new { p.ReName, p.ReAddress, p.RePhone };
                resetSearch();
            }
            else
            {
                if(name != "")
                {
                    librarianDGV.DataSource = from p in db.READERs where p.ReName.Contains(name) select new { p.ReName, p.ReAddress, p.RePhone };
                    resetSearch();
                }
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if(currentPhone != "")
            {
                viewReaderForm vieF = new viewReaderForm(currentPhone);
                vieF.Show();
            }
            else
            {
                MessageBox.Show("No data to show", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
