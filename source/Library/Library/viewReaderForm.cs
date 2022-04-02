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
    public partial class viewReaderForm : Form
    {
        string currentPhone { get; set; }
        public viewReaderForm(string phone)
        {
            InitializeComponent();
            this.currentPhone = phone;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewReaderForm_Load(object sender, EventArgs e)
        {
            try
            {

                LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
                READER rea = db.READERs.Where(p => p.RePhone.Equals(currentPhone)).SingleOrDefault();
                nameTbx.Text = Convert.ToString(rea.ReName);
                adrTbx.Text = Convert.ToString(rea.ReAddress);
                phoneTbx.Text = currentPhone;
                string currentImageByteString = Convert.ToBase64String(rea.ReImage.ToArray());
                readerPic.Image = byteToImage(currentImageByteString);
            }
            catch
            {
                MessageBox.Show("Something gone wrong" + " " + currentPhone, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Image byteToImage(string currentImageByteString)
        {
            byte[] imgBytes = Convert.FromBase64String(currentImageByteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
    }
}
