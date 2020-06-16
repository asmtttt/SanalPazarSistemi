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
    public partial class PersonelSiparislerBilgiEkran : Form
    {
        public PersonelSiparislerBilgiEkran()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F1TMNMD;Initial Catalog=SanalPazarSistemiUygulamaOdev;Integrated Security=True");

        private void AnaMenuDonButon_Click(object sender, EventArgs e)
        {
            PersonelSistemMenu PersonelSistemMenuyeDon = new PersonelSistemMenu();
            PersonelSistemMenuyeDon.Show();
            this.Hide();
        }

        private void PersonelSiparislerBilgiEkran_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From SiparisBilgi ", baglanti);

            DataTable Tablo = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            adapter.Fill(Tablo);

            dataGridView1.DataSource = Tablo;
        }
    }
}
