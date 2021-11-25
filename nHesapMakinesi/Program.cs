using System;

namespace nHesapMakinesi
{
    class Program
    {
        static void Main(string[] args)//Bahar Merdamert n tane sayı ile dört işlem yapma
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz...(+ , - , * , /)");
            char islem = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Lütfen işlem yapılacak sayı adedini giriniz");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i+1}.sayıyı giriniz.");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            float sonuc = 0;

            switch (islem)
            {
                case '+':
                    sonuc = Toplama(sayilar);
                    break;
                case '-':
                    sonuc = Cikarma(sayilar);
                    break;
                case '*':
                    sonuc = Carpim(sayilar);
                    break;
                case '/':
                    sonuc = Bölme(sayilar);
                    break;
            }

            Console.WriteLine($"İşlem sonucunuz {sonuc}");
           

            Console.ReadKey();

        }

        private static float Toplama(params int[] toplama) // 
        {
            float toplam = 0;

            foreach (var item in toplama)
                toplam += item;

            return toplam;
        }

      
        private static float Cikarma(params int[] cikarma) // 
        {

            float cikarmaSonucu = cikarma[0];
            for (int i = 1; i < cikarma.Length; i++)
            {
                cikarmaSonucu -= cikarma[i];
            }

            return cikarmaSonucu;
        }

        private static float Carpim(params int[] carpim) // 
        {
            float carpimSonucu = carpim[0];
            for (int i = 1; i < carpim.Length; i++)
            {
                carpimSonucu *= carpim[i];
            }

            return carpimSonucu;
        }

        private static float Bölme(params int[] bölme) // 
        {
            float bölmeSonucu = bölme[0];
            for (int i = 1; i < bölme.Length; i++)
            {
                bölmeSonucu /= bölme[i];
            }

            return bölmeSonucu;
        }

    }
}
