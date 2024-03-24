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

        public List<Kitap> KitapList { get; set; } = null;

        public void OduncAl(Kitap kitap, Uye uye)
        {
            if(kitap.Durum == Durum.OduncAlinabilir)
            {
                KitapList.Add(kitap);
                kitap.Durum = Durum.OduncAlindi;
            }
        }
        public void OduncuBırak(Kitap kitap)
        {
            if (kitap.Durum == Durum.OduncAlindi)
            {
                KitapList.Remove(kitap);
                kitap.Durum = Durum.OduncAlinabilir;
            }
        }
    }
}
