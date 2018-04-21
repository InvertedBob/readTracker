using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Goodreads.Models.Response;
using TheArtOfDev.HtmlRenderer.WinForms;
namespace readTracker
{
    public partial class EditCarti : Form
    {
        Book bk = new Book();
        int nrCrt = 0;
        public EditCarti()
        {
            InitializeComponent();
        }

        private void EditCarti_Load(object sender, EventArgs e)
        {
            try
            {
                bk = Storage.libCarti.Find(x => x.ImageUrl == Storage.urlCrt);
                nrCrt = Storage.libCarti.FindIndex(x => x == bk);
                defPictureBox.Load(bk.ImageUrl);
                lblTitlu.Text = bk.Title;
                HtmlLabel lblDescr = new HtmlLabel();
                lblDescr.Location = lblDesc.Location;
                lblDescr.Parent = lblDesc.Parent;
                if (bk.Description.Length > 600) lblDescr.Text = bk.Description.Substring(0, 600) + " ... Mai multe pe www.Goodreads.com";
                else lblDescr.Text = bk.Description + " ... Mai multe pe www.Goodreads.com";
                lblDescr.IsSelectionEnabled = false;
                lblDescr.BackColor = Color.Transparent;
                lblDescr.MaximumSize = lblDesc.Size;
                lblDescr.BorderStyle = BorderStyle.FixedSingle;
                lblRating.Text = "Rating: " + bk.AverageRating.ToString();
                cbRead.Checked = Storage.libCartiCit.ElementAt(nrCrt);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        /* Atunci cand este apasat butonul exitBtn este inchisa aceasta instanta a formei. */
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Lista lst = new Lista();
            lst.Show();
            this.Close();
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(bk.Url);
        }

        private void cbRead_CheckedChanged(object sender, EventArgs e)
        {
            Storage.libCartiCit[nrCrt] = cbRead.Checked;
        }

        private void stergCrt_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Esti sigur ca vrei sa stergi aceasta carte?", "Confirmare", MessageBoxButtons.YesNo);
            if(confirm == DialogResult.Yes)
            {
                Storage.libCarti.RemoveAt(nrCrt);
                Storage.libCartiCit.RemoveAt(nrCrt);
                Lista lst = new Lista();
                lst.Show();
                this.Close();
            }
        }
    }
}
