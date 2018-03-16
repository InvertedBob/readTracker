using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace readTracker
{
    public partial class meniuPrinc : Form
    {
        public meniuPrinc()
        {
            InitializeComponent();
        }
        /* Atunci cand este apasat butonul cartiCit este deschisa o noua instanta a formei "Lista" aici
         este vizibila o lista cu toate cartile din librarie*/
        private void cartiCit_Click(object sender, EventArgs e)
        {
            Lista lst = new Lista();
            lst.Show();
            this.Hide();
        }
        /* Atunci cand este apasat butonul exitBtn este inchisa aceasta instanta a formei. */
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void meniuPrinc_Load(object sender, EventArgs e)
        {

        }
    }
}
