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
    public partial class AlisverisPaketlerEkran : Form
    {
        public AlisverisPaketlerEkran()
        {
            InitializeComponent();
        }


        private void AnaMenuDonButon_Click(object sender, EventArgs e)
        {
            GirisEkran EkranaDon = new GirisEkran();
            EkranaDon.Show();
            this.Hide();
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

        private void UyeGirisEkran_Load(object sender, EventArgs e)
        {
            ParolaTextBox.PasswordChar = '*';
        }

        private void UyeGirisButon_Click(object sender, EventArgs e)
        {
            string Eposta = EpostaTextBox.Text;
            string Parola = ParolaTextBox.Text;
            int hour = DateTime.Now.TimeOfDay.Hours;

            if (hour >= 0 && hour <= 24)
            {
                VeriTabaniSinifi islem = new VeriTabaniSinifi();
                islem.GirisYap(Eposta, Parola, this);
            }
            else
            {
                MessageBox.Show("Sistem sadece 9 : 00   -   18 : 00 saatleri arasında hizmet vermektedir!", "Sistemin Kuralları", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void ParolaUnuttumLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ParolaUnuttumEkran EkranaDon = new ParolaUnuttumEkran();
            EkranaDon.Show();
            this.Hide();
        }
    }
}
