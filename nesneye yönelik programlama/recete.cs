using System;

namespace AkilliSaglik
{
    public class Recete
    {
        public int ReceteID { get; set; }
        public int HastaID { get; set; }
        public int DoktorID { get; set; }
        public string Ilaclar { get; set; }

        public Recete(int receteID, int hastaID, int doktorID, string ilaclar)
        {
            ReceteID = receteID;
            HastaID = hastaID;
            DoktorID = doktorID;
            Ilaclar = ilaclar;
        }

        public override string ToString()
        {
            return $"Reçete No: {ReceteID}, HastaID: {HastaID}, DoktorID: {DoktorID}, İlaçlar: {Ilaclar}";
        }
    }
}
