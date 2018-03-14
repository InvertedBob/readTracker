namespace readTracker
{
    partial class AddCarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCarti));
            this.label1 = new System.Windows.Forms.Label();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.lblAut = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.tbTitlu = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dpISBN = new System.Windows.Forms.RadioButton();
            this.dpTitlu = new System.Windows.Forms.RadioButton();
            this.lblISBN = new System.Windows.Forms.Label();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.cautaBtn = new System.Windows.Forms.Button();
            this.defPictureBox = new System.Windows.Forms.PictureBox();
            this.lblTitluRez = new System.Windows.Forms.Label();
            this.lblAutorRez = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "READ #";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(7, 89);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(188, 20);
            this.tbAutor.TabIndex = 3;
            this.tbAutor.TextChanged += new System.EventHandler(this.tbAutor_TextChanged);
            // 
            // lblAut
            // 
            this.lblAut.AutoSize = true;
            this.lblAut.BackColor = System.Drawing.Color.Transparent;
            this.lblAut.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAut.Location = new System.Drawing.Point(6, 67);
            this.lblAut.Name = "lblAut";
            this.lblAut.Size = new System.Drawing.Size(99, 22);
            this.lblAut.TabIndex = 4;
            this.lblAut.Text = "Autor Carte";
            this.lblAut.Click += new System.EventHandler(this.lblAut_Click);
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.BackColor = System.Drawing.Color.Transparent;
            this.lblTitlu.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.Location = new System.Drawing.Point(6, 13);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(96, 22);
            this.lblTitlu.TabIndex = 6;
            this.lblTitlu.Text = "Titlu Carte*";
            // 
            // tbTitlu
            // 
            this.tbTitlu.Location = new System.Drawing.Point(7, 35);
            this.tbTitlu.Name = "tbTitlu";
            this.tbTitlu.Size = new System.Drawing.Size(188, 20);
            this.tbTitlu.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(209, 259);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dpISBN);
            this.tabPage1.Controls.Add(this.dpTitlu);
            this.tabPage1.Controls.Add(this.lblISBN);
            this.tabPage1.Controls.Add(this.tbISBN);
            this.tabPage1.Controls.Add(this.lblAut);
            this.tabPage1.Controls.Add(this.lblTitlu);
            this.tabPage1.Controls.Add(this.tbAutor);
            this.tabPage1.Controls.Add(this.tbTitlu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(201, 233);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cauta carte";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dpISBN
            // 
            this.dpISBN.AutoSize = true;
            this.dpISBN.Location = new System.Drawing.Point(7, 205);
            this.dpISBN.Name = "dpISBN";
            this.dpISBN.Size = new System.Drawing.Size(79, 17);
            this.dpISBN.TabIndex = 12;
            this.dpISBN.Text = "Dupa ISBN";
            this.dpISBN.UseVisualStyleBackColor = true;
            // 
            // dpTitlu
            // 
            this.dpTitlu.AutoSize = true;
            this.dpTitlu.Checked = true;
            this.dpTitlu.Location = new System.Drawing.Point(7, 182);
            this.dpTitlu.Name = "dpTitlu";
            this.dpTitlu.Size = new System.Drawing.Size(104, 17);
            this.dpTitlu.TabIndex = 11;
            this.dpTitlu.TabStop = true;
            this.dpTitlu.Text = "Dupa Titlu/Autor";
            this.dpTitlu.UseVisualStyleBackColor = true;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.Color.Transparent;
            this.lblISBN.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(6, 125);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(96, 22);
            this.lblISBN.TabIndex = 10;
            this.lblISBN.Text = "ISBN Carte*";
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(7, 147);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(188, 20);
            this.tbISBN.TabIndex = 9;
            // 
            // cautaBtn
            // 
            this.cautaBtn.Location = new System.Drawing.Point(12, 308);
            this.cautaBtn.Name = "cautaBtn";
            this.cautaBtn.Size = new System.Drawing.Size(82, 35);
            this.cautaBtn.TabIndex = 7;
            this.cautaBtn.Text = "Cauta";
            this.cautaBtn.UseVisualStyleBackColor = true;
            this.cautaBtn.Click += new System.EventHandler(this.cautaBtn_Click);
            // 
            // defPictureBox
            // 
            this.defPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.defPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("defPictureBox.Image")));
            this.defPictureBox.Location = new System.Drawing.Point(244, 63);
            this.defPictureBox.Name = "defPictureBox";
            this.defPictureBox.Size = new System.Drawing.Size(165, 237);
            this.defPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.defPictureBox.TabIndex = 8;
            this.defPictureBox.TabStop = false;
            // 
            // lblTitluRez
            // 
            this.lblTitluRez.AutoSize = true;
            this.lblTitluRez.Location = new System.Drawing.Point(194, 308);
            this.lblTitluRez.Name = "lblTitluRez";
            this.lblTitluRez.Size = new System.Drawing.Size(27, 13);
            this.lblTitluRez.TabIndex = 9;
            this.lblTitluRez.Text = "Titlu";
            this.lblTitluRez.Click += new System.EventHandler(this.lblTitluRez_Click);
            // 
            // lblAutorRez
            // 
            this.lblAutorRez.AutoSize = true;
            this.lblAutorRez.Location = new System.Drawing.Point(193, 330);
            this.lblAutorRez.Name = "lblAutorRez";
            this.lblAutorRez.Size = new System.Drawing.Size(32, 13);
            this.lblAutorRez.TabIndex = 10;
            this.lblAutorRez.Text = "Autor";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(106, 308);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(82, 35);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Adauga";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(12, 349);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(349, 23);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "Iesire";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // AddCarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(421, 381);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.lblAutorRez);
            this.Controls.Add(this.lblTitluRez);
            this.Controls.Add(this.defPictureBox);
            this.Controls.Add(this.cautaBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCarti";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.Label lblAut;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.TextBox tbTitlu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button cautaBtn;
        private System.Windows.Forms.RadioButton dpISBN;
        private System.Windows.Forms.RadioButton dpTitlu;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.PictureBox defPictureBox;
        private System.Windows.Forms.Label lblTitluRez;
        private System.Windows.Forms.Label lblAutorRez;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}