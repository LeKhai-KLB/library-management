
namespace Library
{
    partial class LibrarianForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.passTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NameTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.editBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.delBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.confirmTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.librarianDGV = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.idSearchTbx = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.nameSearchTbx = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.phoneSearchTbx = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarianDGV)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 31);
            this.panel2.TabIndex = 2;
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
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(796, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 57);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(340, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "LIBRARIANS";
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
            this.phoneTbx.Location = new System.Drawing.Point(149, 408);
            this.phoneTbx.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTbx.MaxLength = 32767;
            this.phoneTbx.Name = "phoneTbx";
            this.phoneTbx.Size = new System.Drawing.Size(212, 33);
            this.phoneTbx.TabIndex = 36;
            this.phoneTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phoneTbx.OnValueChanged += new System.EventHandler(this.phoneTbx_OnValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "Phone:";
            // 
            // passTbx
            // 
            this.passTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passTbx.HintForeColor = System.Drawing.Color.Empty;
            this.passTbx.HintText = "";
            this.passTbx.isPassword = false;
            this.passTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.passTbx.LineIdleColor = System.Drawing.Color.Gray;
            this.passTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.passTbx.LineThickness = 3;
            this.passTbx.Location = new System.Drawing.Point(149, 296);
            this.passTbx.Margin = new System.Windows.Forms.Padding(4);
            this.passTbx.MaxLength = 32767;
            this.passTbx.Name = "passTbx";
            this.passTbx.Size = new System.Drawing.Size(212, 33);
            this.passTbx.TabIndex = 34;
            this.passTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passTbx.OnValueChanged += new System.EventHandler(this.passTbx_OnValueChanged);
            // 
            // NameTbx
            // 
            this.NameTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.NameTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.NameTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.NameTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NameTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameTbx.HintForeColor = System.Drawing.Color.Empty;
            this.NameTbx.HintText = "";
            this.NameTbx.isPassword = false;
            this.NameTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.NameTbx.LineIdleColor = System.Drawing.Color.Gray;
            this.NameTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.NameTbx.LineThickness = 3;
            this.NameTbx.Location = new System.Drawing.Point(149, 240);
            this.NameTbx.Margin = new System.Windows.Forms.Padding(4);
            this.NameTbx.MaxLength = 32767;
            this.NameTbx.Name = "NameTbx";
            this.NameTbx.Size = new System.Drawing.Size(212, 33);
            this.NameTbx.TabIndex = 33;
            this.NameTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NameTbx.OnValueChanged += new System.EventHandler(this.NameTbx_OnValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Password:";
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
            this.idTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.idTbx.LineIdleColor = System.Drawing.Color.Gray;
            this.idTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.idTbx.LineThickness = 3;
            this.idTbx.Location = new System.Drawing.Point(149, 184);
            this.idTbx.Margin = new System.Windows.Forms.Padding(4);
            this.idTbx.MaxLength = 32767;
            this.idTbx.Name = "idTbx";
            this.idTbx.Size = new System.Drawing.Size(212, 33);
            this.idTbx.TabIndex = 30;
            this.idTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.idTbx.OnValueChanged += new System.EventHandler(this.idTbx_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "ID:";
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
            this.addBtn.Location = new System.Drawing.Point(46, 484);
            this.addBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(85, 39);
            this.addBtn.TabIndex = 38;
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
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
            this.editBtn.Location = new System.Drawing.Point(158, 484);
            this.editBtn.Margin = new System.Windows.Forms.Padding(5);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(85, 39);
            this.editBtn.TabIndex = 40;
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.ActiveBorderThickness = 1;
            this.delBtn.ActiveCornerRadius = 20;
            this.delBtn.ActiveFillColor = System.Drawing.Color.PaleVioletRed;
            this.delBtn.ActiveForecolor = System.Drawing.Color.White;
            this.delBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.delBtn.BackColor = System.Drawing.Color.MistyRose;
            this.delBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delBtn.BackgroundImage")));
            this.delBtn.ButtonText = "Delete";
            this.delBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.delBtn.IdleBorderThickness = 1;
            this.delBtn.IdleCornerRadius = 20;
            this.delBtn.IdleFillColor = System.Drawing.Color.Crimson;
            this.delBtn.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.delBtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.delBtn.Location = new System.Drawing.Point(269, 484);
            this.delBtn.Margin = new System.Windows.Forms.Padding(5);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(85, 39);
            this.delBtn.TabIndex = 39;
            this.delBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // confirmTbx
            // 
            this.confirmTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.confirmTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.confirmTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.confirmTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.confirmTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.confirmTbx.HintForeColor = System.Drawing.Color.Empty;
            this.confirmTbx.HintText = "";
            this.confirmTbx.isPassword = false;
            this.confirmTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.confirmTbx.LineIdleColor = System.Drawing.Color.Gray;
            this.confirmTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.confirmTbx.LineThickness = 3;
            this.confirmTbx.Location = new System.Drawing.Point(149, 355);
            this.confirmTbx.Margin = new System.Windows.Forms.Padding(4);
            this.confirmTbx.MaxLength = 32767;
            this.confirmTbx.Name = "confirmTbx";
            this.confirmTbx.Size = new System.Drawing.Size(212, 33);
            this.confirmTbx.TabIndex = 42;
            this.confirmTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.confirmTbx.OnValueChanged += new System.EventHandler(this.confirmTbx_OnValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 41;
            this.label6.Text = "Confirm:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
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
            // idSearchTbx
            // 
            this.idSearchTbx.BorderColorFocused = System.Drawing.Color.Blue;
            this.idSearchTbx.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idSearchTbx.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.idSearchTbx.BorderThickness = 3;
            this.idSearchTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.idSearchTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idSearchTbx.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idSearchTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idSearchTbx.isPassword = false;
            this.idSearchTbx.Location = new System.Drawing.Point(3, 416);
            this.idSearchTbx.MaxLength = 32767;
            this.idSearchTbx.Name = "idSearchTbx";
            this.idSearchTbx.Size = new System.Drawing.Size(114, 29);
            this.idSearchTbx.TabIndex = 44;
            this.idSearchTbx.Text = "ID...";
            this.idSearchTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.idSearchTbx.Enter += new System.EventHandler(this.idSearchTbx_Enter);
            this.idSearchTbx.Leave += new System.EventHandler(this.idSearchTbx_Leave);
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
            this.nameSearchTbx.Location = new System.Drawing.Point(123, 416);
            this.nameSearchTbx.MaxLength = 32767;
            this.nameSearchTbx.Name = "nameSearchTbx";
            this.nameSearchTbx.Size = new System.Drawing.Size(114, 29);
            this.nameSearchTbx.TabIndex = 45;
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
            this.phoneSearchTbx.Location = new System.Drawing.Point(243, 416);
            this.phoneSearchTbx.MaxLength = 32767;
            this.phoneSearchTbx.Name = "phoneSearchTbx";
            this.phoneSearchTbx.Size = new System.Drawing.Size(114, 29);
            this.phoneSearchTbx.TabIndex = 46;
            this.phoneSearchTbx.Text = "Phone...";
            this.phoneSearchTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phoneSearchTbx.Enter += new System.EventHandler(this.phoneSearchTbx_Enter);
            this.phoneSearchTbx.Leave += new System.EventHandler(this.phoneSearchTbx_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.guna2ImageButton1);
            this.panel3.Controls.Add(this.guna2ImageButton4);
            this.panel3.Controls.Add(this.librarianDGV);
            this.panel3.Controls.Add(this.idSearchTbx);
            this.panel3.Controls.Add(this.nameSearchTbx);
            this.panel3.Controls.Add(this.phoneSearchTbx);
            this.panel3.Location = new System.Drawing.Point(401, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 460);
            this.panel3.TabIndex = 47;
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
            // LibrarianForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(884, 638);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.confirmTbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.phoneTbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passTbx);
            this.Controls.Add(this.NameTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idTbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibrarianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrarianForm";
            this.Load += new System.EventHandler(this.LibrarianForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarianDGV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phoneTbx;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passTbx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NameTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox idTbx;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 addBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 editBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 delBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox confirmTbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Bunifu.UI.WinForms.BunifuDataGridView librarianDGV;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox idSearchTbx;
        private Bunifu.Framework.UI.BunifuMetroTextbox nameSearchTbx;
        private Bunifu.Framework.UI.BunifuMetroTextbox phoneSearchTbx;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}