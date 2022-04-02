
namespace Library
{
    partial class ReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adrTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.phoneTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.editBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ImgTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.browserBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.viewBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.librarianDGV = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.nameSearchTbx = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.phoneSearchTbx = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librarianDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 31);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(796, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(836, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 57);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(359, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "READERS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // nameTbx
            // 
            this.nameTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nameTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nameTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nameTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTbx.HintForeColor = System.Drawing.Color.Empty;
            this.nameTbx.HintText = "";
            this.nameTbx.isPassword = false;
            this.nameTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.nameTbx.LineIdleColor = System.Drawing.Color.Gray;
            this.nameTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.nameTbx.LineThickness = 3;
            this.nameTbx.Location = new System.Drawing.Point(143, 184);
            this.nameTbx.Margin = new System.Windows.Forms.Padding(4);
            this.nameTbx.MaxLength = 32767;
            this.nameTbx.Name = "nameTbx";
            this.nameTbx.Size = new System.Drawing.Size(212, 33);
            this.nameTbx.TabIndex = 4;
            this.nameTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameTbx.OnValueChanged += new System.EventHandler(this.nameTbx_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address:";
            // 
            // adrTbx
            // 
            this.adrTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.adrTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.adrTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.adrTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adrTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.adrTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adrTbx.HintForeColor = System.Drawing.Color.Empty;
            this.adrTbx.HintText = "";
            this.adrTbx.isPassword = false;
            this.adrTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.adrTbx.LineIdleColor = System.Drawing.Color.Gray;
            this.adrTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.adrTbx.LineThickness = 3;
            this.adrTbx.Location = new System.Drawing.Point(143, 240);
            this.adrTbx.Margin = new System.Windows.Forms.Padding(4);
            this.adrTbx.MaxLength = 32767;
            this.adrTbx.Name = "adrTbx";
            this.adrTbx.Size = new System.Drawing.Size(212, 33);
            this.adrTbx.TabIndex = 7;
            this.adrTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adrTbx.OnValueChanged += new System.EventHandler(this.adrTbx_OnValueChanged);
            // 
            // phoneTbx
            // 
            this.phoneTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.phoneTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.phoneTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.phoneTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.phoneTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phoneTbx.HintForeColor = System.Drawing.Color.Empty;
            this.phoneTbx.HintText = "";
            this.phoneTbx.isPassword = false;
            this.phoneTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.phoneTbx.LineIdleColor = System.Drawing.Color.Gray;
            this.phoneTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.phoneTbx.LineThickness = 3;
            this.phoneTbx.Location = new System.Drawing.Point(143, 296);
            this.phoneTbx.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTbx.MaxLength = 32767;
            this.phoneTbx.Name = "phoneTbx";
            this.phoneTbx.Size = new System.Drawing.Size(212, 33);
            this.phoneTbx.TabIndex = 8;
            this.phoneTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phoneTbx.OnValueChanged += new System.EventHandler(this.phoneTbx_OnValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Image:";
            // 
            // addBtn
            // 
            this.addBtn.ActiveBorderThickness = 1;
            this.addBtn.ActiveCornerRadius = 20;
            this.addBtn.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
            this.addBtn.ActiveForecolor = System.Drawing.Color.White;
            this.addBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.addBtn.BackColor = System.Drawing.Color.MistyRose;
            this.addBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBtn.BackgroundImage")));
            this.addBtn.ButtonText = "Add";
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addBtn.IdleBorderThickness = 1;
            this.addBtn.IdleCornerRadius = 20;
            this.addBtn.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.addBtn.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.addBtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.addBtn.Location = new System.Drawing.Point(40, 442);
            this.addBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(85, 39);
            this.addBtn.TabIndex = 11;
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.PaleVioletRed;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.MistyRose;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Delete";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.Location = new System.Drawing.Point(263, 442);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(85, 39);
            this.bunifuThinButton22.TabIndex = 12;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // editBtn
            // 
            this.editBtn.ActiveBorderThickness = 1;
            this.editBtn.ActiveCornerRadius = 20;
            this.editBtn.ActiveFillColor = System.Drawing.Color.PaleGreen;
            this.editBtn.ActiveForecolor = System.Drawing.Color.White;
            this.editBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.editBtn.BackColor = System.Drawing.Color.MistyRose;
            this.editBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editBtn.BackgroundImage")));
            this.editBtn.ButtonText = "Edit";
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editBtn.IdleBorderThickness = 1;
            this.editBtn.IdleCornerRadius = 20;
            this.editBtn.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.editBtn.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.editBtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.editBtn.Location = new System.Drawing.Point(152, 442);
            this.editBtn.Margin = new System.Windows.Forms.Padding(5);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(85, 39);
            this.editBtn.TabIndex = 13;
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editBtn.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // ImgTbx
            // 
            this.ImgTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ImgTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ImgTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ImgTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ImgTbx.Enabled = false;
            this.ImgTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ImgTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ImgTbx.HintForeColor = System.Drawing.Color.Empty;
            this.ImgTbx.HintText = "";
            this.ImgTbx.isPassword = false;
            this.ImgTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.ImgTbx.LineIdleColor = System.Drawing.Color.Gray;
            this.ImgTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ImgTbx.LineThickness = 3;
            this.ImgTbx.Location = new System.Drawing.Point(143, 352);
            this.ImgTbx.Margin = new System.Windows.Forms.Padding(4);
            this.ImgTbx.MaxLength = 32767;
            this.ImgTbx.Name = "ImgTbx";
            this.ImgTbx.Size = new System.Drawing.Size(112, 33);
            this.ImgTbx.TabIndex = 25;
            this.ImgTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // browserBtn
            // 
            this.browserBtn.ActiveBorderThickness = 1;
            this.browserBtn.ActiveCornerRadius = 20;
            this.browserBtn.ActiveFillColor = System.Drawing.Color.LightGray;
            this.browserBtn.ActiveForecolor = System.Drawing.Color.White;
            this.browserBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.browserBtn.BackColor = System.Drawing.Color.MistyRose;
            this.browserBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("browserBtn.BackgroundImage")));
            this.browserBtn.ButtonText = "Browser";
            this.browserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browserBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browserBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.browserBtn.IdleBorderThickness = 1;
            this.browserBtn.IdleCornerRadius = 20;
            this.browserBtn.IdleFillColor = System.Drawing.Color.DarkGray;
            this.browserBtn.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.browserBtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.browserBtn.Location = new System.Drawing.Point(263, 364);
            this.browserBtn.Margin = new System.Windows.Forms.Padding(4);
            this.browserBtn.Name = "browserBtn";
            this.browserBtn.Size = new System.Drawing.Size(92, 30);
            this.browserBtn.TabIndex = 26;
            this.browserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.browserBtn.Click += new System.EventHandler(this.browserBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.viewBtn);
            this.panel3.Controls.Add(this.guna2ImageButton1);
            this.panel3.Controls.Add(this.guna2ImageButton4);
            this.panel3.Controls.Add(this.librarianDGV);
            this.panel3.Controls.Add(this.nameSearchTbx);
            this.panel3.Controls.Add(this.phoneSearchTbx);
            this.panel3.Location = new System.Drawing.Point(401, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 460);
            this.panel3.TabIndex = 48;
            // 
            // viewBtn
            // 
            this.viewBtn.CheckedState.Parent = this.viewBtn;
            this.viewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewBtn.HoverState.Parent = this.viewBtn;
            this.viewBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewBtn.Image")));
            this.viewBtn.Location = new System.Drawing.Point(334, 416);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.PressedState.Parent = this.viewBtn;
            this.viewBtn.Size = new System.Drawing.Size(29, 29);
            this.viewBtn.TabIndex = 52;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.Location = new System.Drawing.Point(404, 416);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(29, 29);
            this.guna2ImageButton1.TabIndex = 51;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2ImageButton4
            // 
            this.guna2ImageButton4.CheckedState.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton4.HoverState.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton4.Image")));
            this.guna2ImageButton4.Location = new System.Drawing.Point(369, 416);
            this.guna2ImageButton4.Name = "guna2ImageButton4";
            this.guna2ImageButton4.PressedState.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.Size = new System.Drawing.Size(29, 29);
            this.guna2ImageButton4.TabIndex = 50;
            this.guna2ImageButton4.Click += new System.EventHandler(this.guna2ImageButton4_Click);
            // 
            // librarianDGV
            // 
            this.librarianDGV.AllowCustomTheming = false;
            this.librarianDGV.AllowUserToAddRows = false;
            this.librarianDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.librarianDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.librarianDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.librarianDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.librarianDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.librarianDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.librarianDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.librarianDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.librarianDGV.ColumnHeadersHeight = 40;
            this.librarianDGV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.librarianDGV.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.librarianDGV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.librarianDGV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.librarianDGV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.librarianDGV.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.librarianDGV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.librarianDGV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.librarianDGV.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.librarianDGV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.librarianDGV.CurrentTheme.Name = null;
            this.librarianDGV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.librarianDGV.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.librarianDGV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.librarianDGV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.librarianDGV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.librarianDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.librarianDGV.EnableHeadersVisualStyles = false;
            this.librarianDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.librarianDGV.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.librarianDGV.HeaderBgColor = System.Drawing.Color.Empty;
            this.librarianDGV.HeaderForeColor = System.Drawing.Color.White;
            this.librarianDGV.Location = new System.Drawing.Point(0, 0);
            this.librarianDGV.Name = "librarianDGV";
            this.librarianDGV.ReadOnly = true;
            this.librarianDGV.RowHeadersVisible = false;
            this.librarianDGV.RowHeadersWidth = 51;
            this.librarianDGV.RowTemplate.Height = 40;
            this.librarianDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librarianDGV.Size = new System.Drawing.Size(439, 396);
            this.librarianDGV.TabIndex = 43;
            this.librarianDGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.librarianDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.librarianDGV_CellClick);
            // 
            // nameSearchTbx
            // 
            this.nameSearchTbx.BorderColorFocused = System.Drawing.Color.Blue;
            this.nameSearchTbx.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameSearchTbx.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.nameSearchTbx.BorderThickness = 3;
            this.nameSearchTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameSearchTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameSearchTbx.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSearchTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameSearchTbx.isPassword = false;
            this.nameSearchTbx.Location = new System.Drawing.Point(3, 416);
            this.nameSearchTbx.MaxLength = 32767;
            this.nameSearchTbx.Name = "nameSearchTbx";
            this.nameSearchTbx.Size = new System.Drawing.Size(114, 29);
            this.nameSearchTbx.TabIndex = 44;
            this.nameSearchTbx.Text = "Name...";
            this.nameSearchTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameSearchTbx.Enter += new System.EventHandler(this.nameSearchTbx_Enter);
            this.nameSearchTbx.Leave += new System.EventHandler(this.nameSearchTbx_Leave);
            // 
            // phoneSearchTbx
            // 
            this.phoneSearchTbx.BorderColorFocused = System.Drawing.Color.Blue;
            this.phoneSearchTbx.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phoneSearchTbx.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.phoneSearchTbx.BorderThickness = 3;
            this.phoneSearchTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.phoneSearchTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneSearchTbx.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneSearchTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phoneSearchTbx.isPassword = false;
            this.phoneSearchTbx.Location = new System.Drawing.Point(123, 416);
            this.phoneSearchTbx.MaxLength = 32767;
            this.phoneSearchTbx.Name = "phoneSearchTbx";
            this.phoneSearchTbx.Size = new System.Drawing.Size(114, 29);
            this.phoneSearchTbx.TabIndex = 45;
            this.phoneSearchTbx.Text = "Phone...";
            this.phoneSearchTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phoneSearchTbx.Enter += new System.EventHandler(this.phoneSearchTbx_Enter);
            this.phoneSearchTbx.Leave += new System.EventHandler(this.phoneSearchTbx_Leave);
            // 
            // ReaderForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(884, 638);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.browserBtn);
            this.Controls.Add(this.ImgTbx);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phoneTbx);
            this.Controls.Add(this.adrTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReaderForm";
            this.Load += new System.EventHandler(this.ReaderForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.librarianDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adrTbx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phoneTbx;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 addBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 editBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ImgTbx;
        private Bunifu.Framework.UI.BunifuThinButton2 browserBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
        private Bunifu.UI.WinForms.BunifuDataGridView librarianDGV;
        private Bunifu.Framework.UI.BunifuMetroTextbox nameSearchTbx;
        private Bunifu.Framework.UI.BunifuMetroTextbox phoneSearchTbx;
        private Guna.UI2.WinForms.Guna2ImageButton viewBtn;
    }
}