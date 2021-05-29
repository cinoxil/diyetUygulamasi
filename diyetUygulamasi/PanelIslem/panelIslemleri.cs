using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace diyetUygulamasi.PanelIslem
{
    public static class panelIslemleri
    {
        #region ekran seçimi

        //Kullanıcı tipine göre hangi ekranın gösterilceğini seçen fonksiyon
        public static void kullaniciyaEkraniGoster(bool isAdmin)
        {
            //Eğer tip adminse buraya girer
            if (isAdmin)
            {
                var form1 = new Form1();
                var frmAdmin = new frmAdmin();
                Application.OpenForms["Form1"].Hide(); //Açık formlar içinden adı Form1 olanı yakalayıp gizliyor.
                frmAdmin.Show();
            }
            //Eğer tip kullanıcıysa buraya girer
            else
            {
                solPanelAc(); //Sol paneli etkinleştiren fonksiyon.
            }
        }

        #endregion

        //Kullanıcın sahip olanduğu para miktarında bir değişiklik olursa bu foksiyon ile yenileniyor.
        public static void panelYenile()
        {
            //var anaForm =
            //    Application.OpenForms["Form1"]; //anaForm değişkenine açık formlardan adı Form1 olanı eşitliyor.
            //var solPanel =
            //    (Panel)anaForm.Controls[
            //        "pnlIslemler"]; //solPanel deşikenine anaForm kontrolledindeki pnlIslemler isimli paneli eşitliyor.
            //var lblPara = (Label)solPanel.Controls["lblPara"]; //solPanel üstünden lblParaya ulaştık.
            ////Kullanıcılar listesinden geçerli kullanıcı idsine göre istenilen kullanıcı çekilip parasını lblParada gösteriyoruz.
            //double para = dataBase.dataBase.kullanicilar.Where(x => x.id == dataBase.dataBase.gecerliKullanici)
            //    .FirstOrDefault().para;
            //para = Math.Round(para, 2);
            //lblPara.Text = para.ToString();
        }

        //Oturumu kapat butonuna tıklandığında hesaptan çıkış yapan fonksiyon.
        public static void oturumuKapat()
        {
            var form1 = new Form1();
            var frmKullanici = new frmKullaniciGiris();
            pencereleriKapat(); //Tüm penceleri kapatan fonksiyon.
            Application.OpenForms["Form1"].Show(); //Tekrardfan Form1i Gösterir.
            frmKullanici.MdiParent =
                Application.OpenForms["Form1"]; //Kulllanıcı giriş bölümünün MdiParenti olarak Form1i ayarlıyor.
            frmKullanici.StartPosition = FormStartPosition.Manual;
            frmKullanici.Location = new Point(280, 130);
            solPanelKapat();

            frmKullanici.Show();
        }

        #region sol panel işlemleri

        //solPanelin üzerindeki butonları aktif hale getiren fonksiyon.
        private static void solPanelAc()
        {
            //var anaForm =
            //    Application.OpenForms["Form1"]; //anaForm değişkenine açık formlardan adı Form1 olanı eşitliyor.
            //var solPanel =
            //    (Panel)anaForm.Controls[
            //        "pnlIslemler"]; /*solPanel deşikenine anaForm kontrolledindeki pnlIslemler isimli paneli 
            //                                                           eşitliyor.*/
            //var gbIslemliste =
            //    (GroupBox)solPanel.Controls["grpBoxIslemListe"]; /*gbIslemListe deşikenine solPanel kontrolledindeki 
            //                                                                          grpBoxIslemListe isimli groupboxı eşitliyor.*/
            //var lblId = (Label)solPanel.Controls["lblId"];
            //var lblPara = (Label)solPanel.Controls["lblPara"];
            ////Geçerli kullanıcının para ve kullanıcı adını ilgili labellere yazıyor.
            //double para = dataBase.dataBase.kullanicilar.Where(x => x.id == dataBase.dataBase.gecerliKullanici)
            //    .FirstOrDefault().para;
            //para = Math.Round(para, 2);
            //lblPara.Text = para.ToString();
            //lblId.Text = dataBase.dataBase.gecerliKullanici;

            ////Grupboxın kontrollerine girip buttonları aktif hale getiriyor.
            //foreach (Control item in gbIslemliste.Controls)
            //    if (item is Button)
            //        item.Enabled = true;
        }

        //Oturum kapatıldığında sol panel butonlarını kapatıyor ve lblPara ve lblId labellerinin içini siliyor.
        public static void solPanelKapat()
        {
            var anaForm = Application.OpenForms["Form1"];
            var solPanel = (Panel)anaForm.Controls["pnlIslemler"];
            var gbIslemliste = (GroupBox)solPanel.Controls["grpBoxIslemListe"];
            var lblId = (Label)solPanel.Controls["lblId"];
            var lblPara = (Label)solPanel.Controls["lblPara"];
            lblId.Text = "";
            //Grupboxın kontrollerine girip buttonları pasif hale getiriyor.
            foreach (Control item in gbIslemliste.Controls)
                if (item is Button)
                    item.Enabled = false;
        }

        #endregion

        #region pencere islemleri

        //Form1 harici tüm pencereleri gizleyen fonksiyon.
        public static void pencereleriKapat()
        {
            for (var i = 0; i < Application.OpenForms.Count; i++)
                //Form1 mi diye kontrol ediyor(Form1in adı Alım - Satım Uygulaması).
                if (Application.OpenForms[i].Text != "Alım - Satım Uygulaması")
                    Application.OpenForms[i].Hide();
        }

        //Kayıt ol penceresini göstermeye yarıyan fonksiyon.
        public static void kayitOlPencereGoster()
        {
            //var frm1 = new form1();
            //var frmKayit = new frmKayitOl();
            //pencereleriKapat();
            //frmKayit.MdiParent = Application.OpenForms["Form1"];
            //frmKayit.StartPosition = FormStartPosition.Manual;
            //frmKayit.Location = new Point(220, 110);
            //frmKayit.Show();
        }

        #endregion

        #region Form temizleme

        //Veri giriş elemanlarını temizlemek için kullanılan fonksiyon.
        public static void formTemizle(Form form)
        {
            //Fonksiyona gelen form değişkeni içindeki kontrollerde texboxlar üzerinde dönüyor.
            foreach (var txt in form.Controls.OfType<TextBox>())
                //Eğer texbox boş değil ise texboxı temizliyor.
                if (!string.IsNullOrEmpty(txt.Text))
                    txt.Clear();
            //Fonksiyona gelen form değişkeni içindeki kontrollerde comboboxlar üzerinde dönüyor.
            foreach (var cmBox in form.Controls.OfType<ComboBox>())
                //Eğer texbox boş değil ise comboboxı temizliyor.
                if (!string.IsNullOrEmpty(cmBox.Text))
                    cmBox.SelectedIndex = -1;
        }

        public static void formTemizle(GroupBox gb)
        {
            //Fonksiyona gelen form değişkeni içindeki kontrollerde texboxlar üzerinde dönüyor.
            foreach (var txt in gb.Controls.OfType<TextBox>())
                //Eğer texbox boş değil ise texboxı temizliyor.
                if (!string.IsNullOrEmpty(txt.Text))
                    txt.Clear();
            //Fonksiyona gelen form değişkeni içindeki kontrollerde comboboxlar üzerinde dönüyor.
            foreach (var cmBox in gb.Controls.OfType<ComboBox>())
                //Eğer texbox boş değil ise comboboxı temizliyor.
                if (!string.IsNullOrEmpty(cmBox.Text))
                    cmBox.SelectedIndex = -1;
        }

        #endregion

        #region frmKayitOl Panel İşlemleri

        //Kayıtol kısmında eksik veri girişi olup olamdığını kontrol eden fonksiyon.
        public static bool girdiKontrol(Form form)
        {
            var kontrol = true;
            //Fonksiyona gelen form değişkeni içindeki kontrollerde texboxlar üzerinde dönüyor.
            foreach (var txt in form.Controls.OfType<TextBox>())
                //Eğer texbox boş ise kontrol değişkenini false yapıyor ve dögüden çıkıyor.
                if (string.IsNullOrEmpty(txt.Text))
                {
                    kontrol = false;
                    break;
                }

            return kontrol;
        }

        //Kayıt ol formunda eksik veri girişi yoksa kullanıcı kayıt eden varsa hata verdiren fonksiyon.
        //public static void kullaniciKayit(string id, string sifre, string ad, string soyad, string tc, string telefon,
        //    string mail, string adres)
        //{
        //    var kayitForm =
        //        Application.OpenForms["frmKayitOl"]; //Açık formlar içerisinden frmkayitOl isimli formu yakalar.
        //    //Texbox kontrolü için kayıt formunu girdi kontrol mothoduna göreriyor eğer true dönerse içeri giriyor.
        //    if (girdiKontrol(kayitForm))
        //    {
        //        var yeniKullanici =
        //            new kullanici(id, sifre, ad, soyad, tc, telefon, mail, ad); //Kullanıcıyı örnekliyor.
        //        //Eğer yenikullanıcı içindeki kayıtalınabilir true ise otorumu kapat fonksiyonunu çalıştırıyor.
        //        if (yeniKullanici.kayitAlinabilir) oturumuKapat();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Lütfen eksik veri girişi yapmayın");
        //    }
        //}

        #endregion
    }
}