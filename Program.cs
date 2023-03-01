using System;

namespace hatakontrol
{
    class Program
    {
        static void Main(string[]args)
        {
            try
            {
            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayı: "+sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata :"+ ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı");
            }
            

            try
            {
                int a = int.Parse(null);
            }
            catch (ArgumentNullException ex) // null hatası, FormatException == format hatası, OverflowException == minimum veya maksimum değerlerin dışınd olması
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı");
            }
            Console.ReadLine();
        
        }
    }
}

