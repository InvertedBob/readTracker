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
namespace readTracker
{
    public partial class Lista : Form
    {
        List<PictureBox> libImg = new List<PictureBox>(); // O lista care contine cate un PictureBox cu coperta fiecarei carti din "librarie"
        meniuPrinc princ = new meniuPrinc();
        public Lista()
        {
            InitializeComponent();
        }

        /* Atunci cand este apasat butonul exitBtn este inchisa aceasta instanta a formei. */
        private void exitBtn_Click(object sender, EventArgs e)
        {
            princ.Show();
            this.Close();
        }

        private void Lista_Load(object sender, EventArgs e)
        {
            /* Daca nu exista nici o carte in lista, se afiseaza un PictureBox "standard", altfel se apeleaza metoda
            Load_Books() pentru a incepe afisarea copertilor cartilor in lista. */
            if (Storage.libCarti.Count() == 0) defPictureBox.Visible = true;
            else Load_Books();
        }

        /*  Metoda Load_Books() adauga la lista libImg cate un obiect de tip PictureBox pentru fiecare carte din list libCarti.
            Tot aceasta metoda seteaza ca imagine pentru fiecare nou PictureBox coperta cartii pe care o reprezinta si seteaza
        ca parent flowCarti. Toate obiectele de tip PictureBox au ca model defPcitureBox. */
        private void Load_Books()
        {
            foreach (Book bk in Storage.libCarti)
            {
                PictureBox pic = new PictureBox();
                pic.Size = defPictureBox.Size;
                pic.Parent = defPictureBox.Parent;
                pic.ImageLocation = bk.ImageUrl;
                pic.Load(bk.ImageUrl);
                pic.Visible = true;

                /* Fiecare coperta este legata de aceleasi evenimente de click/mouse-over pentru a reactiona la fel in aceste cazuri. */
                pic.MouseEnter += intraMouse;
                pic.MouseLeave += ieseMouse;
                pic.Click += clickCoperta;

                libImg.Add(pic);
            }
        }
        /* Atunci cand este apasat butonul "Adauga Carti" este deschisa o fereastra pentru adaugarea cartilor.*/
        private void adaugBtn_Click(object sender, EventArgs e)
        {
            AddCarti addCrt = new AddCarti();
            addCrt.Show();
            this.Close();

        }

        /* Atunci cand mouse-ul ajunge pe coperta unei carti, se schimba stilul bordurii pentru a arata care coperta este selectata. */
        private void intraMouse(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.BorderStyle = BorderStyle.Fixed3D;
        }

        /* Atunci cand mouse-ul nu mai este pe coperta, bordura acesteia revine la normal. */
        private void ieseMouse(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.BorderStyle = BorderStyle.FixedSingle;
        }

        private void clickCoperta(object sender, EventArgs e)
        {
            EditCarti editCrt = new EditCarti();
            editCrt.Show();
            this.Close();
        }

    }
}
