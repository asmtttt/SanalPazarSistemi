﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjemSanalPazar.Formlar.UyeFormlar
{
    public partial class HaftalıkEkonomikPaketEkranBilgi : Form
    {
        public HaftalıkEkonomikPaketEkranBilgi()
        {
            InitializeComponent();
        }

        private void HaftalıkEkonomikPaketEkranBilgi_Load(object sender, EventArgs e)
        {

        }

        private void AnaMenuDonButon_Click(object sender, EventArgs e)
        {
            AlısverisPaketlerEkran AlısverisPaketlerEkranDon = new AlısverisPaketlerEkran();
            AlısverisPaketlerEkranDon.Show();
            this.Hide();
        }
    }
}
