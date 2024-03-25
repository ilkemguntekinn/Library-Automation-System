using libraryAutomationSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public static class Kutuphane
    {

        private static List<Kitap> KitapListesi = new List<Kitap>();
        private static List<IUye> UyeListesi = new List<IUye>();

        public static void KitapEkle(Kitap kitap)
        {
            ArgumentNullException.ThrowIfNull(kitap);

            if(KitapListesi.Any(x => x.KitapNo == kitap.KitapNo)) {
                throw new Exception("Bu numaralı bir kitap zaten bulunmaktadır.");
            }
            KitapListesi.Add(kitap);
        }

        public static List<Kitap> KitapListele()
        {
            return KitapListesi;
        } 

        public static List<Kitap> OduncAlinabilirKitaplariListele()
        {
            return KitapListesi.Where(x => x.Durum == Durum.OduncAlinabilir).ToList();
        }

        public static List<Kitap> OduncAlinmisKitaplariListele()
        {
            return KitapListesi.Where(x => x.Durum == Durum.OduncAlindi).ToList();
        }

        public static void UyeEkle(IUye uye)
        {
            ArgumentNullException.ThrowIfNull(uye);
            if(UyeListesi.Any(x => x.UyeNo == uye.UyeNo))
            {
                throw new Exception("Aynı numaralı başka bir üye bulunmaktadır.");
            }

            UyeListesi.Add(uye);
        }

        public static List<IUye> UyeListele()
        {
            return UyeListesi;
        }
        public static IUye UyeGetir(string uyeNo)
        {
            return UyeListesi.Where(x => x.UyeNo == uyeNo).First();
        }

        public static void KitapOduncAl(string kitapNo, Uye uye)
        {
            Kitap kitap = KitapListesi.Where(x => x.KitapNo == kitapNo).First();
            if (kitap == null)
            {
                throw new Exception("bu numaralı bir kitap bulunamadı.");
            }
            uye.OduncAl(kitap);
            kitap.Durum = Durum.OduncAlindi;
        }

        public static void KitapOduncVer(string kitapNo, Uye uye)
        {
            
            Kitap kitap = KitapListesi.Where(x => x.KitapNo == kitapNo).First();
            if(kitap == null)
            {
                throw new Exception("bu numaralı bir kitap bulunamadı.");
            }
            uye.OduncBirak(kitap);
            kitap.Durum = Durum.OduncAlinabilir;
        }

        /*
         * Yazdır fonksiyonları eklenebilir.
         */
    }
}
