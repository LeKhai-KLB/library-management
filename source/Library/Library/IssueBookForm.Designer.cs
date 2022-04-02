
namespace Library
{
    partial class IssueBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBookForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.loadBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.issueBookDGV = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.searchBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.isbnSearchTbx = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.phoneSearchTbx = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReaderBox = new System.Windows.Forms.ComboBox();
            this.boxBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.editBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.deleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.addBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.isbnTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issueBookDGV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            this.panel1.TabIndex = 28;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.loadBtn);
            this.panel3.Controls.Add(this.issueBookDGV);
            this.panel3.Controls.Add(this.searchBtn);
            this.panel3.Controls.Add(this.isbnSearchTbx);
            this.panel3.Controls.Add(this.phoneSearchTbx);
            this.panel3.Location = new System.Drawing.Point(401, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 460);
            this.panel3.TabIndex = 30;
            // 
            // loadBtn
            // 
            this.loadBtn.CheckedState.Parent = this.loadBtn;
            this.loadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadBtn.HoverState.Parent = this.loadBtn;
            this.loadBtn.Image = ((System.Drawing.Image)(resources.GetObject("loadBtn.Image")));
            this.loadBtn.Location = new System.Drawing.Point(406, 416);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.PressedState.Parent = this.loadBtn;
            this.loadBtn.Size = new System.Drawing.Size(29, 29);
            this.loadBtn.TabIndex = 55;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // issueBookDGV
            // 
            this.issueBookDGV.AllowCustomTheming = false;
            this.issueBookDGV.AllowUserToAddRows = false;
            this.issueBookDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            this.issueBookDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.issueBookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.issueBookDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.issueBookDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.issueBookDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.issueBookDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.issueBookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.issueBookDGV.ColumnHeadersHeight = 40;
            this.issueBookDGV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.issueBookDGV.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.issueBookDGV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.issueBookDGV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.issueBookDGV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.issueBookDGV.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.issueBookDGV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.issueBookDGV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.issueBookDGV.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.issueBookDGV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.issueBookDGV.CurrentTheme.Name = null;
            this.issueBookDGV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.issueBookDGV.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.issueBookDGV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.issueBookDGV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.issueBookDGV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.issueBookDGV.DefaultCellStyle = dataGridViewCellStyle24;
            this.issueBookDGV.EnableHeadersVisualStyles = false;
            this.issueBookDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.issueBookDGV.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.issueBookDGV.HeaderBgColor = System.Drawing.Color.Empty;
            this.issueBookDGV.HeaderForeColor = System.Drawing.Color.White;
            this.issueBookDGV.Location = new System.Drawing.Point(0, 0);
            this.issueBookDGV.Name = "issueBookDGV";
            this.issueBookDGV.ReadOnly = true;
            this.issueBookDGV.RowHeadersVisible = false;
            this.issueBookDGV.RowHeadersWidth = 51;
            this.issueBookDGV.RowTemplate.Height = 40;
            this.issueBookDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.issueBookDGV.Size = new System.Drawing.Size(439, 396);
            this.issueBookDGV.TabIndex = 48;
            this.issueBookDGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.issueBookDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.issueBookDGV_CellClick);
            // 
            // searchBtn
            // 
            this.searchBtn.CheckedState.Parent = this.searchBtn;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.HoverState.Parent = this.searchBtn;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(371, 416);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.PressedState.Parent = this.searchBtn;
            this.searchBtn.Size = new System.Drawing.Size(29, 29);
            this.searchBtn.TabIndex = 54;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // isbnSearchTbx
            // 
            this.isbnSearchTbx.BorderColorFocused = System.Drawing.Color.Blue;
            this.isbnSearchTbx.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.isbnSearchTbx.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.isbnSearchTbx.BorderThickness = 3;
            this.isbnSearchTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.isbnSearchTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.isbnSearchTbx.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnSearchTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.isbnSearchTbx.isPassword = false;
            this.isbnSearchTbx.Location = new System.Drawing.Point(125, 416);
            this.isbnSearchTbx.MaxLength = 32767;
            this.isbnSearchTbx.Name = "isbnSearchTbx";
            this.isbnSearchTbx.Size = new System.Drawing.Size(114, 29);
            this.isbnSearchTbx.TabIndex = 53;
            this.isbnSearchTbx.Text = "ISBN...";
            this.isbnSearchTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.isbnSearchTbx.Enter += new System.EventHandler(this.isbnSearchTbx_Enter);
            this.isbnSearchTbx.Leave += new System.EventHandler(this.isbnSearchTbx_Leave);
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
            this.phoneSearchTbx.Location = new System.Drawing.Point(5, 416);
            this.phoneSearchTbx.MaxLength = 32767;
            this.phoneSearchTbx.Name = "phoneSearchTbx";
            this.phoneSearchTbx.Size = new System.Drawing.Size(114, 29);
            this.phoneSearchTbx.TabIndex = 52;
            this.phoneSearchTbx.Text = "Phone...";
            this.phoneSearchTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phoneSearchTbx.Enter += new System.EventHandler(this.phoneSearchTbx_Enter);
            this.phoneSearchTbx.Leave += new System.EventHandler(this.phoneSearchTbx_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 57);
            this.panel2.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(336, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "ISSUE BOOK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "Book:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Reader:";
            // 
            // ReaderBox
            // 
            this.ReaderBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ReaderBox.FormattingEnabled = true;
            this.ReaderBox.Location = new System.Drawing.Point(140, 193);
            this.ReaderBox.Name = "ReaderBox";
            this.ReaderBox.Size = new System.Drawing.Size(211, 24);
            this.ReaderBox.TabIndex = 38;
            this.ReaderBox.SelectedIndexChanged += new System.EventHandler(this.ReaderBox_SelectedIndexChanged);
            this.ReaderBox.TextChanged += new System.EventHandler(this.ReaderBox_TextChanged);
            // 
            // boxBox
            // 
            this.boxBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.boxBox.FormattingEnabled = true;
            this.boxBox.Location = new System.Drawing.Point(140, 305);
            this.boxBox.Name = "boxBox";
            this.boxBox.Size = new System.Drawing.Size(211, 24);
            this.boxBox.TabIndex = 39;
            this.boxBox.SelectedIndexChanged += new System.EventHandler(this.boxBox_SelectedIndexChanged);
            this.boxBox.TextChanged += new System.EventHandler(this.boxBox_TextChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.BackColor = System.Drawing.Color.SeaGreen;
            this.dateTimePicker.BorderRadius = 0;
            this.dateTimePicker.ForeColor = System.Drawing.Color.White;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker.FormatCustom = null;
            this.dateTimePicker.Location = new System.Drawing.Point(140, 415);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(211, 39);
            this.dateTimePicker.TabIndex = 40;
            this.dateTimePicker.Value = new System.DateTime(2021, 8, 19, 11, 25, 13, 937);
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
            this.editBtn.Location = new System.Drawing.Point(153, 496);
            this.editBtn.Margin = new System.Windows.Forms.Padding(5);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(85, 39);
            this.editBtn.TabIndex = 43;
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
            this.deleteBtn.Location = new System.Drawing.Point(264, 496);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(85, 39);
            this.deleteBtn.TabIndex = 42;
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
            this.addBtn.Location = new System.Drawing.Point(41, 496);
            this.addBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(85, 39);
            this.addBtn.TabIndex = 41;
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 45;
            this.label6.Text = "ISBN:";
            // 
            // phoneTbx
            // 
            this.phoneTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.phoneTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.phoneTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.phoneTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTbx.Enabled = false;
            this.phoneTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.phoneTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phoneTbx.HintForeColor = System.Drawing.Color.Empty;
            this.phoneTbx.HintText = "";
            this.phoneTbx.isPassword = false;
            this.phoneTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.phoneTbx.LineIdleColor = System.Drawing.Color.Gray;
            this.phoneTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.phoneTbx.LineThickness = 3;
            this.phoneTbx.Location = new System.Drawing.Point(139, 240);
            this.phoneTbx.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTbx.MaxLength = 32767;
            this.phoneTbx.Name = "phoneTbx";
            this.phoneTbx.Size = new System.Drawing.Size(212, 33);
            this.phoneTbx.TabIndex = 46;
            this.phoneTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // isbnTbx
            // 
            this.isbnTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.isbnTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.isbnTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.isbnTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.isbnTbx.Enabled = false;
            this.isbnTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.isbnTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.isbnTbx.HintForeColor = System.Drawing.Color.Empty;
            this.isbnTbx.HintText = "";
            this.isbnTbx.isPassword = false;
            this.isbnTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.isbnTbx.LineIdleColor = System.Drawing.Color.Gray;
            this.isbnTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.isbnTbx.LineThickness = 3;
            this.isbnTbx.Location = new System.Drawing.Point(139, 352);
            this.isbnTbx.Margin = new System.Windows.Forms.Padding(4);
            this.isbnTbx.MaxLength = 32767;
            this.isbnTbx.Name = "isbnTbx";
            this.isbnTbx.Size = new System.Drawing.Size(212, 33);
            this.isbnTbx.TabIndex = 47;
            this.isbnTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // IssueBookForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(884, 638);
            this.Controls.Add(this.isbnTbx);
            this.Controls.Add(this.phoneTbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.boxBox);
            this.Controls.Add(this.ReaderBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueBookForm";
            this.Load += new System.EventHandler(this.IssueBookForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.issueBookDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ReaderBox;
        private System.Windows.Forms.ComboBox boxBox;
        private Bunifu.Framework.UI.BunifuDatepicker dateTimePicker;
        private Bunifu.Framework.UI.BunifuThinButton2 editBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 deleteBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 addBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phoneTbx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox isbnTbx;
        private Bunifu.UI.WinForms.BunifuDataGridView issueBookDGV;
        private Guna.UI2.WinForms.Guna2ImageButton loadBtn;
        private Guna.UI2.WinForms.Guna2ImageButton searchBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox isbnSearchTbx;
        private Bunifu.Framework.UI.BunifuMetroTextbox phoneSearchTbx;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}