using System;
using System.Linq;
using System.Windows.Forms;


namespace diyetUygulamasi
{
    public partial class paraEkle : Form
    {
        public paraEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ////paraMiktar boş mu ve textBoxSayiControl sayı mı diye kontrol ediyor.
            //if (!string.IsNullOrEmpty(txtParaMiktar.Text) && textBoxSayiControl())
            //    new paraIstek(int.Parse(txtParaMiktar.Text),cmb_paraBirimi.Text);
            ////Eğer değilse hata veriyor.
            //else
            //    MessageBox.Show("Lütfen eklemek istediğiniz miktarı giriniz");
        }

        //ParaMiktar sayı mı diye kontrol ediyor.
        //private bool textBoxSayiControl()
        //{
        //    //txtParaMiktar texboxu sayı mı diye bakıyor ve sayı ise txtKontrol değişkenine true yazıyor.
        //    var txtKontrol = txtParaMiktar.Text.All(char.IsDigit);
        //    //Eğer sayı değilse hata veriyor.
        //    if (!txtKontrol) MessageBox.Show("Lütfen sayısal değer giriniz");

        //    return txtKontrol;
        //}
    }
}