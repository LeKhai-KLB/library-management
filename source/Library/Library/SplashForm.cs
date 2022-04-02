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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int startPoitn = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoitn += 5;
            MyProgress.Value = startPoitn;
            if(MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }
    }
}
