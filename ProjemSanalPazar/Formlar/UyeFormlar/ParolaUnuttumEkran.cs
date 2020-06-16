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
    public partial class ParolaUnuttumEkran : Form
    {
        public ParolaUnuttumEkran()
        {
            InitializeComponent();
        }

        private void ParolaUnuttumEkran_Load(object sender, EventArgs e)
        {

        }

        private void AnaMenuDonButon_Click(object sender, EventArgs e)
        {
            AlisverisPaketlerEkran EkranaDon = new AlisverisPaketlerEkran();
            EkranaDon.Show();
            this.Hide();
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

        private void TelefonTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
