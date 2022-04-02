
namespace Library
{
    partial class BooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.publisherTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.authorTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nameTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isbnTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.quantityTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.imageTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.editBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.deleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.addBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.authorSearchTbx = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.viewBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.nameSearchTbx = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.reloadBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.IBSNSearchTbx = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.searchBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.browserBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.summaryTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.bookDGV = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDGV)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(374, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "BOOKS";
            // 
            // publisherTbx
            // 
            this.publisherTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.publisherTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.publisherTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.publisherTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.publisherTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.publisherTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.publisherTbx.HintForeColor = System.Drawing.Color.Empty;
            this.publisherTbx.HintText = "";
            this.publisherTbx.isPassword = false;
            this.publisherTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.publisherTbx.LineIdleColor = System.Drawing.Color.Gray;
            this.publisherTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.publisherTbx.LineThickness = 3;
            this.publisherTbx.Location = new System.Drawing.Point(149, 352);
            this.publisherTbx.Margin = new System.Windows.Forms.Padding(4);
            this.publisherTbx.MaxLength = 32767;
            this.publisherTbx.Name = "publisherTbx";
            this.publisherTbx.Size = new System.Drawing.Size(212, 33);
            this.publisherTbx.TabIndex = 18;
            this.publisherTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.publisherTbx.OnValueChanged += new System.EventHandler(this.publisherTbx_OnValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Publisher:";
            // 
            // authorTbx
            // 
            this.authorTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.authorTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.authorTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.authorTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.authorTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.authorTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.authorTbx.HintForeColor = System.Drawing.Color.Empty;
            this.authorTbx.HintText = "";
            this.authorTbx.isPassword = false;
            this.authorTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.authorTbx.LineIdleColor = System.Drawing.Color.Gray;
            this.authorTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.authorTbx.LineThickness = 3;
            this.authorTbx.Location = new System.Drawing.Point(149, 296);
            this.authorTbx.Margin = new System.Windows.Forms.Padding(4);
            this.authorTbx.MaxLength = 32767;
            this.authorTbx.Name = "authorTbx";
            this.authorTbx.Size = new System.Drawing.Size(212, 33);
            this.authorTbx.TabIndex = 16;
            this.authorTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.authorTbx.OnValueChanged += new System.EventHandler(this.authorTbx_OnValueChanged);
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
            this.nameTbx.Location = new System.Drawing.Point(149, 240);
            this.nameTbx.Margin = new System.Windows.Forms.Padding(4);
            this.nameTbx.MaxLength = 32767;
            this.nameTbx.Name = "nameTbx";
            this.nameTbx.Size = new System.Drawing.Size(212, 33);
            this.nameTbx.TabIndex = 15;
            this.nameTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameTbx.OnValueChanged += new System.EventHandler(this.nameTbx_OnValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Book name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Author:";
            // 
            // isbnTbx
            // 
            this.isbnTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.isbnTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.isbnTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.isbnTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.isbnTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.isbnTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.isbnTbx.HintForeColor = System.Drawing.Color.Empty;
            this.isbnTbx.HintText = "";
            this.isbnTbx.isPassword = false;
            this.isbnTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.isbnTbx.LineIdleColor = System.Drawing.Color.Gray;
            this.isbnTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.isbnTbx.LineThickness = 3;
            this.isbnTbx.Location = new System.Drawing.Point(149, 184);
            this.isbnTbx.Margin = new System.Windows.Forms.Padding(4);
            this.isbnTbx.MaxLength = 32767;
            this.isbnTbx.Name = "isbnTbx";
            this.isbnTbx.Size = new System.Drawing.Size(212, 33);
            this.isbnTbx.TabIndex = 12;
            this.isbnTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.isbnTbx.OnValueChanged += new System.EventHandler(this.isbnTbx_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "ISBN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Quantity:";
            // 
            // quantityTbx
            // 
            this.quantityTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.quantityTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.quantityTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.quantityTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.quantityTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quantityTbx.HintForeColor = System.Drawing.Color.Empty;
            this.quantityTbx.HintText = "";
            this.quantityTbx.isPassword = false;
            this.quantityTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.quantityTbx.LineIdleColor = System.Drawing.Color.Gray;
            this.quantityTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.quantityTbx.LineThickness = 3;
            this.quantityTbx.Location = new System.Drawing.Point(149, 408);
            this.quantityTbx.Margin = new System.Windows.Forms.Padding(4);
            this.quantityTbx.MaxLength = 32767;
            this.quantityTbx.Name = "quantityTbx";
            this.quantityTbx.Size = new System.Drawing.Size(212, 33);
            this.quantityTbx.TabIndex = 20;
            this.quantityTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.quantityTbx.OnValueChanged += new System.EventHandler(this.quantityTbx_OnValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(458, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Image:";
            // 
            // imageTbx
            // 
            this.imageTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.imageTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.imageTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.imageTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.imageTbx.Enabled = false;
            this.imageTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.imageTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.imageTbx.HintForeColor = System.Drawing.Color.Empty;
            this.imageTbx.HintText = "";
            this.imageTbx.isPassword = false;
            this.imageTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.imageTbx.LineIdleColor = System.Drawing.Color.Gray;
            this.imageTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.imageTbx.LineThickness = 3;
            this.imageTbx.Location = new System.Drawing.Point(578, 464);
            this.imageTbx.Margin = new System.Windows.Forms.Padding(4);
            this.imageTbx.MaxLength = 32767;
            this.imageTbx.Name = "imageTbx";
            this.imageTbx.Size = new System.Drawing.Size(112, 33);
            this.imageTbx.TabIndex = 22;
            this.imageTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.editBtn.Location = new System.Drawing.Point(382, 536);
            this.editBtn.Margin = new System.Windows.Forms.Padding(5);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(85, 39);
            this.editBtn.TabIndex = 26;
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.ActiveBorderThickness = 1;
            this.deleteBtn.ActiveCornerRadius = 20;
            this.deleteBtn.ActiveFillColor = System.Drawing.Color.PaleVioletRed;
            this.deleteBtn.ActiveForecolor = System.Drawing.Color.White;
            this.deleteBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BackColor = System.Drawing.Color.MistyRose;
            this.deleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.BackgroundImage")));
            this.deleteBtn.ButtonText = "Delete";
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteBtn.IdleBorderThickness = 1;
            this.deleteBtn.IdleCornerRadius = 20;
            this.deleteBtn.IdleFillColor = System.Drawing.Color.Crimson;
            this.deleteBtn.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.deleteBtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Location = new System.Drawing.Point(493, 536);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(85, 39);
            this.deleteBtn.TabIndex = 25;
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.addBtn.Location = new System.Drawing.Point(270, 536);
            this.addBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(85, 39);
            this.addBtn.TabIndex = 24;
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.authorSearchTbx);
            this.panel3.Controls.Add(this.viewBtn);
            this.panel3.Controls.Add(this.nameSearchTbx);
            this.panel3.Controls.Add(this.reloadBtn);
            this.panel3.Controls.Add(this.IBSNSearchTbx);
            this.panel3.Controls.Add(this.searchBtn);
            this.panel3.Location = new System.Drawing.Point(401, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 256);
            this.panel3.TabIndex = 27;
            // 
            // authorSearchTbx
            // 
            this.authorSearchTbx.BorderColorFocused = System.Drawing.Color.Blue;
            this.authorSearchTbx.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.authorSearchTbx.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.authorSearchTbx.BorderThickness = 3;
            this.authorSearchTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.authorSearchTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.authorSearchTbx.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorSearchTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.authorSearchTbx.isPassword = false;
            this.authorSearchTbx.Location = new System.Drawing.Point(199, 215);
            this.authorSearchTbx.MaxLength = 32767;
            this.authorSearchTbx.Name = "authorSearchTbx";
            this.authorSearchTbx.Size = new System.Drawing.Size(91, 29);
            this.authorSearchTbx.TabIndex = 55;
            this.authorSearchTbx.Text = "Author...";
            this.authorSearchTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.authorSearchTbx.Enter += new System.EventHandler(this.authorSearchTbx_Enter);
            this.authorSearchTbx.Leave += new System.EventHandler(this.authorSearchTbx_Leave);
            // 
            // viewBtn
            // 
            this.viewBtn.CheckedState.Parent = this.viewBtn;
            this.viewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewBtn.HoverState.Parent = this.viewBtn;
            this.viewBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewBtn.Image")));
            this.viewBtn.Location = new System.Drawing.Point(336, 215);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.PressedState.Parent = this.viewBtn;
            this.viewBtn.Size = new System.Drawing.Size(29, 29);
            this.viewBtn.TabIndex = 57;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
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
            this.nameSearchTbx.Location = new System.Drawing.Point(102, 215);
            this.nameSearchTbx.MaxLength = 32767;
            this.nameSearchTbx.Name = "nameSearchTbx";
            this.nameSearchTbx.Size = new System.Drawing.Size(91, 29);
            this.nameSearchTbx.TabIndex = 54;
            this.nameSearchTbx.Text = "Name...";
            this.nameSearchTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameSearchTbx.Enter += new System.EventHandler(this.nameSearchTbx_Enter);
            this.nameSearchTbx.Leave += new System.EventHandler(this.nameSearchTbx_Leave);
            // 
            // reloadBtn
            // 
            this.reloadBtn.CheckedState.Parent = this.reloadBtn;
            this.reloadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadBtn.HoverState.Parent = this.reloadBtn;
            this.reloadBtn.Image = ((System.Drawing.Image)(resources.GetObject("reloadBtn.Image")));
            this.reloadBtn.Location = new System.Drawing.Point(406, 215);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.PressedState.Parent = this.reloadBtn;
            this.reloadBtn.Size = new System.Drawing.Size(29, 29);
            this.reloadBtn.TabIndex = 56;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // IBSNSearchTbx
            // 
            this.IBSNSearchTbx.BorderColorFocused = System.Drawing.Color.Blue;
            this.IBSNSearchTbx.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IBSNSearchTbx.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.IBSNSearchTbx.BorderThickness = 3;
            this.IBSNSearchTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.IBSNSearchTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IBSNSearchTbx.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBSNSearchTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IBSNSearchTbx.isPassword = false;
            this.IBSNSearchTbx.Location = new System.Drawing.Point(5, 215);
            this.IBSNSearchTbx.MaxLength = 32767;
            this.IBSNSearchTbx.Name = "IBSNSearchTbx";
            this.IBSNSearchTbx.Size = new System.Drawing.Size(91, 29);
            this.IBSNSearchTbx.TabIndex = 53;
            this.IBSNSearchTbx.Text = "ISBN...";
            this.IBSNSearchTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IBSNSearchTbx.Enter += new System.EventHandler(this.IBSNSearchTbx_Enter);
            this.IBSNSearchTbx.Leave += new System.EventHandler(this.IBSNSearchTbx_Leave);
            // 
            // searchBtn
            // 
            this.searchBtn.CheckedState.Parent = this.searchBtn;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.HoverState.Parent = this.searchBtn;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(371, 215);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.PressedState.Parent = this.searchBtn;
            this.searchBtn.Size = new System.Drawing.Size(29, 29);
            this.searchBtn.TabIndex = 55;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
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
            this.browserBtn.Location = new System.Drawing.Point(698, 476);
            this.browserBtn.Margin = new System.Windows.Forms.Padding(4);
            this.browserBtn.Name = "browserBtn";
            this.browserBtn.Size = new System.Drawing.Size(92, 30);
            this.browserBtn.TabIndex = 28;
            this.browserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.browserBtn.Click += new System.EventHandler(this.browserBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(459, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 29;
            this.label8.Text = "Summary:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 21);
            this.label9.TabIndex = 30;
            this.label9.Text = "Category:";
            // 
            // summaryTbx
            // 
            this.summaryTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.summaryTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.summaryTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.summaryTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.summaryTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.summaryTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.summaryTbx.HintForeColor = System.Drawing.Color.Empty;
            this.summaryTbx.HintText = "";
            this.summaryTbx.isPassword = false;
            this.summaryTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.summaryTbx.LineIdleColor = System.Drawing.Color.Gray;
            this.summaryTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.summaryTbx.LineThickness = 3;
            this.summaryTbx.Location = new System.Drawing.Point(578, 408);
            this.summaryTbx.Margin = new System.Windows.Forms.Padding(4);
            this.summaryTbx.MaxLength = 32767;
            this.summaryTbx.Name = "summaryTbx";
            this.summaryTbx.Size = new System.Drawing.Size(212, 33);
            this.summaryTbx.TabIndex = 33;
            this.summaryTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.summaryTbx.OnValueChanged += new System.EventHandler(this.summaryTbx_OnValueChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(367, 473);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(403, 473);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // bookDGV
            // 
            this.bookDGV.AllowCustomTheming = false;
            this.bookDGV.AllowUserToAddRows = false;
            this.bookDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.bookDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bookDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bookDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bookDGV.ColumnHeadersHeight = 40;
            this.bookDGV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bookDGV.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bookDGV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bookDGV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bookDGV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bookDGV.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bookDGV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bookDGV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bookDGV.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bookDGV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bookDGV.CurrentTheme.Name = null;
            this.bookDGV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bookDGV.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bookDGV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bookDGV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bookDGV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.bookDGV.EnableHeadersVisualStyles = false;
            this.bookDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bookDGV.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bookDGV.HeaderBgColor = System.Drawing.Color.Empty;
            this.bookDGV.HeaderForeColor = System.Drawing.Color.White;
            this.bookDGV.Location = new System.Drawing.Point(401, 129);
            this.bookDGV.Name = "bookDGV";
            this.bookDGV.ReadOnly = true;
            this.bookDGV.RowHeadersVisible = false;
            this.bookDGV.RowHeadersWidth = 51;
            this.bookDGV.RowTemplate.Height = 40;
            this.bookDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookDGV.Size = new System.Drawing.Size(439, 200);
            this.bookDGV.TabIndex = 44;
            this.bookDGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bookDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookDGV_CellClick);
            // 
            // categoryBox
            // 
            this.categoryBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(149, 469);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(212, 28);
            this.categoryBox.TabIndex = 45;
            this.categoryBox.TextChanged += new System.EventHandler(this.categoryBox_TextChanged);
            // 
            // BooksForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(884, 619);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.bookDGV);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.summaryTbx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.browserBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.imageTbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quantityTbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.publisherTbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.authorTbx);
            this.Controls.Add(this.nameTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isbnTbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BooksForm";
            this.Load += new System.EventHandler(this.BooksForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox publisherTbx;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox authorTbx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox isbnTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox imageTbx;
        private Bunifu.Framework.UI.BunifuThinButton2 editBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 deleteBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 addBtn;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 browserBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox summaryTbx;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Bunifu.UI.WinForms.BunifuDataGridView bookDGV;
        private Guna.UI2.WinForms.Guna2ImageButton viewBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox nameSearchTbx;
        private Guna.UI2.WinForms.Guna2ImageButton reloadBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox IBSNSearchTbx;
        private Guna.UI2.WinForms.Guna2ImageButton searchBtn;
        private System.Windows.Forms.ComboBox categoryBox;
        public Bunifu.Framework.UI.BunifuMaterialTextbox quantityTbx;
        private Bunifu.Framework.UI.BunifuMetroTextbox authorSearchTbx;
    }
}