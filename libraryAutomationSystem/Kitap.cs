using CSProjeDemo1;

namespace libraryAutomationSystem
{
    public abstract class Kitap
    {
        public string ISBN { get; set; }
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public string YayınYılı { get; set; }
        public Durum Durum { get; set; }
        public string Tur {  get; set; }
    }
}