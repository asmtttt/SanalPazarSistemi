using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ProjemSanalPazar.Formlar
{
    public partial class UyeSistemMenu : Form
    {
        public UyeSistemMenu()
        {
            InitializeComponent();
        }

        private void UyeSistemMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void UyeMenuAlısverisPaketButon_Click(object sender, EventArgs e)
        {
            Formlar.AlısverisPaketlerEkran AlisverisPaketleriSayfa = new Formlar.AlısverisPaketlerEkran();
            AlisverisPaketleriSayfa.Show();
            this.Hide();


        }

        private void UyeMenuBilgilerButon_Click(object sender, EventArgs e)
        {
            Formlar.UyeBilgilerEkran UyeBilgilerSayfa = new Formlar.UyeBilgilerEkran();
            UyeBilgilerSayfa.Show();
            this.Hide(); 
        }

        private void UyeMenuİletisimButon_Click(object sender, EventArgs e)
        {
            Formlar.UyeİletişimEkran UyeİletisimSayfa = new Formlar.UyeİletişimEkran();
            UyeİletisimSayfa.Show();
            this.Hide();
        }

        private void UyeMenuSiparisButon_Click(object sender, EventArgs e)
        {
            Formlar.UyeFormlar.UyeSiparislerimEkran Uyesiparislerimsayfa = new Formlar.UyeFormlar.UyeSiparislerimEkran();
            Uyesiparislerimsayfa.Show();
            this.Hide();
        }
    }


    public class ShapedButton : Button //Buton sınıfından miras alınıyor
    {
        // Elips buton a yeni bir boyut  verildiğinde şeklini elips yapıyor
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);//http://www.gorselprogramlama.com/
            GraphicsPath gp = new GraphicsPath();
            // this.Size ın en boyu aynı oldugundan elips bir şekil oluşuyor
            gp.AddEllipse(new Rectangle(Point.Empty, this.Size));
            // oluşan yeni elips şekli oluşturulan butona atanıyor
            this.Region = new Region(gp);
            // Butonun yeni şekli elips oluyor
        }
    }





}
