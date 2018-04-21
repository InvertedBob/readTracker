namespace readTracker
{
    partial class meniuPrinc
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
            this.label1 = new System.Windows.Forms.Label();
            this.progBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgres = new System.Windows.Forms.Label();
            this.cartiBtn = new System.Windows.Forms.Button();
            this.despreBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "READ #";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progBar1
            // 
            this.progBar1.Location = new System.Drawing.Point(32, 40);
            this.progBar1.Name = "progBar1";
            this.progBar1.Size = new System.Drawing.Size(407, 23);
            this.progBar1.TabIndex = 1;
            // 
            // lblProgres
            // 
            this.lblProgres.AutoSize = true;
            this.lblProgres.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgres.Location = new System.Drawing.Point(106, 66);
            this.lblProgres.Name = "lblProgres";
            this.lblProgres.Size = new System.Drawing.Size(261, 16);
            this.lblProgres.TabIndex = 2;
            this.lblProgres.Text = "Mai ai de citit x carti din cele y propuse";
            this.lblProgres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cartiBtn
            // 
            this.cartiBtn.Location = new System.Drawing.Point(32, 97);
            this.cartiBtn.Name = "cartiBtn";
            this.cartiBtn.Size = new System.Drawing.Size(75, 23);
            this.cartiBtn.TabIndex = 3;
            this.cartiBtn.Text = "Lista Carti";
            this.cartiBtn.UseVisualStyleBackColor = true;
            this.cartiBtn.Click += new System.EventHandler(this.cartiCit_Click);
            // 
            // despreBtn
            // 
            this.despreBtn.Location = new System.Drawing.Point(202, 97);
            this.despreBtn.Name = "despreBtn";
            this.despreBtn.Size = new System.Drawing.Size(75, 23);
            this.despreBtn.TabIndex = 4;
            this.despreBtn.Text = "Despre";
            this.despreBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(364, 97);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Iesire";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // meniuPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(471, 135);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.despreBtn);
            this.Controls.Add(this.cartiBtn);
            this.Controls.Add(this.lblProgres);
            this.Controls.Add(this.progBar1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "meniuPrinc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "meniuPrinc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.meniuPrinc_FormClosed);
            this.Load += new System.EventHandler(this.meniuPrinc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progBar1;
        private System.Windows.Forms.Label lblProgres;
        private System.Windows.Forms.Button cartiBtn;
        private System.Windows.Forms.Button despreBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}