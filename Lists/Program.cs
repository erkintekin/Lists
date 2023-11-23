using System.Threading.Channels;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List'ler

            // List'ler collectionlar olarak adlandırılan yapının bir elemanıdır.
            List<int> sayilar = new List<int>();

            // Bu diziye nasıl eleman ekleriz ?
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            sayilar.Add(5);
            sayilar.Add(8);
            sayilar.Add(0);
            sayilar.Add(1);
            sayilar.Add(4);
            sayilar.Add(7);

            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] x = { 2, 4554, 75, 7 };
            //sayilar.AddRange(x);

            // Dizinin uzunluğunu ölçer Length yerine kullanabiliriz.
            //Console.WriteLine(sayilar.Count);

            //bool isExist = sayilar.Contains(1);
            //Console.WriteLine(isExist);


            //sayilar.Clear();
            //Console.WriteLine(sayilar.Count);

            // Koşul sağlanırsa true veya false döner.
            //bool isExist = sayilar.Exists(x => x > 10);
            //Console.WriteLine(isExist);

            // Find koşula uyan ilk elemanı verir. Örn. 2'ye eşit ilk elemanı verir. Koşul sağlanmazsa 0 döner.
            //int falanFilan = sayilar.Find(x => x == 2);
            //Console.WriteLine(falanFilan);

            // Eğer ki hepsini getirmesini istiyorsak dönen verinin list tipinde döneceğini bilmemiz gerekir ve bu durum için kullanacağımız metot FindAll metodudur.

            //List<int> bulunanlar = sayilar.FindAll(x => x > 50);

            //foreach (var item in bulunanlar)
            //{
            //    Console.WriteLine(item);
            //}

            // Aradığımız elemanın index numarasını bulmak için IndexOf. Koşul sağlanmazsa -1 döner.
            //int index = sayilar.IndexOf(1);
            //Console.WriteLine(index);

            // Belirli bir index'e bir sayı eklemek için Insert kullanırız. Örn. 3. index'e 9999 ekle.
            //sayilar.Insert(3, 9999);

            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            // Arraydeki istenen elemanı kaldırmak için Remove kullanırız.
            //sayilar.Remove(9999);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}


            // İstenilen indexteki sayıyı silmek için RemoveAt kullanırız.
            //sayilar.RemoveAt(2);

            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            // Tek satırda foreach çalıştırmak için ForEach kullanırız.
            //sayilar.ForEach(c => Console.WriteLine(c));

            // Diziyi sıralamak için
            //sayilar.Sort();
            //sayilar.Reverse();
            //sayilar.ForEach(c => Console.WriteLine(c));

            //int[] zibam = sayilar.ToArray();

            #endregion

            Random rnd = new Random();

            int bakiye = rnd.Next(0, 1000000);

           

         

            while (true)
            {
                Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz:\n\t1. Bakiye Görüntüleme\n\t2. Para Yatırma\n\t3. Para Çekme\n\t4. Çıkış");
                int secim = int.Parse(Console.ReadLine());
                if (secim == 1)
                {
                    int param = bakiyeGoruntuleme(bakiye);
                    Console.WriteLine($"Bakiyeniz: {param} TL'dir");
                }
                else if (secim == 2)
                {
                    Console.WriteLine($"Anlık bakiyeniz: {bakiye}");
                    Console.WriteLine("Ne kadar para yatıracaksınız?");
                    int yatirilacak = int.Parse(Console.ReadLine());
                    int kalan = paraYatirma(bakiye, yatirilacak);
                    Console.WriteLine($"Bakiyeniz: {kalan}");
                }
                else if (secim == 3)
                {
                    Console.WriteLine($"Anlık bakiyeniz: {bakiye}");
                    Console.WriteLine("Ne kadar para çekeceksiniz?");
                    int cekilecek = int.Parse(Console.ReadLine());
                    int kalan = paraCekme(bakiye, cekilecek);
                    Console.WriteLine($"Bakiyeniz: {kalan}");
                }
                else
                {
                    Console.WriteLine("İyi günler dileriz!");
                    return;
                }

            }
        }

        public static int paraCekme(int bakiye, int cekilecek)
        {
            bakiye = bakiye - cekilecek;
            return bakiye;
        }
        public static int paraYatirma(int bakiye, int yatirilacak)
        {
            bakiye = bakiye + yatirilacak;
            return bakiye;
        }
        public static int bakiyeGoruntuleme(int bakiye)
        {
            return bakiye;
        }
        public static bool cikis()
        {
            return false;
        }




    }
}