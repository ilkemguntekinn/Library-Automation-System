using libraryAutomationSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class Uye : IUye
    {
        public string Ad { get; set; } = null!;

        public string Soyad { get; set; } = null!;

        public string UyeNo { get; set; } = null!;

        public List<Kitap> KitapListesi { get; set; }

        public Uye()
        {
            KitapListesi = [];
        }    

        public void OduncAl(Kitap kitap)
        {
            ArgumentNullException.ThrowIfNull(kitap);

            if (KitapListesi != null && KitapListesi.Any(x => x.KitapNo == kitap.KitapNo )) {
                throw new Exception("Kitap zaten ödünç alınmış.");
            }
            if(kitap.Durum != Durum.OduncAlinabilir)
            {
                throw new Exception("Kitabın durumu ödünç alınmaya uygun değil");
            }
            KitapListesi.Add(kitap);
        }

        public void OduncBirak(Kitap kitap)
        {
            ArgumentNullException.ThrowIfNull(kitap);

            if (KitapListesi != null && !KitapListesi.Any(x => x.KitapNo == kitap.KitapNo))
            {
                throw new Exception("Bu kitap ödünç alınmamış.");
            }
            KitapListesi.RemoveAll(x => x.KitapNo == kitap.KitapNo);
        }
    }
}
