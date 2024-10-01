using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Degiskenler

            //double number;
            //number = 0.50;
            //Console.WriteLine(number);

            //Console.WriteLine("----- Fiyat Listesi -----");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 13.21;
            //orangePrice = 25.33;
            //strawberryPrice = 42;
            //potatoPrice = 8.65;
            //tomatoPrice = 8.88;

            //Console.WriteLine("- Elma Birim Fiyati:" + applePrice + " TL");
            //Console.WriteLine("- Portakal Birim Fiyati:" + orangePrice + " TL");
            //Console.WriteLine("- Çilek Birim Fiyati:" + strawberryPrice + " TL");
            //Console.WriteLine("- Patates Birim Fiyati:" + potatoPrice + " TL");
            //Console.WriteLine("- Domates Birim Fiyati:" + tomatoPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("----- Fiyat Listesi -----");
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram; ;

            //appleGram = 1.350;
            //orangeGram = 2.234;
            //strawberryGram = 0.242;
            //potatoGram = 5.342;
            //tomatoGram = 4.123;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice; ;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alinan Urun: Elma " + " - Birim Fiyati: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice + " TL");
            //Console.WriteLine("Alinan Urun: Portakal " + " - Birim Fiyati: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice + " TL");
            //Console.WriteLine("Alinan Urun: Cilek " + " - Birim Fiyati: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice + " TL");
            //Console.WriteLine("Alinan Urun: Patates " + " - Birim Fiyati: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice + " TL");
            //Console.WriteLine("Alinan Urun: Domates " + " - Birim Fiyati: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice + " TL");
            //Console.WriteLine();

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("Toplam Alisveris Tutari: " + shoppingTotalPrice + " TL");

            #endregion

            #region Char Degiskenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girisleri

            //Console.WriteLine("----- CSharp Hava Yollari Yolcu Bilgisi -----");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIDNo;

            //Console.Write("Yolcu Adi: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadi: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIDNo = Console.ReadLine();

            //Console.Write("Yolcu Yas: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Ilce Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Sehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------");
            //Console.WriteLine("- Yolcu TC Kimlik No: " + passengerIDNo + " Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerAge + " " + passengerDistrict + " / " + passengerCity);

            #endregion

            #region Klavyeden Tam Sayi Girisleri ve Donusumler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1500;
            //computerPrice = 35000;
            //chairPrice = 2500;
            //tvPrice = 17000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lutfen aldiginiz ayakkabi sayisini giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen aldiginiz bilgisayar sayisini giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen aldiginiz sandalye sayisini giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen aldiginiz televizyon sayisini giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine();

            //Console.WriteLine("Toplam Odemeniz Gereken Tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalikli Sayi Islemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lutfen 1. Sinav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lutfen 2. Sinav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lutfen 3. Sinav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sinav Ortalamaniz: " + result);

            #endregion

            #region Klavyeden Karakter Girisleri

            //char gender;
            //Console.Write("Lutfen cinsiyet seciniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Sectiginiz cinsiyet: " + gender);

            #endregion


            Console.Read();


        }
    }
}
