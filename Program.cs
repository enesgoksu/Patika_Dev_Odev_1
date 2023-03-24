namespace Patika_Dev_Odev_1.Patika_Dev_Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcadan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanları console'a yazdırın.


            Console.Write("Pozitif bir sayı giriniz: ");
            int pozitifSayi = int.Parse(Console.ReadLine());
            Console.WriteLine(+pozitifSayi +" "+"adet sayı giriniz.");
            int[] sayilar = new int [pozitifSayi];
            
            

            for (int i = 0; i < pozitifSayi; i++)
            {
                Console.Write("Sayı giriniz: ");
                int sayi = int.Parse(Console.ReadLine());
                sayilar[i] = sayi;           
            }

            for (int i = 0; i < pozitifSayi; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    Console.WriteLine("Girmiş olduğunuz çift sayı: " + sayilar[i]);
                }
            }

            // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n,m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit ya da tam bölünenleri console'a yazdırın.

            Console.Write("1.sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2.sayıyı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine(+ sayi1+" "+"adet sayı giriniz.");
            int[] sayilar = new int [sayi1];

            for (int i = 0; i < sayi1; i++)
            {
                Console.Write("{0}.sayıyı giriniz: ", i+1);
                int sayi = int.Parse(Console.ReadLine());
                sayilar[i] = sayi;
            }
            
            for (int i = 0; i < sayi1; i++)
            {
                if ((sayilar[i] == sayi2) || (sayilar[i] % sayi2 == 0))
                {
                    Console.WriteLine("Koşulunu sağlayan sayı: "+ sayilar[i]);
                }
            }

            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet kelime girmesini isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.Write("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Bir sonraki aşamada"+" "+sayi+" "+"adet kelime girmeniz istenecektir.");
            string[] kelimeler = new string [sayi];

            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine("{0}. girmek istediğiniz kelimeyi girin: ", i + 1);
                string kelime = Console.ReadLine();
                kelimeler[i] = kelime;
            }

                Console.WriteLine("***********");

                Array.Reverse(kelimeler);
                foreach (var kelime1 in kelimeler)
                {
                    Console.WriteLine(kelime1);
                }


            // Bir konsol uygulamasında kullanıcıdan bir cümle yazmasını isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.Write("Bir Cümle yazınız: ");
            string cümle = Console.ReadLine();
            string[] kelimeler = cümle.Split(" ");
            Console.WriteLine("Kelime sayısı: "+ kelimeler.Length);

            foreach (var kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }

            Console.WriteLine("Toplam harf: "+cümle.Length);




            
            


                
        
        }
    }
}