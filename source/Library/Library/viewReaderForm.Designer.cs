
namespace Library
{
    partial class viewReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewReaderForm));
            this.readerPic = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.nameTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adrTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.editBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.readerPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // readerPic
            // 
            this.readerPic.BaseColor = System.Drawing.Color.White;
            this.readerPic.Location = new System.Drawing.Point(33, 64);
            this.readerPic.Name = "readerPic";
            this.readerPic.Size = new System.Drawing.Size(259, 259);
            this.readerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.readerPic.TabIndex = 0;
            this.readerPic.TabStop = false;
            this.readerPic.UseTransfarantBackground = false;
            // 
            // nameTbx
            // 
            this.nameTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nameTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nameTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTbx.Enabled = false;
            this.nameTbx.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTbx.ForeColor = System.Drawing.Color.Crimson;
            this.nameTbx.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTbx.HintText = "";
            this.nameTbx.isPassword = false;
            this.nameTbx.LineFocusedColor = System.Drawing.Color.Crimson;
            this.nameTbx.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.nameTbx.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.nameTbx.LineThickness = 3;
            this.nameTbx.Location = new System.Drawing.Point(353, 90);
            this.nameTbx.Margin = new System.Windows.Forms.Padding(4);
            this.nameTbx.MaxLength = 32767;
            this.nameTbx.Name = "nameTbx";
            this.nameTbx.Size = new System.Drawing.Size(293, 33);
            this.nameTbx.TabIndex = 31;
            this.nameTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(349, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(349, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "Address:";
            // 
            // adrTbx
            // 
            this.adrTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.adrTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.adrTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.adrTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adrTbx.Enabled = false;
            this.adrTbx.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adrTbx.ForeColor = System.Drawing.Color.Crimson;
            this.adrTbx.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adrTbx.HintText = "";
            this.adrTbx.isPassword = false;
            this.adrTbx.LineFocusedColor = System.Drawing.Color.Crimson;
            this.adrTbx.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.adrTbx.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.adrTbx.LineThickness = 3;
            this.adrTbx.Location = new System.Drawing.Point(353, 191);
            this.adrTbx.Margin = new System.Windows.Forms.Padding(4);
            this.adrTbx.MaxLength = 32767;
            this.adrTbx.Name = "adrTbx";
            this.adrTbx.Size = new System.Drawing.Size(293, 33);
            this.adrTbx.TabIndex = 33;
            this.adrTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(349, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 36;
            this.label3.Text = "Phone:";
            // 
            // phoneTbx
            // 
            this.phoneTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.phoneTbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.phoneTbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.phoneTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTbx.Enabled = false;
            this.phoneTbx.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTbx.ForeColor = System.Drawing.Color.Crimson;
            this.phoneTbx.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phoneTbx.HintText = "";
            this.phoneTbx.isPassword = false;
            this.phoneTbx.LineFocusedColor = System.Drawing.Color.Crimson;
            this.phoneTbx.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.phoneTbx.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.phoneTbx.LineThickness = 3;
            this.phoneTbx.Location = new System.Drawing.Point(353, 292);
            this.phoneTbx.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTbx.MaxLength = 32767;
            this.phoneTbx.Name = "phoneTbx";
            this.phoneTbx.Size = new System.Drawing.Size(293, 33);
            this.phoneTbx.TabIndex = 35;
            this.phoneTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.editBtn.Location = new System.Drawing.Point(300, 356);
            this.editBtn.Margin = new System.Windows.Forms.Padding(5);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(85, 39);
            this.editBtn.TabIndex = 41;
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(636, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // viewReaderForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(682, 420);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneTbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adrTbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTbx);
            this.Controls.Add(this.readerPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewReaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewReaderForm";
            this.Load += new System.EventHandler(this.viewReaderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.readerPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox readerPic;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adrTbx;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phoneTbx;
        private Bunifu.Framework.UI.BunifuThinButton2 editBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}