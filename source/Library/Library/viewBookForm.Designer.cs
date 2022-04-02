
namespace Library
{
    partial class viewBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewBookForm));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.editBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.authorTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.isbnTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.publisherTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.sumaryTbx = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // editBtn
            // 
            this.editBtn.ActiveBorderThickness = 1;
            this.editBtn.ActiveCornerRadius = 20;
            this.editBtn.ActiveFillColor = System.Drawing.Color.PaleGreen;
            this.editBtn.ActiveForecolor = System.Drawing.Color.Transparent;
            this.editBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.editBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.editBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editBtn.BackgroundImage")));
            this.editBtn.ButtonText = "OK";
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editBtn.IdleBorderThickness = 1;
            this.editBtn.IdleCornerRadius = 20;
            this.editBtn.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.editBtn.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.editBtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.editBtn.Location = new System.Drawing.Point(351, 777);
            this.editBtn.Margin = new System.Windows.Forms.Padding(5);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(85, 39);
            this.editBtn.TabIndex = 48;
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(408, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 47;
            this.label3.Text = "Author:";
            // 
            // authorTbx
            // 
            this.authorTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.authorTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.authorTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.authorTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.authorTbx.Enabled = false;
            this.authorTbx.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTbx.ForeColor = System.Drawing.Color.Crimson;
            this.authorTbx.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.authorTbx.HintText = "";
            this.authorTbx.isPassword = false;
            this.authorTbx.LineFocusedColor = System.Drawing.Color.Crimson;
            this.authorTbx.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.authorTbx.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.authorTbx.LineThickness = 3;
            this.authorTbx.Location = new System.Drawing.Point(412, 288);
            this.authorTbx.Margin = new System.Windows.Forms.Padding(4);
            this.authorTbx.MaxLength = 32767;
            this.authorTbx.Name = "authorTbx";
            this.authorTbx.Size = new System.Drawing.Size(334, 32);
            this.authorTbx.TabIndex = 46;
            this.authorTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(408, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 45;
            this.label1.Text = "Name:";
            // 
            // nameTbx
            // 
            this.nameTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nameTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nameTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTbx.Enabled = false;
            this.nameTbx.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTbx.ForeColor = System.Drawing.Color.Crimson;
            this.nameTbx.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTbx.HintText = "";
            this.nameTbx.isPassword = false;
            this.nameTbx.LineFocusedColor = System.Drawing.Color.Crimson;
            this.nameTbx.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.nameTbx.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.nameTbx.LineThickness = 3;
            this.nameTbx.Location = new System.Drawing.Point(412, 187);
            this.nameTbx.Margin = new System.Windows.Forms.Padding(4);
            this.nameTbx.MaxLength = 32767;
            this.nameTbx.Name = "nameTbx";
            this.nameTbx.Size = new System.Drawing.Size(334, 32);
            this.nameTbx.TabIndex = 44;
            this.nameTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(408, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "ISBN:";
            // 
            // isbnTbx
            // 
            this.isbnTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.isbnTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.isbnTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.isbnTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.isbnTbx.Enabled = false;
            this.isbnTbx.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnTbx.ForeColor = System.Drawing.Color.Crimson;
            this.isbnTbx.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.isbnTbx.HintText = "";
            this.isbnTbx.isPassword = false;
            this.isbnTbx.LineFocusedColor = System.Drawing.Color.Crimson;
            this.isbnTbx.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.isbnTbx.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.isbnTbx.LineThickness = 3;
            this.isbnTbx.Location = new System.Drawing.Point(412, 90);
            this.isbnTbx.Margin = new System.Windows.Forms.Padding(4);
            this.isbnTbx.MaxLength = 32767;
            this.isbnTbx.Name = "isbnTbx";
            this.isbnTbx.Size = new System.Drawing.Size(334, 32);
            this.isbnTbx.TabIndex = 42;
            this.isbnTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(408, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 50;
            this.label4.Text = "Publisher:";
            // 
            // publisherTbx
            // 
            this.publisherTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.publisherTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.publisherTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.publisherTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.publisherTbx.Enabled = false;
            this.publisherTbx.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherTbx.ForeColor = System.Drawing.Color.Crimson;
            this.publisherTbx.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.publisherTbx.HintText = "";
            this.publisherTbx.isPassword = false;
            this.publisherTbx.LineFocusedColor = System.Drawing.Color.Crimson;
            this.publisherTbx.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.publisherTbx.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.publisherTbx.LineThickness = 3;
            this.publisherTbx.Location = new System.Drawing.Point(412, 389);
            this.publisherTbx.Margin = new System.Windows.Forms.Padding(4);
            this.publisherTbx.MaxLength = 32767;
            this.publisherTbx.Name = "publisherTbx";
            this.publisherTbx.Size = new System.Drawing.Size(334, 32);
            this.publisherTbx.TabIndex = 49;
            this.publisherTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(408, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 52;
            this.label5.Text = "Category:";
            // 
            // categoryTbx
            // 
            this.categoryTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.categoryTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.categoryTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.categoryTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categoryTbx.Enabled = false;
            this.categoryTbx.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTbx.ForeColor = System.Drawing.Color.Crimson;
            this.categoryTbx.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.categoryTbx.HintText = "";
            this.categoryTbx.isPassword = false;
            this.categoryTbx.LineFocusedColor = System.Drawing.Color.Crimson;
            this.categoryTbx.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.categoryTbx.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.categoryTbx.LineThickness = 3;
            this.categoryTbx.Location = new System.Drawing.Point(412, 490);
            this.categoryTbx.Margin = new System.Windows.Forms.Padding(4);
            this.categoryTbx.MaxLength = 32767;
            this.categoryTbx.Name = "categoryTbx";
            this.categoryTbx.Size = new System.Drawing.Size(334, 32);
            this.categoryTbx.TabIndex = 51;
            this.categoryTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(743, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(49, 63);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(312, 459);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 54;
            this.gunaPictureBox1.TabStop = false;
            // 
            // sumaryTbx
            // 
            this.sumaryTbx.AcceptsReturn = false;
            this.sumaryTbx.AcceptsTab = false;
            this.sumaryTbx.AnimationSpeed = 200;
            this.sumaryTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.sumaryTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.sumaryTbx.BackColor = System.Drawing.Color.Transparent;
            this.sumaryTbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sumaryTbx.BackgroundImage")));
            this.sumaryTbx.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.sumaryTbx.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.sumaryTbx.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.sumaryTbx.BorderColorIdle = System.Drawing.Color.Silver;
            this.sumaryTbx.BorderRadius = 1;
            this.sumaryTbx.BorderThickness = 1;
            this.sumaryTbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.sumaryTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sumaryTbx.DefaultFont = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.sumaryTbx.DefaultText = "";
            this.sumaryTbx.Enabled = false;
            this.sumaryTbx.FillColor = System.Drawing.Color.FloralWhite;
            this.sumaryTbx.HideSelection = true;
            this.sumaryTbx.IconLeft = null;
            this.sumaryTbx.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.sumaryTbx.IconPadding = 10;
            this.sumaryTbx.IconRight = null;
            this.sumaryTbx.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.sumaryTbx.Lines = new string[0];
            this.sumaryTbx.Location = new System.Drawing.Point(49, 618);
            this.sumaryTbx.MaxLength = 32767;
            this.sumaryTbx.MinimumSize = new System.Drawing.Size(100, 35);
            this.sumaryTbx.Modified = false;
            this.sumaryTbx.Multiline = true;
            this.sumaryTbx.Name = "sumaryTbx";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.sumaryTbx.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.sumaryTbx.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.sumaryTbx.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.FloralWhite;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.sumaryTbx.OnIdleState = stateProperties4;
            this.sumaryTbx.PasswordChar = '\0';
            this.sumaryTbx.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.sumaryTbx.PlaceholderText = "Enter text";
            this.sumaryTbx.ReadOnly = false;
            this.sumaryTbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sumaryTbx.SelectedText = "";
            this.sumaryTbx.SelectionLength = 0;
            this.sumaryTbx.SelectionStart = 0;
            this.sumaryTbx.ShortcutsEnabled = true;
            this.sumaryTbx.Size = new System.Drawing.Size(697, 137);
            this.sumaryTbx.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.sumaryTbx.TabIndex = 56;
            this.sumaryTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sumaryTbx.TextMarginBottom = 0;
            this.sumaryTbx.TextMarginLeft = 5;
            this.sumaryTbx.TextMarginTop = 0;
            this.sumaryTbx.TextPlaceholder = "Enter text";
            this.sumaryTbx.UseSystemPasswordChar = false;
            this.sumaryTbx.WordWrap = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(45, 566);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 57;
            this.label6.Text = "Summary:";
            // 
            // viewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(789, 835);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sumaryTbx);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.categoryTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.publisherTbx);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.authorTbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isbnTbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewBookForm";
            this.Load += new System.EventHandler(this.viewBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 editBtn;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox authorTbx;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameTbx;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox isbnTbx;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox publisherTbx;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox categoryTbx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox sumaryTbx;
        private System.Windows.Forms.Label label6;
    }
}