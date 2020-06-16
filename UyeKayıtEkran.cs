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
using System.Drawing;

namespace ProjemSanalPazar.Formlar
{
    public partial class UyeKayıtEkran : Form
    {
        public UyeKayıtEkran()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F1TMNMD;Initial Catalog=SanalPazarSistemiUygulamaOdev;Integrated Security=True");
        

        private void UyeKayıtEkran_Load(object sender, EventArgs e)
        {

        }

        private void AnaMenuDonButon_Click(object sender, EventArgs e)
        {
            GirisEkran EkranaDon = new GirisEkran();
            EkranaDon.Show();
            this.Hide();
        }

        private void AdTextBox_TextChanged(object sender, EventArgs e)
        {
            AdTextBox.Text = "";
        }

        private void AdTextBox_Enter(object sender, EventArgs e)
        {
            if (AdTextBox.Text == "Örnek; Samet")
            {
                AdTextBox.Text = "";
            }
        }

        private void SoyadTextBox_Enter(object sender, EventArgs e)
        {
            if (SoyadTextBox.Text == "Örnek; Yılmaz")
            {
                SoyadTextBox.Text = "";
            }
        }

        private void DogumTarihTextBox_Enter(object sender, EventArgs e)
        {
            if (DogumTarihTextBox.Text == "Örnek; 1994-08-27")
            {
                DogumTarihTextBox.Text = "";
            }
        }

        private void TelefonTextBox_Enter(object sender, EventArgs e)
        {
            if (TelefonTextBox.Text == "Örnek; 05447258236")
            {
                TelefonTextBox.Text = "";
            }
        }

        private void EpostaTextBox_Enter(object sender, EventArgs e)
        {
            if (EpostaTextBox.Text == "Örnek; samet.ocsoy@gmail.com")
            {
                EpostaTextBox.Text = "";
            }
        }

        private void ParolaTextBox_Enter(object sender, EventArgs e)
        {
            if (ParolaTextBox.Text == "En Fazla 10 Karakter Giriniz")
            {
                ParolaTextBox.Text = "";
            }
        }

        

        private void SokakNoAdTextBox_Enter(object sender, EventArgs e)
        {
            if (SokakNoAdTextBox.Text == "Örnek; 1017")
            {
                SokakNoAdTextBox.Text = "";
            }
        }

        private void ApartmanNoAdTextBox_Enter(object sender, EventArgs e)
        {
            if (ApartmanNoAdTextBox.Text == "Örnek; 49")
            {
                ApartmanNoAdTextBox.Text = "";
            }
        }

        private void DaireNoTextBox_Enter(object sender, EventArgs e)
        {
            if (DaireNoTextBox.Text == "Örnek; 9")
            {
                DaireNoTextBox.Text = "";

            }
        }

        private void UyeKayıtKaydetButon_Click(object sender, EventArgs e)
        {
            try
            {
                    baglanti.Open();
                    String kayit = "insert into UyeBilgi(UyeAd,UyeSoyad,UyeDogumTarih,UyeTelefon,UyeEposta," +
                        "UyeAdresMahalle,UyeAdresSokakAdNo,UyeAdresApartmanAdNo,UyeAdresDaireNo,UyeParola," +
                        "UyeGuvenlikSoru,UyeGuvenlikYanıt,KartUstundekiAd,KartNumara,CvcKod) Values(@ad,@soyad,@dogumtarih,@telefon,@eposta," +
                        "@adresmahalle,@adressokak,@adresapartman,@adresdaire,@parola,@guvenliksoru,@guvenlikyanit,@KartUstuAd,@KartNo,@cvckodu)";

                    SqlCommand komut = new SqlCommand(kayit, baglanti);

                    komut.Parameters.AddWithValue("@ad", AdTextBox.Text);
                    komut.Parameters.AddWithValue("@soyad", SoyadTextBox.Text);
                    komut.Parameters.AddWithValue("@dogumtarih", DogumTarihTextBox.Text);
                    komut.Parameters.AddWithValue("@telefon", TelefonTextBox.Text);
                    komut.Parameters.AddWithValue("@eposta", EpostaTextBox.Text);
                    komut.Parameters.AddWithValue("@adresmahalle", MahalleListBox.Text);
                    komut.Parameters.AddWithValue("@adressokak", SokakNoAdTextBox.Text);
                    komut.Parameters.AddWithValue("@adresapartman", ApartmanNoAdTextBox.Text);
                    komut.Parameters.AddWithValue("@adresdaire", DaireNoTextBox.Text);
                    komut.Parameters.AddWithValue("@parola", ParolaTextBox.Text);
                    komut.Parameters.AddWithValue("@guvenliksoru", GuvenlikSoruTextBox.Text);
                    komut.Parameters.AddWithValue("@guvenlikyanit", GuvenlikYanıtTextBox.Text);
                    komut.Parameters.AddWithValue("@KartUstuAd", KartUstuAdTextbox.Text);
                    komut.Parameters.AddWithValue("@KartNo", KartNumarasıTextBox.Text);
                    komut.Parameters.AddWithValue("@cvckodu", CvcKodTextBox.Text);

                    komut.ExecuteNonQuery();
                    baglanti.Close();

       
                
                    MessageBox.Show("Kayıt işlemniz tamamlandı. Ana Menüye dönerek sisteme giriş yapabilirsiniz");

                    AdTextBox.Text = "Örnek; Samet";
                    SoyadTextBox.Text = "Örnek; Yılmaz";
                    DogumTarihTextBox.Text = "Örnek; 1994-08-27";
                    TelefonTextBox.Text = "Örnek; 05447258236";
                    EpostaTextBox.Text = "Örnek; samet.ocsoy@gmail.com";
                    ParolaTextBox.Text = "En Fazla 10 Karakter Giriniz";
                    SokakNoAdTextBox.Text = "Örnek; 1017";
                    ApartmanNoAdTextBox.Text = "Örnek; 49";
                    DaireNoTextBox.Text = "Örnek; 9";
                    GuvenlikSoruTextBox.Text = "";
                    GuvenlikYanıtTextBox.Text = "";
                    KartUstuAdTextbox.Text = "";
                    KartNumarasıTextBox.Text = "";
                    CvcKodTextBox.Text = "";





                
            }
            catch (Exception hata)
            {
                UyeKayıtEkran uyekayitekran = new UyeKayıtEkran();
                uyekayitekran.BackColor = Color.Red;
                MessageBox.Show("İşlem sırasında bir hata oluştu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uyekayitekran.BackColor = Color.SeaGreen;
            }



        }
    }












}
