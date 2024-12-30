using System;
using System.Collections.Generic;
using System.Linq;

namespace OgrenciYonetimUygulamasi
{
    internal class Program
    {
        static List<Ogrenci> ogrenciler = new List<Ogrenci>();

        static void Main(string[] args)
        {
            Uygulama();
        }

        static void Uygulama()
        {
            SahteVeriEkle();
            Menu();

            while (true)
            {
                Console.Write("Seçiminiz :");
                string giris = Console.ReadLine().ToUpper();

                switch (giris)
                {
                    case "E":
                    case "1":
                        OgrenciEkle();
                        break;
                    case "L":
                    case "2":
                        OgrenciListele();
                        break;
                    case "S":
                    case "3":
                        OgrenciSil();
                        break;
                    case "4":
                    case "X":
                        CıkısYap();
                        break;
                    default:
                        SecimAl();
                        break;
                }
                Console.WriteLine();
                
            }

        }

        static void SecimAl()
        {
            Console.WriteLine("Hatalı giriş yapıldı.");
            Console.Write("Seçiminiz: ");
            string giris = Console.ReadLine().ToUpper();

            List<string> sec = new List<string>();

            sec.Add("E");
            sec.Add("1");
            sec.Add("L");
            sec.Add("2");
            sec.Add("S");
            sec.Add("3");
            sec.Add("X");
            sec.Add("4");

            bool varMi = sec.Contains(giris);

            if (varMi == false)
            {
                int[] dongu = new int[8];
                for (int i = 0; i < dongu.Length; i++)
                {

                    Console.WriteLine("Hatalı giriş yapıldı.");
                    Console.Write("Seçimiz: ");
                    giris = Console.ReadLine();

                    if (varMi == true)
                    {
                        break;
                    }
                }
                Console.WriteLine("Üzgünüm sizi anlayamıyorum.Program sonlandırılıyor.");
            }Environment.Exit(0);
        }

        static void OgrenciEkle()
        {
            Ogrenci o = new Ogrenci();

            Console.WriteLine("1- Öğrenci Ekle ----------");
            Console.WriteLine((ogrenciler.Count + 1) + ". Öğrencinin");

            tekrar:
            Console.Write("No: ");
            o.No = int.Parse(Console.ReadLine());

            foreach (Ogrenci item in ogrenciler)
            {
                if(o.No == item.No)
                {
                    Console.WriteLine("Bu numara kullanılmaktadır.");
                    goto tekrar;
                }
                
            }

            Console.Write("Adı: ");
            o.Ad = Console.ReadLine();
            string basharf1 = o.Ad.Substring(0,1).ToUpper();
            string digerharfler1 = o.Ad.Substring(1).ToLower();
            o.Ad = basharf1 + digerharfler1;

            Console.Write("Soyadı: ");
            o.Soyad = Console.ReadLine();
            string basharf2 = o.Soyad.Substring(0, 1).ToUpper();
            string digerharfler2 = o.Soyad.Substring(1).ToLower();
            o.Soyad = basharf2 + digerharfler2;

            Console.Write("Şubesi: ");
            o.Sube = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Öğrenciyi kaydetmek istediğinize emin misiniz? (E/H) ");
            string secim = Console.ReadLine().ToUpper();

            if (secim == "E")
            {
                ogrenciler.Add(o);
                Console.WriteLine("Öğrenci eklendi.");
            }
            else
            {
                Console.WriteLine("Öğrenci eklenmedi.");
            }
            Console.WriteLine();

        }

        static void OgrenciListele()
        {
           if(ogrenciler.Count == 0)
            {
                Console.WriteLine("Gösterilecek öğrenci yok.");
            }
           else
            {
                Console.WriteLine("2- Öğrenci Listele-----------");
                Console.WriteLine();
                Console.WriteLine("Şube    No    Ad Soyad");
                Console.WriteLine("---------------------------------- ");

                foreach (Ogrenci item in ogrenciler)
                {
                   Console.WriteLine(item.Sube.PadRight(8) + item.No.ToString().PadRight(5) +  item.Ad.PadRight(2) + item.Soyad);
                }
            }
           


        }

        static void OgrenciSil()
        {
            Console.WriteLine("3- Öğrenci Sil ----------");

            if (ogrenciler.Count() == 0)
            {
                Console.WriteLine("Listede silinecek öğrenci yok.");
                return;
            }
            Console.WriteLine("Silmek istediğiniz öğrencinin");
            Console.Write("No: ");
            int no = int.Parse(Console.ReadLine());

            Ogrenci ogr = null;

            foreach (Ogrenci item in ogrenciler)
            {
                if (item.No == no)
                {
                    ogr = item;
                    break;
                }
            }

            if (ogr != null)
            {
                Console.WriteLine("Adı : " + ogr.Ad);
                Console.WriteLine("Soyadı : " + ogr.Soyad);
                Console.WriteLine("Şubesi : " + ogr.Sube);
                Console.WriteLine();
                Console.Write("Öğrenciyi silmek istediğinize emin misiniz? (E/H) ");
                string secim = Console.ReadLine().ToUpper();

                if (secim == "E")
                {
                    ogrenciler.Remove(ogr);
                    Console.WriteLine("Öğrenci silindi.");
                }
                else
                {
                    Console.WriteLine("Öğrenci silinmedi.");
                }
            }
            else
            {
                Console.WriteLine("Böyle bir öğrenci bulunamadı");
            }

        }

        static void Menu()
        {
            Console.WriteLine("Öğrenci Yönetim Uygulaması ");
            Console.WriteLine("1 - Öğrenci Ekle(E)        ");
            Console.WriteLine("2 - Öğrenci Listele(L)     ");
            Console.WriteLine("3 - Öğrenci Sil(S)         ");
            Console.WriteLine("4 - Çıkış(X)               ");
            Console.WriteLine();
        }

        static void SahteVeriEkle()
        {
            Ogrenci o1 = new Ogrenci();
            o1.Ad = "veli";
            o1.Soyad = "küçük";
            o1.No = 1;
            o1.Sube = "A";
            ogrenciler.Add(o1);

            Ogrenci o2 = new Ogrenci();
            o2.Ad = "ali";
            o2.Soyad = "yılmaz";
            o2.Sube = "B";
            o2.No = 2;
            ogrenciler.Add(o2);

            Ogrenci o3 = new Ogrenci();
            o3.Ad = "Ayşe";
            o3.Soyad = "yıldız";
            o3.No = 3;
            o3.Sube = "C";
            ogrenciler.Add(o3);
        }

        static void CıkısYap()
        {
            Environment.Exit(0);
        }

    }
}
