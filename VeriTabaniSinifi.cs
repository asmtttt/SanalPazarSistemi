using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProjemSanalPazar.Formlar
{
    class VeriTabaniSinifi
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F1TMNMD;Initial Catalog=SanalPazarSistemiUygulamaOdev;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;


        public void GirisYap(string eposta, string parola, Form frm1)
        {
            command = new SqlCommand("Select * From UyeBilgi where UyeEposta = '" + eposta + "' and UyeParola = '" + parola + "'", baglanti);
            baglanti.Open();
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Giriş Başarılı", "*Tebrikler*", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UyeSistemMenu UyeSistemMenuGiris = new UyeSistemMenu();
                frm1.Hide();
                UyeSistemMenuGiris.Show();

                /*Formlar.UyeSistemMenu UyeSistemMenuSayfa = new Formlar.UyeSistemMenu();
                UyeSistemMenuSayfa.Show();*/

            }

            else
            {
                frm1.BackColor = Color.Red;
                MessageBox.Show("Hatalı Giriş!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frm1.BackColor = Color.SeaGreen;
            }

            baglanti.Close();
            command.Dispose();

        }



        public void Personel_GirisYap(string personelno, string parola, Form frm2)
        {
            command = new SqlCommand("Select * From PersonelBilgi where PersonelNumara = '" + personelno + "' and PersonelParola = '" + parola + "'", baglanti);
            baglanti.Open();
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Giriş Başarılı", "*Tebrikler*", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PersonelFormlar.PersonelSistemMenu PersonelSistemMenuGiris = new PersonelFormlar.PersonelSistemMenu();
                frm2.Hide();
                PersonelSistemMenuGiris.Show();
               

                /*Formlar.UyeSistemMenu UyeSistemMenuSayfa = new Formlar.UyeSistemMenu();
                UyeSistemMenuSayfa.Show();*/

            }

            else
            {
                frm2.BackColor = Color.Red;
                MessageBox.Show("Hatalı Giriş!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frm2.BackColor = Color.SeaGreen;
            }

            baglanti.Close();
            command.Dispose();

        }


        public void Odeme_Yap_aylık_standart(string kartad, string kartnumara, string cvckod, string ad, string soyad, Form frm1)
        {
            command = new SqlCommand("Select * From UyeBilgi where KartUstundekiAd = '" + kartad + "' and KartNumara = '" + kartnumara + "'" +
                " and CvcKod = '" + cvckod + "' and UyeAd = '" + ad + "' and UyeSoyad = '" + soyad + "' ", baglanti);

            baglanti.Open();
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();

                String kayit = "insert into SiparisBilgi(SiparisUyeAd,SiparisUyeSoyad,SiparisUrunAd,SiparisUrunFiyat) " +
                    "Values(@ad,@soyad,@urunad,@urunfiyat)";

                SqlCommand komutiki = new SqlCommand(kayit, baglanti);

                komutiki.Parameters.AddWithValue("@ad", ad);
                komutiki.Parameters.AddWithValue("@soyad", soyad);
                komutiki.Parameters.AddWithValue("@urunad", "Aylık Standart Paket");
                komutiki.Parameters.AddWithValue("@urunfiyat", 600);
                komutiki.ExecuteNonQuery();


            }

            else
            {
                MessageBox.Show("Hata oldu bilgilerinizi kontrol ediniz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
            command.Dispose();

        }






        public void Odeme_Yap_aylık_ekonomik(string kartad, string kartnumara, string cvckod, string ad, string soyad, Form frm1)
        {
            command = new SqlCommand("Select * From UyeBilgi where KartUstundekiAd = '" + kartad + "' and KartNumara = '" + kartnumara + "'" +
                " and CvcKod = '" + cvckod + "' and UyeAd = '" + ad + "' and UyeSoyad = '" + soyad + "' ", baglanti);

            baglanti.Open();
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();

                String kayit = "insert into SiparisBilgi(SiparisUyeAd,SiparisUyeSoyad,SiparisUrunAd,SiparisUrunFiyat) " +
                    "Values(@ad,@soyad,@urunad,@urunfiyat)";

                SqlCommand komutiki = new SqlCommand(kayit, baglanti);

                komutiki.Parameters.AddWithValue("@ad", ad);
                komutiki.Parameters.AddWithValue("@soyad", soyad);
                komutiki.Parameters.AddWithValue("@urunad", "Aylık Ekonomik Paket");
                komutiki.Parameters.AddWithValue("@urunfiyat", 300);
                komutiki.ExecuteNonQuery();


            }

            else
            {
                MessageBox.Show("Hata oldu bilgilerinizi kontrol ediniz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
            command.Dispose();

        }





        public void Odeme_Yap_haftalik_standart(string kartad, string kartnumara, string cvckod, string ad, string soyad, Form frm1)
        {
            command = new SqlCommand("Select * From UyeBilgi where KartUstundekiAd = '" + kartad + "' and KartNumara = '" + kartnumara + "'" +
                " and CvcKod = '" + cvckod + "' and UyeAd = '" + ad + "' and UyeSoyad = '" + soyad + "' ", baglanti);

            baglanti.Open();
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();

                String kayit = "insert into SiparisBilgi(SiparisUyeAd,SiparisUyeSoyad,SiparisUrunAd,SiparisUrunFiyat) " +
                    "Values(@ad,@soyad,@urunad,@urunfiyat)";

                SqlCommand komutiki = new SqlCommand(kayit, baglanti);

                komutiki.Parameters.AddWithValue("@ad", ad);
                komutiki.Parameters.AddWithValue("@soyad", soyad);
                komutiki.Parameters.AddWithValue("@urunad", "Haftalık Standart Paket");
                komutiki.Parameters.AddWithValue("@urunfiyat", 150);
                komutiki.ExecuteNonQuery();


            }

            else
            {
                MessageBox.Show("Hata oldu bilgilerinizi kontrol ediniz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
            command.Dispose();

        }




        public void Odeme_Yap_haftalik_ekonomik(string kartad, string kartnumara, string cvckod, string ad, string soyad, Form frm1)
        {
            command = new SqlCommand("Select * From UyeBilgi where KartUstundekiAd = '" + kartad + "' and KartNumara = '" + kartnumara + "'" +
                " and CvcKod = '" + cvckod + "' and UyeAd = '" + ad + "' and UyeSoyad = '" + soyad + "' ", baglanti);

            baglanti.Open();
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();

                String kayit = "insert into SiparisBilgi(SiparisUyeAd,SiparisUyeSoyad,SiparisUrunAd,SiparisUrunFiyat) " +
                    "Values(@ad,@soyad,@urunad,@urunfiyat)";

                SqlCommand komutiki = new SqlCommand(kayit, baglanti);

                komutiki.Parameters.AddWithValue("@ad", ad);
                komutiki.Parameters.AddWithValue("@soyad", soyad);
                komutiki.Parameters.AddWithValue("@urunad", "Haftalık Ekonomik Paket");
                komutiki.Parameters.AddWithValue("@urunfiyat", 75);
                komutiki.ExecuteNonQuery();


            }

            else
            {
                MessageBox.Show("Hata oldu bilgilerinizi kontrol ediniz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
            command.Dispose();

        }



    }

}