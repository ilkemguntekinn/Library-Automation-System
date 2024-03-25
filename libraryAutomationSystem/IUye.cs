using libraryAutomationSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public interface IUye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string UyeNo { get; set; }
        public List<Kitap> KitapListesi { get; set; }
        public void OduncAl(Kitap kitap);
        public void OduncBirak(Kitap kitap);
    }
}
