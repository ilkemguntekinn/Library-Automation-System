using CSProjeDemo1;

namespace libraryAutomationSystem
{
    public abstract class Kitap
    {
        public string KitapNo { get; set; }
        public string ISBN { get; set; }
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public string YayınYili { get; set; }
        public Durum Durum { get; set; }
        public KitapTuru KitapTuru { get; set; }

        public Kitap(string kitapNo, string iSBN, string baslik, string yazar, string yayinYili, KitapTuru kitapTuru)
        {
            if (string.IsNullOrWhiteSpace(kitapNo)) { throw new ArgumentNullException("kitap no null ya da boş olamaz."); }
            if (string.IsNullOrWhiteSpace(iSBN)) { throw new ArgumentNullException("ISBN null ya da boş olamaz"); }
            if (string.IsNullOrWhiteSpace(yazar)) { throw new ArgumentNullException("Yazar null ya da boş olamaz."); }
            if (string.IsNullOrWhiteSpace(baslik)) { throw new ArgumentNullException("Başlık null ya da boş olamaz."); }
            if (string.IsNullOrWhiteSpace(yayinYili)) { throw new ArgumentNullException("Yayın yılı null ya da boş olamaz."); }
            ISBN = iSBN;
            Baslik = baslik;
            Yazar = yazar;
            YayınYili = yayinYili;
            Durum = Durum.OduncAlinabilir;
            KitapTuru = kitapTuru;
        }
    }
}