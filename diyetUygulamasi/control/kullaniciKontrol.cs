using diyetUygulamasi.database;
using diyetUygulamasi.entities;
using diyetUygulamasi.PanelIslemleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diyetUygulamasi.control
{
    public static class kullaniciKontrol
    {
        
        public static admin gecerliAdmin;
        public static diyetisyen gecerliDiyetisyen;


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
                    gecerliAdmin = adminTemp; //Geçerli kullanıcıya adminTempdeki idyi gönderir.
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
                            gecerliDiyetisyen = diyetisyenTemp; //Geçerli kullanıcıya adminTempdeki idyi gönderir.
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
