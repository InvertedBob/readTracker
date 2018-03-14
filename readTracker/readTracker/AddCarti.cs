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
using Goodreads;

namespace readTracker
{
    public partial class AddCarti : Form
    {

        IGoodreadsClient client = GoodreadsClient.Create(Storage.ApiKey, Storage.ApiSecret);
        Book bk = new Book();
        public AddCarti()
        {
            InitializeComponent();
        }

        private void tbAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAut_Click(object sender, EventArgs e)
        {

        }

        async private Task getBookByISBN(string isbn)
        {
            bk = await client.Books.GetByIsbn(isbn);
            lblTitluRez.Text = bk.Title;
            defPictureBox.Load(bk.ImageUrl);
            lblAutorRez.Text = bk.Authors.ToString();
        }
        async private Task getBookByTitle(string title, string auth=null)
        {
            bk = await client.Books.GetByTitle(title, auth);
            lblTitluRez.Text = bk.Title;
            defPictureBox.Load(bk.ImageUrl);
            lblAutorRez.Text = bk.Authors.ToString();
        }
        private void cautaBtn_Click(object sender, EventArgs e)
        {
            if(dpISBN.Checked==true)
            {
                if (tbISBN.Text == null) MessageBox.Show("Campul ISBN Carte nu poate fi gol", "Camp ISBN gol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    getBookByISBN(tbISBN.Text);
                }
            }
            else
            {
                if (tbTitlu.Text == null) MessageBox.Show("Campul 'Titlu Carte' nu poate fi gol", "Camp Titlu gol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    getBookByTitle(tbTitlu.Text, tbAutor.Text);
                }
            }
        }

        private void lblTitluRez_Click(object sender, EventArgs e)
        {

        }

        /* Atunci cand este apasat butonul exitBtn este inchisa aceasta instanta a formei. */
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Lista lst = new Lista();
            lst.Show();
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (Storage.libCarti.Find(x => x.Title == bk.Title) == null) { Storage.libCarti.Add(bk); Console.WriteLine("Da"); }
            else MessageBox.Show("Cartea exista deja in lista", "Cartea exista in lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
