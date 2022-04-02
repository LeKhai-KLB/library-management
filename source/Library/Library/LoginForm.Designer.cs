
namespace Library
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.passwordTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.idTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.passwordTbx);
            this.panel1.Controls.Add(this.idTbx);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 329);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.LightGreen;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkOliveGreen;
            this.linkLabel1.Location = new System.Drawing.Point(135, 255);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(71, 19);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Guest ?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(54, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clear";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.ActiveBorderThickness = 1;
            this.loginBtn.ActiveCornerRadius = 20;
            this.loginBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.loginBtn.ActiveForecolor = System.Drawing.Color.White;
            this.loginBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.loginBtn.BackColor = System.Drawing.SystemColors.Control;
            this.loginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBtn.BackgroundImage")));
            this.loginBtn.ButtonText = "LOGIN";
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.loginBtn.IdleBorderThickness = 1;
            this.loginBtn.IdleCornerRadius = 20;
            this.loginBtn.IdleFillColor = System.Drawing.Color.DarkOliveGreen;
            this.loginBtn.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.IdleLineColor = System.Drawing.Color.DarkOliveGreen;
            this.loginBtn.Location = new System.Drawing.Point(52, 211);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(5);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(153, 36);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordTbx
            // 
            this.passwordTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTbx.HintForeColor = System.Drawing.Color.Empty;
            this.passwordTbx.HintText = "";
            this.passwordTbx.isPassword = true;
            this.passwordTbx.LineFocusedColor = System.Drawing.Color.Black;
            this.passwordTbx.LineIdleColor = System.Drawing.Color.Gray;
            this.passwordTbx.LineMouseHoverColor = System.Drawing.Color.Black;
            this.passwordTbx.LineThickness = 3;
            this.passwordTbx.Location = new System.Drawing.Point(25, 155);
            this.passwordTbx.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTbx.MaxLength = 32767;
            this.passwordTbx.Name = "passwordTbx";
            this.passwordTbx.Size = new System.Drawing.Size(206, 33);
            this.passwordTbx.TabIndex = 2;
            this.passwordTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTbx.OnValueChanged += new System.EventHandler(this.passwordTbx_OnValueChanged);
            // 
            // idTbx
            // 
            this.idTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.idTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.idTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.idTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.idTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idTbx.HintForeColor = System.Drawing.Color.Empty;
            this.idTbx.HintText = "";
            this.idTbx.isPassword = false;
            this.idTbx.LineFocusedColor = System.Drawing.Color.Black;
            this.idTbx.LineIdleColor = System.Drawing.Color.Gray;
            this.idTbx.LineMouseHoverColor = System.Drawing.Color.Black;
            this.idTbx.LineThickness = 3;
            this.idTbx.Location = new System.Drawing.Point(25, 100);
            this.idTbx.Margin = new System.Windows.Forms.Padding(4);
            this.idTbx.MaxLength = 32767;
            this.idTbx.Name = "idTbx";
            this.idTbx.Size = new System.Drawing.Size(206, 33);
            this.idTbx.TabIndex = 1;
            this.idTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.idTbx.OnValueChanged += new System.EventHandler(this.idTbx_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER LOGIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(341, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "CENTRAL LIBRARY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(276, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "TRAN DAI NGHIA UNIVERSITY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(552, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(598, 329);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox idTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 loginBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}