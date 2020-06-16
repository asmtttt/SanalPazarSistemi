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
    public partial class PersonelİstatistikBilgileriEkran : Form
    {
        public PersonelİstatistikBilgileriEkran()
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

        private void PersonelİstatistikBilgileriEkran_Load(object sender, EventArgs e)
        {
            /* sisteme kayıtlı üye sayısı */

            SqlCommand komut1 = new SqlCommand("Select count(*) from UyeBilgi",baglanti);
            baglanti.Open();
            SqlDataReader reader1 = komut1.ExecuteReader();

            while (reader1.Read())
            {
                SistemKayıtlıUyeSayıDegerLabel.Text = reader1[0].ToString();
            }
            baglanti.Close();


            /* barbaros mahallesinde ikamet eden üye sayısı kayıtlı üye sayısı */

            SqlCommand komut2 = new SqlCommand("Select count(*) from UyeBilgi where UyeAdresMahalle = 'Barbaros Hayrettin'", baglanti);
            baglanti.Open();
            SqlDataReader reader2 = komut2.ExecuteReader();

            while (reader2.Read())
            {
                BarbarosMahalleUyeSayısıDegerLabel.Text = reader2[0].ToString();
            }
            baglanti.Close();

            
            
            /* bağlarbaşı mahallesinde ikamet eden üye sayısı kayıtlı üye sayısı */

            SqlCommand komut3 = new SqlCommand("Select count(*) from UyeBilgi where UyeAdresMahalle = 'Bağlarbaşı'", baglanti);
            baglanti.Open();
            SqlDataReader reader3 = komut3.ExecuteReader();

            while (reader3.Read())
            {
                BaglarbasıUyeSayısıDegerLabel.Text = reader3[0].ToString();
            }
            baglanti.Close();




            /* Fevzi Çakmak mahallesinde ikamet eden üye sayısı kayıtlı üye sayısı */

            SqlCommand komut4 = new SqlCommand("Select count(*) from UyeBilgi where UyeAdresMahalle = 'Fevzi Çakmak'", baglanti);
            baglanti.Open();
            SqlDataReader reader4 = komut4.ExecuteReader();

            while (reader4.Read())
            {
                FevziCakmakUyeSayısıDegerLabel.Text = reader4[0].ToString();
            }
            baglanti.Close();



            /* Hürriyet mahallesinde ikamet eden üye sayısı kayıtlı üye sayısı */

            SqlCommand komut5 = new SqlCommand("Select count(*) from UyeBilgi where UyeAdresMahalle = 'Hürriyet'", baglanti);
            baglanti.Open();
            SqlDataReader reader5 = komut5.ExecuteReader();

            while (reader5.Read())
            {
                HurriyetUyeSayısıDegerLabel.Text = reader5[0].ToString();
            }
            baglanti.Close();




            /* Karadeniz mahallesinde ikamet eden üye sayısı kayıtlı üye sayısı */

            SqlCommand komut6 = new SqlCommand("Select count(*) from UyeBilgi where UyeAdresMahalle = 'Karadeniz'", baglanti);
            baglanti.Open();
            SqlDataReader reader6 = komut5.ExecuteReader();

            while (reader6.Read())
            {
                KaradenizUyeSayısıDegerLabel.Text = reader6[0].ToString();
            }
            baglanti.Close();






            /* Karlıtepe mahallesinde ikamet eden üye sayısı kayıtlı üye sayısı */

            SqlCommand komut7 = new SqlCommand("Select count(*) from UyeBilgi where UyeAdresMahalle = 'Karlıtepe'", baglanti);
            baglanti.Open();
            SqlDataReader reader7 = komut7.ExecuteReader();

            while (reader7.Read())
            {
                KarlıtepeUyeSayısıDegerLabel.Text = reader7[0].ToString();
            }
            baglanti.Close();





            /* Karayolları mahallesinde ikamet eden üye sayısı kayıtlı üye sayısı */

            SqlCommand komut8 = new SqlCommand("Select count(*) from UyeBilgi where UyeAdresMahalle = 'Karayolları'", baglanti);
            baglanti.Open();
            SqlDataReader reader8 = komut8.ExecuteReader();

            while (reader8.Read())
            {
                KarayollarıUyeSayısıDegerLabel.Text = reader8[0].ToString();
            }
            baglanti.Close();








            /* Kazım Karabekir mahallesinde ikamet eden üye sayısı kayıtlı üye sayısı */

            SqlCommand komut9 = new SqlCommand("Select count(*) from UyeBilgi where UyeAdresMahalle = 'Kazım Karabekir'", baglanti);
            baglanti.Open();
            SqlDataReader reader9 = komut9.ExecuteReader();

            while (reader9.Read())
            {
                KazımKarabekirUyeSayısıDegerLabel.Text = reader9[0].ToString();
            }
            baglanti.Close();





            /* Merkez mahallesinde ikamet eden üye sayısı kayıtlı üye sayısı */

            SqlCommand komut10 = new SqlCommand("Select count(*) from UyeBilgi where UyeAdresMahalle = 'Merkez'", baglanti);
            baglanti.Open();
            SqlDataReader reader10 = komut10.ExecuteReader();

            while (reader10.Read())
            {
                MerkezUyeSayısıDegerLabel.Text = reader10[0].ToString();
            }
            baglanti.Close();




            /* Mevlana mahallesinde ikamet eden üye sayısı kayıtlı üye sayısı */

            SqlCommand komut11 = new SqlCommand("Select count(*) from UyeBilgi where UyeAdresMahalle = 'Mevlana'", baglanti);
            baglanti.Open();
            SqlDataReader reader11 = komut11.ExecuteReader();

            while (reader11.Read())
            {
                MevlanaUyeSayısıDegerLabel.Text = reader11[0].ToString();
            }
            baglanti.Close();




            /* Pazariçi mahallesinde ikamet eden üye sayısı kayıtlı üye sayısı */

            SqlCommand komut12 = new SqlCommand("Select count(*) from UyeBilgi where UyeAdresMahalle = 'Pazariçi'", baglanti);
            baglanti.Open();
            SqlDataReader reader12 = komut12.ExecuteReader();

            while (reader12.Read())
            {
                PazariciUyeSayısıDegerLabel.Text = reader12[0].ToString();
            }
            baglanti.Close();




            /* Sarıgöl mahallesinde ikamet eden üye sayısı kayıtlı üye sayısı */

            SqlCommand komut13 = new SqlCommand("Select count(*) from UyeBilgi where UyeAdresMahalle = 'Sarıgöl'", baglanti);
            baglanti.Open();
            SqlDataReader reader13 = komut13.ExecuteReader();

            while (reader13.Read())
            {
                SarıgolUyeSayısıDegerLabel.Text = reader13[0].ToString();
            }
            baglanti.Close();




            /* ŞemsiPaşa mahallesinde ikamet eden üye sayısı kayıtlı üye sayısı */

            SqlCommand komut14 = new SqlCommand("Select count(*) from UyeBilgi where UyeAdresMahalle = 'ŞemsiPaşa'", baglanti);
            baglanti.Open();
            SqlDataReader reader14 = komut14.ExecuteReader();

            while (reader14.Read())
            {
                SemsiPasaUyeSayısıDegerLabel.Text = reader14[0].ToString();
            }
            baglanti.Close();





            /* Yenidoğan mahallesinde ikamet eden üye sayısı kayıtlı üye sayısı */

            SqlCommand komut15 = new SqlCommand("Select count(*) from UyeBilgi where UyeAdresMahalle = 'Yenidoğan'", baglanti);
            baglanti.Open();
            SqlDataReader reader15 = komut15.ExecuteReader();

            while (reader15.Read())
            {
                YenidoganUyeSayısıDegerLabel.Text = reader15[0].ToString();
            }
            baglanti.Close();





            /* Yenimahalle mahallesinde ikamet eden üye sayısı kayıtlı üye sayısı */

            SqlCommand komut16 = new SqlCommand("Select count(*) from UyeBilgi where UyeAdresMahalle = 'Yenimahalle'", baglanti);
            baglanti.Open();
            SqlDataReader reader16 = komut16.ExecuteReader();

            while (reader16.Read())
            {
                YeniMahalleUyeSayısıDegerLabel.Text = reader16[0].ToString();
            }
            baglanti.Close();





            /* Yıldıztabya mahallesinde ikamet eden üye sayısı kayıtlı üye sayısı */

            SqlCommand komut17 = new SqlCommand("Select count(*) from UyeBilgi where UyeAdresMahalle = 'Yıldıztabya'", baglanti);
            baglanti.Open();
            SqlDataReader reader17 = komut17.ExecuteReader();

            while (reader17.Read())
            {
                YıldıztabyaUyeSayısıDegerLabel.Text = reader17[0].ToString();
            }
            baglanti.Close();




            /* Personel Aylık Giderleri    */

            SqlCommand komut18 = new SqlCommand("Select Sum(PersonelMaas) from PersonelBilgi", baglanti);
            baglanti.Open();
            SqlDataReader reader18 = komut18.ExecuteReader();

            while (reader18.Read())
            {
                PersonelMaaslarToplamıDeger.Text = reader18[0].ToString();
            }
            baglanti.Close();



            /* Sistem Toplam Satış Gelirleri    */

            SqlCommand komut19 = new SqlCommand("Select Sum(SiparisUrunFiyat) from SiparisBilgi", baglanti);
            baglanti.Open();
            SqlDataReader reader19 = komut19.ExecuteReader();

            while (reader19.Read())
            {
                SistemSiparisGelirleriDegerLabel.Text = reader19[0].ToString();
            }
            baglanti.Close();





            /* Depodaki Toplam stok sayısı  */

            SqlCommand komut20 = new SqlCommand("Select Sum(PaketStok) from PaketBilgi", baglanti);
            baglanti.Open();
            SqlDataReader reader20 = komut20.ExecuteReader();

            while (reader20.Read())
            {
                DepodakiToplamStokSayısıDegerLabel.Text = reader20[0].ToString();
            }
            baglanti.Close();





            /* Depodaki Toplam Maliyet sayısı  */

            SqlCommand komut21 = new SqlCommand("Select Sum(PaketMaliyet) from PaketBilgi", baglanti);
            baglanti.Open();
            SqlDataReader reader21 = komut21.ExecuteReader();

            while (reader21.Read())
            {
                DepodakiToplamUrunMaliyetleriDegerLabel.Text = reader21[0].ToString();
            }
            baglanti.Close();






        }
    }
}






