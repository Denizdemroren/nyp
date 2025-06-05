using System;

namespace AkilliSaglik
{
    public class Tahlil
    {
        public int TahlilID { get; set; }
        public int HastaID { get; set; }
        public string Turu { get; set; }
        public string Sonuc { get; set; }

        public Tahlil(int id, int hastaId, string tur, string sonuc)
        {
            TahlilID = id;
            HastaID = hastaId;
            Turu = tur;
            Sonuc = sonuc;
        }

        public override string ToString()
        {
            return $"[TahlilID: {TahlilID}] HastaID: {HastaID} | Tür: {Turu} | Sonuç: {Sonuc}";
        }
    }
}
