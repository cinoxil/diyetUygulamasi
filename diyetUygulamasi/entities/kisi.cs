using diyetUygulamasi.database;
using diyetUygulamasi.PanelIslem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diyetUygulamasi.entities
{
    public class kisi
    {
        private string _tc { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public bool isAdmin { get; set; }

        public string tc
        {
            get
            {
                return this._tc;
            }
            set
            {
                if (value.Length == 11)
                {
                    this._tc = value;
                }
                else
                {
                    MessageBox.Show("TC Kimlik No 11 haneli olmalidir");
                }
            }
        }


        #region kullanici giriş kontrol

        //Girilen kullanıcı adı ve şifre değerlerini var olan kullanıcı adı ve şifre değerleriyle kıyaslayıp doğru ise giriş işlemini gerçekleştirir.
        public static void kullaniciGirisKontrol(string kullaniciAdi, string sifre, Form frmKullaniciGiris)
        {
            var kullaniciKontrol = true;

            //Database içindeki adminler listesinde gezip fonksiyona gelen kullanıcı adında admin olup olmadığını kuntrol ediyor. 

            admin adminTemp = null;

            if (kullaniciAdi == db.admin.kullaniciAdi)
            {
                adminTemp = db.admin;
            }


            if (adminTemp != null) //AdminTempin null olup olmadığına bakıyor.
            {
                kullaniciKontrol = false;
                if (kullaniciAdi != null && kullaniciAdi == adminTemp.kullaniciAdi && sifre == adminTemp.sifre) 
                {
                                                                               
                    MessageBox.Show("Merhaba " + adminTemp.kullaniciAdi);
                    frmKullaniciGiris.Close(); //Fonsiyona gelen geçerli giriş yapma formunu kapatıyor.
                    db.gecerliKullanici = adminTemp.kullaniciAdi; //Geçerli kullanıcıya adminTempdeki idyi gönderir.
                    panelIslemleri.kullaniciyaEkraniGoster(adminTemp.isAdmin); //Kullanıcı tipine göre gerekli ekranlari ayarlar.
                }
                else
                {
                    MessageBox.Show("Şifreniz yanlış",
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            

            if (kullaniciKontrol)
            {
                if (db.diyetisyenler != null)
                {
                    //kullanıcıTempe girilen kulanıcıadına sahip olan kullanıcı eşitliyoruz.
                    var diyetisyenTemp = db.diyetisyenler.Where(x => x.kullaniciAdi == kullaniciAdi)
                        .FirstOrDefault();
                    if (diyetisyenTemp != null) //Eğer kullanıcı bulunursa bu şarta girer.
                    {
                        //Kullanıcı kontrollerini ve form işlemlerini yapaıyor.
                        if (kullaniciAdi != null && kullaniciAdi == diyetisyenTemp.kullaniciAdi && sifre == diyetisyenTemp.sifre)
                        {
                            MessageBox.Show("Merhaba " + diyetisyenTemp.kullaniciAdi);
                            frmKullaniciGiris.Close(); //Fonsiyona gelen geçerli giriş yapma formunu kapatıyor.
                            db.gecerliKullanici =
                                diyetisyenTemp.kullaniciAdi; //Geçerli kullanıcıya adminTempdeki idyi gönderir.
                            panelIslemleri.kullaniciyaEkraniGoster(diyetisyenTemp.isAdmin); /*Kullanıcı tipine göre gerekli ekranlari
                                                                                                            ayarlar.*/
                        }
                        else
                        {
                            MessageBox.Show("Şifreniz yanlış",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir kayıt bulunamadı",
                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Böyle bir kayıt bulunamadı",
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        #endregion
    }
}