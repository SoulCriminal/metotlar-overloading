using System;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "123";
            int intsayi;

            bool sonuc = int.TryParse(sayi, out intsayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(intsayi);
            }else 
            {
                Console.WriteLine("Başarısız!");
            }
            Metodlar yeni = new Metodlar();
            yeni.Topla(7,3, out int toplamSonuc);
            // Console.WriteLine(toplamSonuc);
            yeni.EkranaYazdir(toplamSonuc);

            // Overloading yapılmış ekrana yazdırma metotu(string)
            string ad = "Hakki";
            string soyad = "Ayman";
            yeni.EkranaYazdir(ad,soyad);// aşağıda overload yaptığımız string metodu girilen 2 string parametresinin arasına 1 karakter boşluk bırakıp ekrana yazdırıyor.
            
        }
    }
    class Metodlar
    {
        public void Topla(int a , int b, out int toplam)
        {
            toplam = a+b;
        }

        // Metot overload etmek (aşırı yüklemek) bir metoda birden fazla iş yüklemek
        // aşağıdaki gibi ekrana yazdir metodu hem string hem int türündeki değerleri ekrana yazdiırabiliyor.
       // metot overloading olabilmesi içinyazılan metotlar birbirinden farklı ve kullanım şekilleri aynı olmalıdır. örnek aşağıdakiler gibi
       
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1+" "+ veri2);
        }
    }
}
