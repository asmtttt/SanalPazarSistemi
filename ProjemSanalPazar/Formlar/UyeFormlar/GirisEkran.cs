using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjemSanalPazar
{
    public partial class GirisEkran : Form
    {
        public GirisEkran()
        {
            InitializeComponent();
        }

        private void TanıtımSayfa_Click(object sender, EventArgs e)
        {
            TanıtımEkran frm2 = new TanıtımEkran();
            frm2.Show();
            this.Hide();
        }

        private void GirisEkran_Load(object sender, EventArgs e)
        {

        }

        private void UyeKayıtButon_Click(object sender, EventArgs e)
        {
            Formlar.UyeKayıtEkran UyeKayıtSayfa = new Formlar.UyeKayıtEkran();
            UyeKayıtSayfa.Show();
            this.Hide();
        }

        private void UyeGirisButon_Click(object sender, EventArgs e)
        {
            Formlar.AlisverisPaketlerEkran UyeGirisSayfa = new Formlar.AlisverisPaketlerEkran();
            UyeGirisSayfa.Show();
            this.Hide();
        }

        private void PersonelKayıtButon_Click(object sender, EventArgs e)
        {

        }

        private void PersonelGirisButon_Click(object sender, EventArgs e)
        {
            Formlar.PersonelFormlar.PersonelGirisEkran PersonelGirisSayfa = new Formlar.PersonelFormlar.PersonelGirisEkran();
            PersonelGirisSayfa.Show();
            this.Hide();
        }
    }
}
