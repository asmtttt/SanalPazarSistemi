using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjemSanalPazar.Formlar
{
    public partial class AlısverisPaketlerEkran : Form
    {
        public AlısverisPaketlerEkran()
        {
            InitializeComponent();
        }

        private void AlısverisPaketlerEkran_Load(object sender, EventArgs e)
        {

        }

        private void PaketBirCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PaketBirCheckBox.Checked == true)
            {
                PaketİkicheckBox.Checked = false;
                PaketUccheckBox.Checked = false;
                PaketDortcheckBox.Checked = false;

            }
        }

        private void PaketİkicheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PaketİkicheckBox.Checked == true)
            {
                PaketBirCheckBox.Checked = false;
                PaketUccheckBox.Checked = false;
                PaketDortcheckBox.Checked = false;

            }
        }

        private void PaketUccheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PaketUccheckBox.Checked == true)
            {
                PaketBirCheckBox.Checked = false;
                PaketİkicheckBox.Checked = false;
                PaketDortcheckBox.Checked = false;

            }
        }

        private void PaketDortcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PaketDortcheckBox.Checked == true)
            {
                PaketBirCheckBox.Checked = false;
                PaketİkicheckBox.Checked = false;
                PaketUccheckBox.Checked = false;

            }
        }

        private void AnaMenuDonButon_Click(object sender, EventArgs e)
        {
            UyeSistemMenu UyeSistemMenuDon = new UyeSistemMenu();
            UyeSistemMenuDon.Show();
            this.Hide();
        }

        private void PaketBirButon_Click(object sender, EventArgs e)
        {
            UyeFormlar.AylıkStandartPaketBilgiEkran aylıkstandartpaketbilgiekranagit = new UyeFormlar.AylıkStandartPaketBilgiEkran();
            aylıkstandartpaketbilgiekranagit.Show();
            this.Hide();
        }

        private void PaketİkiButon_Click(object sender, EventArgs e)
        {
            UyeFormlar.AylıkEkonomikPaketBilgiEkran aylıkekonomikpaketbilgiekranagit = new UyeFormlar.AylıkEkonomikPaketBilgiEkran();
            aylıkekonomikpaketbilgiekranagit.Show();
            this.Hide();
        }

        private void PaketUcButon_Click(object sender, EventArgs e)
        {
            UyeFormlar.HaftalıkStandartPaketEkranBilgi haftalıkstandartpaketbilgiekranagit = new UyeFormlar.HaftalıkStandartPaketEkranBilgi();
            haftalıkstandartpaketbilgiekranagit.Show();
            this.Hide();
        }

        private void PaketDortButon_Click(object sender, EventArgs e)
        {
            UyeFormlar.HaftalıkEkonomikPaketEkranBilgi haftalıkekonomikpaketbilgiekranagit = new UyeFormlar.HaftalıkEkonomikPaketEkranBilgi();
            haftalıkekonomikpaketbilgiekranagit.Show();
            this.Hide();
        }

        private void OdemeYapButon_Click(object sender, EventArgs e)
        {
            if (PaketBirCheckBox.Checked == true)
            {
                VeriTabaniSinifi islem = new VeriTabaniSinifi();
                islem.Odeme_Yap_aylık_standart(KartUstuAdOdemeYapTextbox.Text, KartNumarasıOdemeYapTextBox.Text, CvcKodOdemeYapTextBox.Text, AdOdemeYapTextBox.Text, SoyadOdemeYapTextBox.Text, this);
                
                MessageBox.Show("Siparişiniz Alındı");
                KartUstuAdOdemeYapTextbox.Text = "";
                KartNumarasıOdemeYapTextBox.Text = "";
                CvcKodOdemeYapTextBox.Text = "";
                AdOdemeYapTextBox.Text = "";
                SoyadOdemeYapTextBox.Text = "";
            }

            if (PaketİkicheckBox.Checked == true)
            {
                VeriTabaniSinifi islem = new VeriTabaniSinifi();
                islem.Odeme_Yap_aylık_ekonomik(KartUstuAdOdemeYapTextbox.Text, KartNumarasıOdemeYapTextBox.Text, CvcKodOdemeYapTextBox.Text, AdOdemeYapTextBox.Text, SoyadOdemeYapTextBox.Text, this);


                MessageBox.Show("Siparişiniz Alındı");
                KartUstuAdOdemeYapTextbox.Text = "";
                KartNumarasıOdemeYapTextBox.Text = "";
                CvcKodOdemeYapTextBox.Text = "";
                AdOdemeYapTextBox.Text = "";
                SoyadOdemeYapTextBox.Text = "";
            }


            if (PaketUccheckBox.Checked == true)
            {
                VeriTabaniSinifi islem = new VeriTabaniSinifi();
                islem.Odeme_Yap_haftalik_standart(KartUstuAdOdemeYapTextbox.Text, KartNumarasıOdemeYapTextBox.Text, CvcKodOdemeYapTextBox.Text, AdOdemeYapTextBox.Text, SoyadOdemeYapTextBox.Text, this);

                MessageBox.Show("Siparişiniz Alındı");
                KartUstuAdOdemeYapTextbox.Text = "";
                KartNumarasıOdemeYapTextBox.Text = "";
                CvcKodOdemeYapTextBox.Text = "";
                AdOdemeYapTextBox.Text = "";
                SoyadOdemeYapTextBox.Text = "";

            }

            if (PaketDortcheckBox.Checked == true)
            {
                VeriTabaniSinifi islem = new VeriTabaniSinifi();
                islem.Odeme_Yap_haftalik_ekonomik(KartUstuAdOdemeYapTextbox.Text, KartNumarasıOdemeYapTextBox.Text, CvcKodOdemeYapTextBox.Text, AdOdemeYapTextBox.Text, SoyadOdemeYapTextBox.Text, this);
                
                MessageBox.Show("Siparişiniz Alındı");
                KartUstuAdOdemeYapTextbox.Text = "";
                KartNumarasıOdemeYapTextBox.Text = "";
                CvcKodOdemeYapTextBox.Text = "";
                AdOdemeYapTextBox.Text = "";
                SoyadOdemeYapTextBox.Text = "";
            }

        }
    }
}
