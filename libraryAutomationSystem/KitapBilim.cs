using libraryAutomationSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class KitapBilim(string kitapNo, string iSBN, string baslik, string yazar, string yayinYili) : Kitap(kitapNo, iSBN, baslik, yazar, yayinYili, KitapTuru.Bilim)
    {
    }
}
