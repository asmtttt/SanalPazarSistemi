using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjemSanalPazar.Formlar.PersonelFormlar
{
    public partial class PersonelGirisEkran : Form
    {
        public PersonelGirisEkran()
        {
            InitializeComponent();
        }

        private void PersonelGirisEkran_Load(object sender, EventArgs e)
        {

        }

        private void AnaMenuDonButon_Click(object sender, EventArgs e)
        {
            GirisEkran EkranaDon = new GirisEkran();
            EkranaDon.Show();
            this.Hide();
        }

        private void PersonelGirisButon_Click(object sender, EventArgs e)
        {
            string PersonelNumarasi = PersonelNumarasıTextBox.Text;
            string PersonelParolasi = PersonelParolaTextBox.Text;

            VeriTabaniSinifi giris_islem = new VeriTabaniSinifi();
            giris_islem.Personel_GirisYap(PersonelNumarasi, PersonelParolasi, this);
        }
    }
}
