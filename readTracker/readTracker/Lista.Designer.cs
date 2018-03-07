namespace readTracker
{
    partial class Lista
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
            this.flowCarti = new System.Windows.Forms.FlowLayoutPanel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.adaugBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "READ #";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowCarti
            // 
            this.flowCarti.Location = new System.Drawing.Point(12, 51);
            this.flowCarti.Name = "flowCarti";
            this.flowCarti.Size = new System.Drawing.Size(498, 315);
            this.flowCarti.TabIndex = 2;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(435, 373);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Iesire";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // adaugBtn
            // 
            this.adaugBtn.Location = new System.Drawing.Point(346, 373);
            this.adaugBtn.Name = "adaugBtn";
            this.adaugBtn.Size = new System.Drawing.Size(83, 23);
            this.adaugBtn.TabIndex = 7;
            this.adaugBtn.Text = "Adauga Carti";
            this.adaugBtn.UseVisualStyleBackColor = true;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(522, 401);
            this.Controls.Add(this.adaugBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.flowCarti);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowCarti;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button adaugBtn;
    }
}