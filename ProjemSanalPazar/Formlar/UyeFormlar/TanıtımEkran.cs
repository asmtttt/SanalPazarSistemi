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
    public partial class TanıtımEkran : Form
    {
        public TanıtımEkran()
        {
            InitializeComponent();
        }

        private void NeYapıyoruzButon_Click(object sender, EventArgs e)
        {
            
             if (NeYapıyoruzLabel.Visible)
               NeYapıyoruzLabel.Visible = false;

             else
               NeYapıyoruzLabel.Visible = true;
            
        }

        private void HangiBolgeButon_Click(object sender, EventArgs e)
        {
            if (HangiBolgeLabel.Visible)
                HangiBolgeLabel.Visible = false;

            else
                HangiBolgeLabel.Visible = true;
        }

        private void NasılYapıyoruzButon_Click(object sender, EventArgs e)
        {
            if (NasılYapıyoruzLabel.Visible)
                NasılYapıyoruzLabel.Visible = false;

            else
                NasılYapıyoruzLabel.Visible = true;
        }

        private void OdemeSistemiButon_Click(object sender, EventArgs e)
        {
            if (OdemeSistemiLabel.Visible)
                OdemeSistemiLabel.Visible = false;

            else
                OdemeSistemiLabel.Visible = true;
        }

        private void AnaMenuDonButton_Click(object sender, EventArgs e)
        {
            GirisEkran EkranaDon = new GirisEkran();
            EkranaDon.Show();
            this.Hide();
        }

        private void TanıtımEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
