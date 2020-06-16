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
    public partial class PersonelSistemMenu : Form
    {
        public PersonelSistemMenu()
        {
            InitializeComponent();
        }

        private void PersonelSistemMenu_Load(object sender, EventArgs e)
        {

        }

        private void PersonelİletisimButon_Click(object sender, EventArgs e)
        {
            PersoneliletisimEkran PersoneliletisimEkranGit = new PersoneliletisimEkran();
            PersoneliletisimEkranGit.Show();
            this.Hide();
        }

        private void PersonelMenuSiparisButon_Click(object sender, EventArgs e)
        {
            Formlar.PersonelFormlar.PersonelSiparislerBilgiEkran PersonelSiparisSayfa = new Formlar.PersonelFormlar.PersonelSiparislerBilgiEkran();
            PersonelSiparisSayfa.Show();
            this.Hide();
        }

        private void PersonelDepoUrunBilgiButon_Click(object sender, EventArgs e)
        {
            Formlar.PersonelFormlar.PersonelDepoUrunBilgiEkran PersonelDepoSayfaGit = new Formlar.PersonelFormlar.PersonelDepoUrunBilgiEkran();
            PersonelDepoSayfaGit.Show();
            this.Hide();
        }

        private void PersonelİstatistiklerButon_Click(object sender, EventArgs e)
        {
            Formlar.PersonelFormlar.PersonelİstatistikBilgileriEkran PersonelİstatistikSayfaGit = new Formlar.PersonelFormlar.PersonelİstatistikBilgileriEkran();
            PersonelİstatistikSayfaGit.Show();
            this.Hide();
        }
    }
}
