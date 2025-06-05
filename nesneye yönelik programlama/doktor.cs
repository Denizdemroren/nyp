using System;

namespace AkilliSaglik
{
    public class Doktor
    {
        public int DoktorID { get; set; }
        public string AdSoyad { get; set; }
        public string Uzmanlik { get; set; }

        public Doktor(int doktorID, string adSoyad, string uzmanlik)
        {
            DoktorID = doktorID;
            AdSoyad = adSoyad;
            Uzmanlik = uzmanlik;
        }

        public override string ToString()
        {
            return $"DoktorID: {DoktorID}, Adı Soyadı: {AdSoyad}, Uzmanlık: {Uzmanlik}";
        }
    }
}
