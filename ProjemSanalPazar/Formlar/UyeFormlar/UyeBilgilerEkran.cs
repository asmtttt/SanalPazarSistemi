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

namespace ProjemSanalPazar.Formlar
{
    public partial class UyeBilgilerEkran : Form
    {
        public UyeBilgilerEkran()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F1TMNMD;Initial Catalog=SanalPazarSistemiUygulamaOdev;Integrated Security=True");

        private void UyeBilgilerEkran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sanalPazarSistemiUygulamaOdevDataSet.UyeBilgi' table. You can move, or remove it, as needed.
            /*this.uyeBilgiTableAdapter.Fill(dataTable: this.sanalPazarSistemiUygulamaOdevDataSet.UyeBilgi);*/

        }

        private void UyeBilgilerListeleButon_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From UyeBilgi Where UyeEposta = @Eposta ", baglanti);

            komut.Parameters.AddWithValue("@Eposta", UyeBilgilerEkranTextBox.Text);

            DataTable Tablo = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            adapter.Fill(Tablo);

            dataGridView1.DataSource = Tablo;
        }

       

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UyeBilgilerGuncelleAdTextBox.Text = dataGridView1.CurrentRow.Cells["UyeAd"].Value.ToString();
            UyeBilgilerGuncelleSoyadTextBox.Text = dataGridView1.CurrentRow.Cells["UyeSoyad"].Value.ToString();
            UyeBilgilerGuncelleDogumTarihTextBox.Text = dataGridView1.CurrentRow.Cells["UyeDogumTarih"].Value.ToString();
            UyeBilgilerGuncelleTelefonTextBox.Text = dataGridView1.CurrentRow.Cells["UyeTelefon"].Value.ToString();
            UyeBilgilerGuncelleEpostaTextBox.Text = dataGridView1.CurrentRow.Cells["UyeEposta"].Value.ToString();
            UyeBilgilerGuncelleParolaTextBox.Text = dataGridView1.CurrentRow.Cells["UyeParola"].Value.ToString();
            UyeBilgilerGuncelleMahalleListBox.Text = dataGridView1.CurrentRow.Cells["UyeAdresMahalle"].Value.ToString();
            UyeBilgilerGuncelleSokakTextBox.Text = dataGridView1.CurrentRow.Cells["UyeAdresSokakAdNo"].Value.ToString();
            UyeBilgilerGuncelleApartmanTextBox.Text = dataGridView1.CurrentRow.Cells["UyeAdresApartmanAdNo"].Value.ToString();
            UyeBilgilerGuncelleDaireTextBox.Text = dataGridView1.CurrentRow.Cells["UyeAdresDaireNo"].Value.ToString();
            UyeBilgilerGuncelleGuvenlikSoruTextBox.Text = dataGridView1.CurrentRow.Cells["UyeGuvenlikSoru"].Value.ToString();
            UyeBilgilerGuncelleGuvenlikYanıtTextBox.Text = dataGridView1.CurrentRow.Cells["UyeGuvenlikYanıt"].Value.ToString();
            UyeBilgilerGuncelleKartUstuAdTextBox.Text = dataGridView1.CurrentRow.Cells["KartUstundekiAd"].Value.ToString();
            UyeBilgilerGuncelleKartNoTextBox.Text = dataGridView1.CurrentRow.Cells["KartNumara"].Value.ToString();
            UyeBilgilerGuncelleCvcKodTextBox.Text = dataGridView1.CurrentRow.Cells["CvcKod"].Value.ToString();

            

        }

        

        private void UyeBilgilerGuncelleButon_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutiki = new SqlCommand("Update UyeBilgi set UyeAd = @uyead, UyeSoyad = @uyesoyad, UyeDogumTarih = @uyedogumtarih, UyeTelefon = @uyetelefon," +
                "UyeAdresMahalle = @uyeadresmahalle, UyeAdresSokakAdNo = @uyeadressokakadno, UyeAdresApartmanAdNo = @uyeadresapartmanadno," +
                "UyeAdresDaireNo = @uyeadresdaireno, UyeParola = @uyeparola, UyeGuvenlikSoru = @uyeguvenliksoru, UyeGuvenlikYanıt = @uyeguvenlikyanıt," +
                "KartUstundekiAd = @kartustuad, KartNumara = @kartno, CvcKod = @cvckod where UyeEposta = @uyeeposta", baglanti);
            
            komutiki.Parameters.AddWithValue("@uyeeposta", UyeBilgilerGuncelleEpostaTextBox.Text);
            komutiki.Parameters.AddWithValue("@uyead", UyeBilgilerGuncelleAdTextBox.Text);
            komutiki.Parameters.AddWithValue("@uyesoyad", UyeBilgilerGuncelleSoyadTextBox.Text);
            komutiki.Parameters.AddWithValue("@uyedogumtarih", UyeBilgilerGuncelleDogumTarihTextBox.Text);
            komutiki.Parameters.AddWithValue("@uyetelefon", UyeBilgilerGuncelleTelefonTextBox.Text);
            komutiki.Parameters.AddWithValue("@uyeadresmahalle", UyeBilgilerGuncelleMahalleListBox.Text);
            komutiki.Parameters.AddWithValue("@uyeadressokakadno", UyeBilgilerGuncelleSokakTextBox.Text);
            komutiki.Parameters.AddWithValue("@UyeAdresapartmanadno", UyeBilgilerGuncelleApartmanTextBox.Text);
            komutiki.Parameters.AddWithValue("@uyeadresdaireno", UyeBilgilerGuncelleDaireTextBox.Text);
            komutiki.Parameters.AddWithValue("@uyeparola", UyeBilgilerGuncelleParolaTextBox.Text);
            komutiki.Parameters.AddWithValue("@uyeguvenliksoru", UyeBilgilerGuncelleGuvenlikSoruTextBox.Text);
            komutiki.Parameters.AddWithValue("@uyeguvenlikyanıt", UyeBilgilerGuncelleGuvenlikYanıtTextBox.Text);
            komutiki.Parameters.AddWithValue("@kartustuad", UyeBilgilerGuncelleKartUstuAdTextBox.Text);
            komutiki.Parameters.AddWithValue("@kartno", UyeBilgilerGuncelleKartNoTextBox.Text);
            komutiki.Parameters.AddWithValue("@cvckod", UyeBilgilerGuncelleCvcKodTextBox.Text);





            DataTable Tabloiki = new DataTable();
            komutiki.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayıt Güncellendi", "Kayıt");
            Tabloiki.Clear();

            /*= '"+UyeBilgilerGuncelleAdTextBox.Text+ "', UyeSoyad = '" +UyeBilgilerGuncelleSoyadTextBox.Text+ "', " +

                "UyeDogumTarih = '" +UyeBilgilerGuncelleDogumTarihTextBox.Text+ "', UyeTelefon = '" +UyeBilgilerGuncelleTelefonTextBox.Text+ "', " +
                "UyeAdresMahalle = '" + UyeBilgilerGuncelleMahalleListBox.Text + "'," +
                "UyeAdresSokakAdNo = '" + UyeBilgilerGuncelleSokakTextBox.Text + "', UyeAdresApartmanAdNo = '" + UyeBilgilerGuncelleApartmanTextBox.Text + "'," +
                "UyeAdresDaireNo = '" + UyeBilgilerGuncelleDaireTextBox.Text + "', UyeParola = '" + UyeBilgilerGuncelleParolaTextBox.Text + "'," +
                "UyeGuvenlikSoru = '" + UyeBilgilerGuncelleGuvenlikSoruTextBox.Text + "', UyeGuvenlikYanıt = '" + UyeBilgilerGuncelleGuvenlikYanıtTextBox.Text + "'" +
                "where UyeEposta = '" + UyeBilgilerGuncelleEpostaTextBox.Text + "'" */




        }

        private void AnaMenuDonButon_Click(object sender, EventArgs e)
        {
            UyeSistemMenu MenuyeDon = new UyeSistemMenu();
            MenuyeDon.Show();
            this.Hide();
        }
    }

    

}
