namespace readTracker
{
    partial class EditCarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCarti));
            this.label1 = new System.Windows.Forms.Label();
            this.defPictureBox = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.stergCrt = new System.Windows.Forms.Button();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.lblRating = new System.Windows.Forms.Label();
            this.cbRead = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.defPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "READ #";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // defPictureBox
            // 
            this.defPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.defPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("defPictureBox.Image")));
            this.defPictureBox.Location = new System.Drawing.Point(12, 49);
            this.defPictureBox.Name = "defPictureBox";
            this.defPictureBox.Size = new System.Drawing.Size(156, 238);
            this.defPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.defPictureBox.TabIndex = 9;
            this.defPictureBox.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(541, 360);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Iesire";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // stergCrt
            // 
            this.stergCrt.Location = new System.Drawing.Point(460, 360);
            this.stergCrt.Name = "stergCrt";
            this.stergCrt.Size = new System.Drawing.Size(75, 23);
            this.stergCrt.TabIndex = 11;
            this.stergCrt.Text = "Sterge Carte";
            this.stergCrt.UseVisualStyleBackColor = true;
            this.stergCrt.Click += new System.EventHandler(this.stergCrt_Click);
            // 
            // lblTitlu
            // 
            this.lblTitlu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.Location = new System.Drawing.Point(174, 49);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(298, 21);
            this.lblTitlu.TabIndex = 13;
            this.lblTitlu.Text = "Titlu";
            this.lblTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(174, 83);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(442, 273);
            this.lblDesc.TabIndex = 14;
            this.lblDesc.Text = "Titlu";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDesc.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Link Site:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.Location = new System.Drawing.Point(83, 316);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(43, 17);
            this.lblLink.TabIndex = 16;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "Click";
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // lblRating
            // 
            this.lblRating.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(12, 290);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(156, 23);
            this.lblRating.TabIndex = 17;
            this.lblRating.Text = "Rating: ";
            this.lblRating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbRead
            // 
            this.cbRead.AutoSize = true;
            this.cbRead.Location = new System.Drawing.Point(62, 342);
            this.cbRead.Name = "cbRead";
            this.cbRead.Size = new System.Drawing.Size(15, 14);
            this.cbRead.TabIndex = 18;
            this.cbRead.UseVisualStyleBackColor = true;
            this.cbRead.CheckedChanged += new System.EventHandler(this.cbRead_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Citita:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditCarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(628, 393);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRead);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.stergCrt);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.defPictureBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCarti";
            this.Load += new System.EventHandler(this.EditCarti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox defPictureBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button stergCrt;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblLink;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.CheckBox cbRead;
        private System.Windows.Forms.Label label3;
    }
}