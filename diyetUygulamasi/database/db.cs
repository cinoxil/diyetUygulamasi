using diyetUygulamasi.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetUygulamasi.database
{
    public static class db
    {

        public static admin admin = new admin("45896214589", "kadir", "can", "kadir", "123");
        public static List<diyetisyen> diyetisyenler = new List<diyetisyen>();

        public static List<hastalik> hastaliklar = new List<hastalik>();
        public static List<diyet> diyetler = new List<diyet>();

        #region JSON islemleri

        public static void serializeJSON()
        {
            var jsonDiyetsiyenler = JsonConvert.SerializeObject(diyetisyenler); //Kullanıcılar listesini jsona çevirip json değişkenine eşitliyor.
            File.WriteAllText(@".\Diyetisyenler.json", jsonDiyetsiyenler); //Kullanicilar.json adında bir dosya oluşturup json değişkenini o dosyaya yazıyor.

            var jsonHastaliklar = JsonConvert.SerializeObject(hastaliklar);
            File.WriteAllText(@".\Hastaliklar.json", jsonHastaliklar);

            var jsonDiyetler = JsonConvert.SerializeObject(diyetler);
            File.WriteAllText(@".\Diyetler.json", jsonDiyetler);
        }

        public static void deSerializeJSON()
        {
            var jsonVerisi = ""; //Null hatası vermemesi için boş default değer atıyor.
            jsonVerisi = File.ReadAllText(@".\Diyetisyenler.json"); //Kullanicilar.json okuyup içindekileri jsonVerisi değişkenine atıyor.
            if (jsonVerisi != "")
            {
                diyetisyenler = JsonConvert.DeserializeObject<List<diyetisyen>>(jsonVerisi);//jsonVerisini list kullanıcı tipine dönüştürüp kullancılar listesine atıyor.

            }

            var hastalikJsonVerisi = ""; //Null hatası vermemesi için boş default değer atıyor.
            hastalikJsonVerisi = File.ReadAllText(@".\Hastaliklar.json"); //Kullanicilar.json okuyup içindekileri jsonVerisi değişkenine atıyor.
            if (hastalikJsonVerisi != "")
            {
                hastaliklar = JsonConvert.DeserializeObject<List<hastalik>>(hastalikJsonVerisi);//jsonVerisini list kullanıcı tipine dönüştürüp kullancılar listesine atıyor.

            }

            var diyetJsonVerisi = ""; //Null hatası vermemesi için boş default değer atıyor.
            diyetJsonVerisi = File.ReadAllText(@".\Diyetler.json"); //Kullanicilar.json okuyup içindekileri jsonVerisi değişkenine atıyor.
            if (diyetJsonVerisi != "")
            {
                diyetler = JsonConvert.DeserializeObject<List<diyet>>(diyetJsonVerisi);//jsonVerisini list kullanıcı tipine dönüştürüp kullancılar listesine atıyor.

            }
        }

        #endregion
    }





}
