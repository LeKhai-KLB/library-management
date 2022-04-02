
namespace Library
{
    partial class ReturnBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.isbnSearchTbx = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.loadIssueBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.phoneSearchTbx = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.searchIssueBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.returnDGV = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.loadReturnBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.searchReturnBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.idSearchTbx = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.isbnTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.phoneTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.exportBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.returnBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.issueDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.returnDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.deleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.issueDGV = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.returnedCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 31);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 57);
            this.panel2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(315, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "RETURN BOOK";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.isbnSearchTbx);
            this.panel3.Controls.Add(this.loadIssueBtn);
            this.panel3.Controls.Add(this.phoneSearchTbx);
            this.panel3.Controls.Add(this.searchIssueBtn);
            this.panel3.Location = new System.Drawing.Point(401, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 172);
            this.panel3.TabIndex = 33;
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
            this.isbnSearchTbx.Location = new System.Drawing.Point(125, 135);
            this.isbnSearchTbx.MaxLength = 32767;
            this.isbnSearchTbx.Name = "isbnSearchTbx";
            this.isbnSearchTbx.Size = new System.Drawing.Size(114, 29);
            this.isbnSearchTbx.TabIndex = 67;
            this.isbnSearchTbx.Text = "ISBN...";
            this.isbnSearchTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.isbnSearchTbx.Enter += new System.EventHandler(this.isbnSearchTbx_Enter);
            this.isbnSearchTbx.Leave += new System.EventHandler(this.isbnSearchTbx_Leave);
            // 
            // loadIssueBtn
            // 
            this.loadIssueBtn.CheckedState.Parent = this.loadIssueBtn;
            this.loadIssueBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadIssueBtn.HoverState.Parent = this.loadIssueBtn;
            this.loadIssueBtn.Image = ((System.Drawing.Image)(resources.GetObject("loadIssueBtn.Image")));
            this.loadIssueBtn.Location = new System.Drawing.Point(406, 135);
            this.loadIssueBtn.Name = "loadIssueBtn";
            this.loadIssueBtn.PressedState.Parent = this.loadIssueBtn;
            this.loadIssueBtn.Size = new System.Drawing.Size(29, 29);
            this.loadIssueBtn.TabIndex = 69;
            this.loadIssueBtn.Click += new System.EventHandler(this.loadIssueBtn_Click);
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
            this.phoneSearchTbx.Location = new System.Drawing.Point(5, 135);
            this.phoneSearchTbx.MaxLength = 32767;
            this.phoneSearchTbx.Name = "phoneSearchTbx";
            this.phoneSearchTbx.Size = new System.Drawing.Size(114, 29);
            this.phoneSearchTbx.TabIndex = 66;
            this.phoneSearchTbx.Text = "Phone...";
            this.phoneSearchTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phoneSearchTbx.Enter += new System.EventHandler(this.phoneSearchTbx_Enter);
            this.phoneSearchTbx.Leave += new System.EventHandler(this.phoneSearchTbx_Leave);
            // 
            // searchIssueBtn
            // 
            this.searchIssueBtn.CheckedState.Parent = this.searchIssueBtn;
            this.searchIssueBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchIssueBtn.HoverState.Parent = this.searchIssueBtn;
            this.searchIssueBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchIssueBtn.Image")));
            this.searchIssueBtn.Location = new System.Drawing.Point(371, 135);
            this.searchIssueBtn.Name = "searchIssueBtn";
            this.searchIssueBtn.PressedState.Parent = this.searchIssueBtn;
            this.searchIssueBtn.Size = new System.Drawing.Size(29, 29);
            this.searchIssueBtn.TabIndex = 68;
            this.searchIssueBtn.Click += new System.EventHandler(this.searchIssueBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.returnDGV);
            this.panel4.Controls.Add(this.loadReturnBtn);
            this.panel4.Controls.Add(this.searchReturnBtn);
            this.panel4.Controls.Add(this.idSearchTbx);
            this.panel4.Location = new System.Drawing.Point(401, 379);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(439, 172);
            this.panel4.TabIndex = 34;
            // 
            // returnDGV
            // 
            this.returnDGV.AllowCustomTheming = false;
            this.returnDGV.AllowUserToAddRows = false;
            this.returnDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.returnDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.returnDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.returnDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.returnDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.returnDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.returnDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.returnDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.returnDGV.ColumnHeadersHeight = 40;
            this.returnDGV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.returnDGV.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.returnDGV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.returnDGV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.returnDGV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.returnDGV.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.returnDGV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.returnDGV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.returnDGV.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.returnDGV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.returnDGV.CurrentTheme.Name = null;
            this.returnDGV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.returnDGV.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.returnDGV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.returnDGV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.returnDGV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.returnDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.returnDGV.EnableHeadersVisualStyles = false;
            this.returnDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.returnDGV.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.returnDGV.HeaderBgColor = System.Drawing.Color.Empty;
            this.returnDGV.HeaderForeColor = System.Drawing.Color.White;
            this.returnDGV.Location = new System.Drawing.Point(0, 0);
            this.returnDGV.Name = "returnDGV";
            this.returnDGV.ReadOnly = true;
            this.returnDGV.RowHeadersVisible = false;
            this.returnDGV.RowHeadersWidth = 51;
            this.returnDGV.RowTemplate.Height = 40;
            this.returnDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.returnDGV.Size = new System.Drawing.Size(439, 129);
            this.returnDGV.TabIndex = 66;
            this.returnDGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.returnDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.returnDGV_CellClick);
            // 
            // loadReturnBtn
            // 
            this.loadReturnBtn.CheckedState.Parent = this.loadReturnBtn;
            this.loadReturnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadReturnBtn.HoverState.Parent = this.loadReturnBtn;
            this.loadReturnBtn.Image = ((System.Drawing.Image)(resources.GetObject("loadReturnBtn.Image")));
            this.loadReturnBtn.Location = new System.Drawing.Point(406, 135);
            this.loadReturnBtn.Name = "loadReturnBtn";
            this.loadReturnBtn.PressedState.Parent = this.loadReturnBtn;
            this.loadReturnBtn.Size = new System.Drawing.Size(29, 29);
            this.loadReturnBtn.TabIndex = 69;
            this.loadReturnBtn.Click += new System.EventHandler(this.loadReturnBtn_Click);
            // 
            // searchReturnBtn
            // 
            this.searchReturnBtn.CheckedState.Parent = this.searchReturnBtn;
            this.searchReturnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchReturnBtn.HoverState.Parent = this.searchReturnBtn;
            this.searchReturnBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchReturnBtn.Image")));
            this.searchReturnBtn.Location = new System.Drawing.Point(371, 135);
            this.searchReturnBtn.Name = "searchReturnBtn";
            this.searchReturnBtn.PressedState.Parent = this.searchReturnBtn;
            this.searchReturnBtn.Size = new System.Drawing.Size(29, 29);
            this.searchReturnBtn.TabIndex = 68;
            this.searchReturnBtn.Click += new System.EventHandler(this.searchReturnBtn_Click);
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
            this.idSearchTbx.Location = new System.Drawing.Point(5, 135);
            this.idSearchTbx.MaxLength = 32767;
            this.idSearchTbx.Name = "idSearchTbx";
            this.idSearchTbx.Size = new System.Drawing.Size(114, 29);
            this.idSearchTbx.TabIndex = 66;
            this.idSearchTbx.Text = "ID...";
            this.idSearchTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.idSearchTbx.Enter += new System.EventHandler(this.idSearchTbx_Enter);
            this.idSearchTbx.Leave += new System.EventHandler(this.idSearchTbx_Leave);
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
            this.isbnTbx.Location = new System.Drawing.Point(147, 240);
            this.isbnTbx.Margin = new System.Windows.Forms.Padding(4);
            this.isbnTbx.MaxLength = 32767;
            this.isbnTbx.Name = "isbnTbx";
            this.isbnTbx.Size = new System.Drawing.Size(212, 33);
            this.isbnTbx.TabIndex = 60;
            this.isbnTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.phoneTbx.Location = new System.Drawing.Point(148, 184);
            this.phoneTbx.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTbx.MaxLength = 32767;
            this.phoneTbx.Name = "phoneTbx";
            this.phoneTbx.Size = new System.Drawing.Size(212, 33);
            this.phoneTbx.TabIndex = 59;
            this.phoneTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 58;
            this.label6.Text = "ISBN:";
            // 
            // exportBtn
            // 
            this.exportBtn.ActiveBorderThickness = 1;
            this.exportBtn.ActiveCornerRadius = 20;
            this.exportBtn.ActiveFillColor = System.Drawing.Color.PaleGreen;
            this.exportBtn.ActiveForecolor = System.Drawing.Color.White;
            this.exportBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.exportBtn.BackColor = System.Drawing.Color.MistyRose;
            this.exportBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exportBtn.BackgroundImage")));
            this.exportBtn.ButtonText = "Export";
            this.exportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exportBtn.IdleBorderThickness = 1;
            this.exportBtn.IdleCornerRadius = 20;
            this.exportBtn.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.exportBtn.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.exportBtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.exportBtn.Location = new System.Drawing.Point(499, 559);
            this.exportBtn.Margin = new System.Windows.Forms.Padding(5);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(85, 39);
            this.exportBtn.TabIndex = 56;
            this.exportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.ActiveBorderThickness = 1;
            this.returnBtn.ActiveCornerRadius = 20;
            this.returnBtn.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
            this.returnBtn.ActiveForecolor = System.Drawing.Color.White;
            this.returnBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.returnBtn.BackColor = System.Drawing.Color.MistyRose;
            this.returnBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("returnBtn.BackgroundImage")));
            this.returnBtn.ButtonText = "Return";
            this.returnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.returnBtn.IdleBorderThickness = 1;
            this.returnBtn.IdleCornerRadius = 20;
            this.returnBtn.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.returnBtn.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.returnBtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.returnBtn.Location = new System.Drawing.Point(169, 472);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(5);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(85, 39);
            this.returnBtn.TabIndex = 54;
            this.returnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // issueDate
            // 
            this.issueDate.BackColor = System.Drawing.Color.SeaGreen;
            this.issueDate.BorderRadius = 0;
            this.issueDate.ForeColor = System.Drawing.Color.White;
            this.issueDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.issueDate.FormatCustom = null;
            this.issueDate.Location = new System.Drawing.Point(148, 303);
            this.issueDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.issueDate.Name = "issueDate";
            this.issueDate.Size = new System.Drawing.Size(211, 42);
            this.issueDate.TabIndex = 53;
            this.issueDate.Value = new System.DateTime(2021, 8, 19, 11, 25, 13, 937);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "Issue:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 61;
            this.label7.Text = "Return:";
            // 
            // returnDate
            // 
            this.returnDate.BackColor = System.Drawing.Color.SeaGreen;
            this.returnDate.BorderRadius = 0;
            this.returnDate.ForeColor = System.Drawing.Color.White;
            this.returnDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.returnDate.FormatCustom = null;
            this.returnDate.Location = new System.Drawing.Point(147, 359);
            this.returnDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(211, 42);
            this.returnDate.TabIndex = 62;
            this.returnDate.Value = new System.DateTime(2021, 8, 19, 11, 25, 13, 937);
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
            this.deleteBtn.Location = new System.Drawing.Point(678, 559);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(85, 39);
            this.deleteBtn.TabIndex = 63;
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(559, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 28);
            this.label8.TabIndex = 5;
            this.label8.Text = "ISSUE BOOK";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(548, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 28);
            this.label9.TabIndex = 64;
            this.label9.Text = "RETURN BOOK";
            // 
            // issueDGV
            // 
            this.issueDGV.AllowCustomTheming = false;
            this.issueDGV.AllowUserToAddRows = false;
            this.issueDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.issueDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.issueDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.issueDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.issueDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.issueDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.issueDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.issueDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.issueDGV.ColumnHeadersHeight = 40;
            this.issueDGV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.issueDGV.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.issueDGV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.issueDGV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.issueDGV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.issueDGV.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.issueDGV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.issueDGV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.issueDGV.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.issueDGV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.issueDGV.CurrentTheme.Name = null;
            this.issueDGV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.issueDGV.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.issueDGV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.issueDGV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.issueDGV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.issueDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.issueDGV.EnableHeadersVisualStyles = false;
            this.issueDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.issueDGV.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.issueDGV.HeaderBgColor = System.Drawing.Color.Empty;
            this.issueDGV.HeaderForeColor = System.Drawing.Color.White;
            this.issueDGV.Location = new System.Drawing.Point(401, 144);
            this.issueDGV.Name = "issueDGV";
            this.issueDGV.ReadOnly = true;
            this.issueDGV.RowHeadersVisible = false;
            this.issueDGV.RowHeadersWidth = 51;
            this.issueDGV.RowTemplate.Height = 40;
            this.issueDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.issueDGV.Size = new System.Drawing.Size(439, 129);
            this.issueDGV.TabIndex = 65;
            this.issueDGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.issueDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.issueDGV_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 50;
            this.label4.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 66;
            this.label2.Text = "Returned:";
            // 
            // returnedCheckBox
            // 
            this.returnedCheckBox.BaseColor = System.Drawing.Color.White;
            this.returnedCheckBox.CheckedOffColor = System.Drawing.Color.Gray;
            this.returnedCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.returnedCheckBox.Enabled = false;
            this.returnedCheckBox.FillColor = System.Drawing.Color.White;
            this.returnedCheckBox.Location = new System.Drawing.Point(147, 421);
            this.returnedCheckBox.Name = "returnedCheckBox";
            this.returnedCheckBox.Size = new System.Drawing.Size(20, 20);
            this.returnedCheckBox.TabIndex = 68;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // ReturnBookForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(884, 638);
            this.Controls.Add(this.returnedCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.issueDGV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.isbnTbx);
            this.Controls.Add(this.phoneTbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.issueDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBookForm";
            this.Load += new System.EventHandler(this.ReturnBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.returnDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox isbnTbx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phoneTbx;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 exportBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 returnBtn;
        private Bunifu.Framework.UI.BunifuDatepicker issueDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDatepicker returnDate;
        private Bunifu.Framework.UI.BunifuThinButton2 deleteBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Bunifu.UI.WinForms.BunifuDataGridView returnDGV;
        private Bunifu.UI.WinForms.BunifuDataGridView issueDGV;
        private Bunifu.Framework.UI.BunifuMetroTextbox isbnSearchTbx;
        private Guna.UI2.WinForms.Guna2ImageButton loadIssueBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox phoneSearchTbx;
        private Guna.UI2.WinForms.Guna2ImageButton searchIssueBtn;
        private Guna.UI2.WinForms.Guna2ImageButton loadReturnBtn;
        private Guna.UI2.WinForms.Guna2ImageButton searchReturnBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox idSearchTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaCheckBox returnedCheckBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}