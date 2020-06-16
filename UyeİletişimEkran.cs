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
    public partial class UyeİletişimEkran : Form
    {
        public UyeİletişimEkran()
        {
            InitializeComponent();
        }



        private void UyeİletişimEkran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sanalPazarSistemiUygulamaOdevDataSet1.AnketBilgi' table. You can move, or remove it, as needed.
            this.anketBilgiTableAdapter.Fill(this.sanalPazarSistemiUygulamaOdevDataSet1.AnketBilgi);


        }

    

        private void AnaMenuDonButon_Click(object sender, EventArgs e)
        {
            UyeSistemMenu MenuyeDon = new UyeSistemMenu();
            MenuyeDon.Show();
            this.Hide();
        }
    }
}
