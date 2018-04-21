using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using Goodreads.Models.Response;
using Goodreads;
namespace readTracker
{
    public partial class meniuPrinc : Form
    {
        string connectionString =
        @"Provider=Microsoft.Jet.OLEDB.4.0;" +
        @"Data Source=C:\Users\Sergiu\Source\Repos\readTracker\readTracker\readTracker\readSharp.mdb;"+
        @"User Id = Admin; Password=;";
// + Directory.GetCurrentDirectory()+"\readSharp.mdb;"+

        string queryString = "SELECT * FROM carti";
        IGoodreadsClient client = GoodreadsClient.Create(Storage.ApiKey, Storage.ApiSecret);
        Book bk = new Book();

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

        async private Task loadBook(long bkID, bool cit)
        {
            try
            {
                bk = await client.Books.GetByBookId(bkID);
                Storage.libCarti.Add(bk);
                Storage.libCartiCit.Add(cit);
                lblProgres.Text = "Mai ai de citit " + Storage.libCartiCit.Where(x => x == false).Count() + " carti din " + Storage.libCartiCit.Count() + " propuse.";
                progBar1.Maximum = Storage.libCartiCit.Count();
                progBar1.Value = Storage.libCartiCit.Where(x => x == false).Count();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("A aparut o eroare la conexiunea cu site-ul.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void meniuPrinc_Load(object sender, EventArgs e)
        {
            if (Storage.firstLoad == true)
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                using (OleDbCommand command = new OleDbCommand(queryString, connection))
                {
                    try
                    {
                        connection.Open();
                        OleDbDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            loadBook(Convert.ToInt64(reader[0]), Convert.ToBoolean(reader[1]));
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                Storage.firstLoad = false;
            }
            lblProgres.Text = "Mai ai de citit " + Storage.libCartiCit.Where(x => x == false).Count() + " carti din " + Storage.libCartiCit.Count() + " propuse.";
            progBar1.Maximum = Storage.libCartiCit.Count();
            progBar1.Value = Storage.libCartiCit.Where(x => x == false).Count();
        }

        private void meniuPrinc_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    int nrCrt = 0;
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("DELETE FROM carti", connection);
                    command.ExecuteNonQuery();
                    foreach (Book bk in Storage.libCarti)
                    {
                        string statement = "INSERT INTO carti([ID],[Citita]) values(" + bk.Id + ", " + Storage.libCartiCit.ElementAt(nrCrt) + ")";
                        command = new OleDbCommand(statement, connection);
                        command.ExecuteNonQuery();
                        nrCrt++;
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
