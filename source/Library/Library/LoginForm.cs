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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        bool validatingTTextBox()
        {
            bool check = true;
            if(idTbx.Text == "Type your UserID" || idTbx.Text == "")
            {
                errorProvider.SetError(idTbx, "does not empty");
                check = false;
            }
            if(passwordTbx.Text == "Password" || passwordTbx.Text == "")
            {
                errorProvider.SetError(passwordTbx, "does not empty");
                check = false;
            }
            return check;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            idTbx.Text = "";
            passwordTbx.Text = "";
            idTbx.Focus();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            bool success = validatingTTextBox();
            if (success)
            {
                try
                {
                    LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                    LIBRARIAN lib = db.LIBRARIANs.Where(p => p.LibID.Equals(Convert.ToInt32(idTbx.Text))).SingleOrDefault();
                    if(lib == null || passwordTbx.Text != lib.LibPass)
                    {
                        MessageBox.Show("this id does not exist or wrong password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        idTbx.Text = "";
                        passwordTbx.Text = "";
                        errorProvider.Clear();
                        idTbx.Focus();
                    }
                    else
                    {
                        MainForm mainF = new MainForm();
                        MessageBox.Show("Successfully logined", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        mainF.Show();
                    }
                }
                catch
                {
                    MessageBox.Show("Something gone wrong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void idTbx_OnValueChanged(object sender, EventArgs e)
        {
            if (idTbx.Text != "")
            {
                errorProvider.SetError(idTbx, null);

            }
        }

        private void passwordTbx_OnValueChanged(object sender, EventArgs e)
        {
            if (passwordTbx.Text != "")
            {
                errorProvider.SetError(passwordTbx, null);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            idTbx.HintText = "Type your UserID";
            passwordTbx.HintText = "Password";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GuestBookForm manF = new GuestBookForm();
            this.Hide();
            manF.Show();
        }
    }
}
