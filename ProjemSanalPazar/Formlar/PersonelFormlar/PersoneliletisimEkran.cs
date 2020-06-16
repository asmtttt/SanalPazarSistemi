using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProjemSanalPazar.Formlar.PersonelFormlar
{
    public partial class PersoneliletisimEkran : Form
    {


        public PersoneliletisimEkran()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F1TMNMD;Initial Catalog=SanalPazarSistemiUygulamaOdev;Integrated Security=True");



        private void PersoneliletisimEkran_Load(object sender, EventArgs e)
        {

        }

        private void AnaMenuDonButon_Click(object sender, EventArgs e)
        {
            PersonelSistemMenu PersonelSistemMenuyeDon = new PersonelSistemMenu();
            PersonelSistemMenuyeDon.Show();
            this.Hide();
        }

        private void PersoneliletisimAnketLinkButon_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string kayit = "insert into AnketBilgi(AnketAd,AnketLink) Values(@anketad,@anketlink)";

                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@anketad", PersoneliletisimAnketAdTextBox.Text);
                komut.Parameters.AddWithValue("@anketlink", PersoneliletisimAnketLinkTextBox.Text);


                komut.ExecuteNonQuery();
                baglanti.Close();



                MessageBox.Show("Anket Sisteme Eklenmiştir");

                PersoneliletisimAnketAdTextBox.Text = "";
                PersoneliletisimAnketLinkTextBox.Text = "";



            }

            catch (Exception hata)
            {
                PersoneliletisimEkran personeliletisimekran = new PersoneliletisimEkran();
                personeliletisimekran.BackColor = Color.Red;
                MessageBox.Show("İşlem sırasında bir hata oluştu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                personeliletisimekran.BackColor = Color.SeaGreen;
            }



        }
    }
}
