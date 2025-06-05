using System;

namespace AkilliSaglik
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!GirisEkrani())
            {
                Console.WriteLine("Çok fazla başarısız giriş denemesi. Program sonlandırılıyor.");
                return;
            }

            Console.Clear();
            Console.WriteLine("Giriş başarılı. Sağlık Sistemi başlatılıyor...\n");

            // HASTALAR
            Hasta hasta1 = new Hasta(1, "Deniz Kaya", "12345678901");
            Hasta hasta2 = new Hasta(2, "Ali Vural", "98765432109");
            Hasta hasta3 = new Hasta(3, "Merve Şahin", "45612378901");

            // TAHLİLLER
            Tahlil tahlil1 = new Tahlil(1, hasta1.HastaID, "Kan Tahlili", "Hemoglobin: 13.5 g/dL");
            Tahlil tahlil2 = new Tahlil(2, hasta2.HastaID, "İdrar Tahlili", "Protein: Negatif, pH: 6.0");
            Tahlil tahlil3 = new Tahlil(3, hasta3.HastaID, "Röntgen", "Sol akciğerde nodül gözlemlenmedi");

            // DOKTORLAR
            Doktor doktor1 = new Doktor(1, "Dr. Ayşe Yılmaz", "Dahiliye");
            Doktor doktor2 = new Doktor(2, "Dr. Ahmet Demir", "Kardiyoloji");
            Doktor doktor3 = new Doktor(3, "Dr. Elif Arslan", "Ortopedi");

            // RANDEVULAR
            Randevu randevu1 = new Randevu(1, hasta1.HastaID, doktor1.DoktorID, DateTime.Now.AddDays(1));
            Randevu randevu2 = new Randevu(2, hasta2.HastaID, doktor2.DoktorID, DateTime.Now.AddDays(2));
            Randevu randevu3 = new Randevu(3, hasta3.HastaID, doktor3.DoktorID, DateTime.Now.AddDays(3));

            // REÇETELER
            Recete recete1 = new Recete(1, hasta1.HastaID, doktor1.DoktorID, "Parol, Klamoks");
            Recete recete2 = new Recete(2, hasta2.HastaID, doktor2.DoktorID, "Aspirin, Coraspin");
            Recete recete3 = new Recete(3, hasta3.HastaID, doktor3.DoktorID, "Augmentin, Vermidon");

            // HASTA SEÇİMİ
            Console.WriteLine("Hangi hastanın bilgilerini görmek istiyorsunuz?");
            Console.WriteLine("1 - " + hasta1.AdSoyad);
            Console.WriteLine("2 - " + hasta2.AdSoyad);
            Console.WriteLine("3 - " + hasta3.AdSoyad);
            Console.Write("Seçiminiz (1-3): ");
            string secim = Console.ReadLine();

            Console.Clear();

            switch (secim)
            {
                case "1":
                    Yazdir(hasta1, doktor1, randevu1, recete1, tahlil1);
                    break;
                case "2":
                    Yazdir(hasta2, doktor2, randevu2, recete2, tahlil2);
                    break;
                case "3":
                    Yazdir(hasta3, doktor3, randevu3, recete3, tahlil3);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }

            Console.WriteLine("\nProgram sonlandı. Çıkmak için bir tuşa basınız.");
            Console.ReadKey();
        }

        static bool GirisEkrani()
        {
            string dogruKullanici = "admin";
            string dogruSifre = "1234";
            int hak = 3;

            while (hak > 0)
            {
                Console.Write("Kullanıcı Adı:");
                string kullaniciAdi = Console.ReadLine();

                Console.Write("Şifre:");
                string sifre = Console.ReadLine();

                if (kullaniciAdi == dogruKullanici && sifre == dogruSifre)
                {
                    return true;
                }
                else
                {
                    hak--;
                    Console.WriteLine($"Hatalı giriş. Kalan deneme hakkı: {hak}\n");
                }
            }

            return false;
        }

        static void Yazdir(Hasta hasta, Doktor doktor, Randevu randevu, Recete recete, Tahlil tahlil)
        {
            Console.WriteLine("==== HASTA BİLGİLERİ ====");
            Console.WriteLine(hasta);

            Console.WriteLine("\n==== DOKTOR BİLGİLERİ ====");
            Console.WriteLine(doktor);

            Console.WriteLine("\n==== RANDEVU BİLGİLERİ ====");
            Console.WriteLine(randevu);

            Console.WriteLine("\n==== REÇETE BİLGİLERİ ====");
            Console.WriteLine(recete);

            Console.WriteLine("\n==== TAHLİL BİLGİLERİ ====");
            Console.WriteLine(tahlil);
        }
    }
}
