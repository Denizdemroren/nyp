using System;

namespace AkilliSaglik
{
    public class Hasta
    {
        public int HastaID { get; set; }
        public string AdSoyad { get; set; }
        public string TCKN { get; set; }

        public Hasta(int hastaID, string adSoyad, string tckn)
        {
            HastaID = hastaID;
            AdSoyad = adSoyad;
            TCKN = tckn;
        }

        public override string ToString()
        {
            return $"HastaID: {HastaID}, Adı Soyadı: {AdSoyad}, TCKN: {TCKN}";
        }
    }
}
