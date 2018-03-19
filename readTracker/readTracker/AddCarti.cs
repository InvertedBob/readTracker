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
        /* Creeaza o entitate a obiectului Client pentru a fi folosit in apelarea functiilor ce au legatura cu API-ul Goodreads */
        IGoodreadsClient client = GoodreadsClient.Create(Storage.ApiKey, Storage.ApiSecret);
        Book bk = new Book();
        public AddCarti()
        {
            InitializeComponent();
        }
        /* Functia foloseste API-ul pentru a cauta cartea dorita in functie de ISBN,
        daca nu se gaseste cartea cautata, este afisata o eroare.*/
        async private Task getBookByISBN(string isbn)
        {
            try
            {
                lblTitluRez.Text = bk.Title;
                defPictureBox.Load(bk.ImageUrl);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Nu s-a gasit o carte pentru aceste date", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* Functia foloseste API-ul pentru a cauta cartea dorita in functie de titlu si optional autor,
        daca nu se gaseste cartea cautata, este afisata o eroare.*/
        async private Task getBookByTitle(string title, string auth=null)
        {
            try
            {
                bk = await client.Books.GetByTitle(title, auth);
                lblTitluRez.Text = bk.Title;
                defPictureBox.Load(bk.ImageUrl);
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Nu s-a gasit o carte pentru aceste date", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /* Cand se apasa butonul de cautare, sunt apelate functiile corespunzatoare pentru fiecare metoda de cautare
        sau se afiseaza o eroare daca un camp obligatoriu este gol */
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

        /* Atunci cand este apasat butonul exitBtn este inchisa aceasta instanta a formei. */
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Lista lst = new Lista();
            lst.Show();
            this.Close();
        }
        /* Daca titlul cartii nu este gasit in "librarie" cartea este adaugata in lista, altfel se afiseaza o eroare */
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (Storage.libCarti.Find(x => x.Title == bk.Title) == null)
            {
                Storage.libCarti.Add(bk);
                Storage.libCartiCit.Add(false);
            }
            else MessageBox.Show("Cartea exista deja in lista", "Cartea exista in lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /* Atunci cand este selectat modul de cautare a unei carti, se activeaza/dezactiveaza campurile de text corespunzatoare */
        private void dpTitlu_CheckedChanged(object sender, EventArgs e)
        {
            tbAutor.Enabled = dpTitlu.Checked;
            tbTitlu.Enabled = dpTitlu.Checked;
            tbISBN.Enabled = !dpTitlu.Checked;
        }
    }
}
