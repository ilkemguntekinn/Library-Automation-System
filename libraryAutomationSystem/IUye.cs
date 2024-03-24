using libraryAutomationSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    internal interface IUye
    {
        string Ad { get; set; }
        string Soyad { get; set; }
        string UyeNo { get; set; }
        List<Kitap> KitapList { get; set; }
        public void OduncAl() { }
        public void OduncuBırak() { }
    }
}
