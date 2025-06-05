using System;

namespace AkilliSaglik
{
    public class Randevu
    {
        public int RandevuID { get; set; }
        public int HastaID { get; set; }
        public int DoktorID { get; set; }
        public DateTime Tarih { get; set; }

        public Randevu(int randevuID, int hastaID, int doktorID, DateTime tarih)
        {
            RandevuID = randevuID;
            HastaID = hastaID;
            DoktorID = doktorID;
            Tarih = tarih;
        }

        public override string ToString()
        {
            return $"RandevuID: {RandevuID}, HastaID: {HastaID}, DoktorID: {DoktorID}, Tarih: {Tarih}";
        }
    }
}
