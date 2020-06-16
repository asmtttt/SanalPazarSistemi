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

namespace ProjemSanalPazar.Formlar.UyeFormlar
{
    public partial class UyeSiparislerimEkran : Form
    {
        public UyeSiparislerimEkran()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F1TMNMD;Initial Catalog=SanalPazarSistemiUygulamaOdev;Integrated Security=True");

        private void UyeSiparislerimEkran_Load(object sender, EventArgs e)
        {

        }

        private void UyeSiparisListeleButon_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From SiparisBilgi Where SiparisUyeAd = @siparisuyead and SiparisUyeSoyad = @siparisuyesoyad ", baglanti);

            komut.Parameters.AddWithValue("@siparisuyead ", UyeSiparisEkranAdTextBox.Text);
            komut.Parameters.AddWithValue("@siparisuyesoyad ", UyeSiparisEkranSoyadTextBox.Text);

            DataTable Tablo = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            adapter.Fill(Tablo);

            dataGridView1.DataSource = Tablo;
        }

        private void AnaMenuDonButon_Click(object sender, EventArgs e)
        {
            UyeSistemMenu MenuyeDon = new UyeSistemMenu();
            MenuyeDon.Show();
            this.Hide();
        }
    }
}
