using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdirma Komutlari

            //Console.WriteLine("Hello World");
            //Console.WriteLine("Hi");

            //Console.WriteLine("-----Yemek Kategorileri-----");
            //Console.WriteLine();
            //Console.WriteLine("1- Corbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soguk Baslangiclar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlilar");
            //Console.WriteLine("6- Icecekler");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");

            #endregion

            #region Degiskenler

            //string customerName, customerSurname, customerPhone, customerEmail, district, city;

            //customerName = "Ertugrul";
            //customerSurname = "Atasoy";
            //customerPhone = "+90 500 500 50 50";
            //customerEmail = "info@gmail.com";
            //district = "Kadikoy";
            //city = "Istanbul";

            //Console.WriteLine("----- Rezervasyon Karti -----");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Musteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Iletisim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + " / " + city);
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();

            //customerName = "Alptug";
            //customerSurname = "Demirel";
            //customerPhone = "+90 500 600 60 60";
            //customerEmail = "info@hotmail.com";
            //district = "Beypazari";
            //city = "Ankara";

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Musteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Iletisim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + " / " + city);
            //Console.WriteLine("-----------------------------");

            #endregion

            #region Integer Degiskenler

            //int number = 10;
            //Console.WriteLine(number);

            int hamburgerPrice = 350;
            int pizzaPrice = 200;
            int friesPrice = 50;
            int cokePrice = 40;
            int lemonadePrice = 50;
            int waterPrice = 10;

            Console.WriteLine("----- Restoran Menu Fiyati -----");
            Console.WriteLine();
            Console.WriteLine("- Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("- Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("- Fries: " + friesPrice + " TL");
            Console.WriteLine("- Coke: " + cokePrice + " TL");
            Console.WriteLine("- Lemonade: " + lemonadePrice + " TL");
            Console.WriteLine("- Water: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("----- Restoran Menu Fiyati -----");
            Console.WriteLine();

            int hamburgerCount, pizzaCount, friesCount, cokeCount, lemonadeCount, waterCount;

            int totalHamburgerPrice;
            int totalPizzaPrice;
            int totalFriesPrice;
            int totalCokePrice;
            int totalLemonadePrice;
            int totalWaterPrice;

            hamburgerCount = 2;
            pizzaCount = 1;
            friesCount = 2;
            cokeCount = 2;
            lemonadeCount = 1;
            waterCount = 3;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalWaterPrice = waterPrice * waterPrice;

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("- Total Hamburger Price: " + totalHamburgerPrice + " TL");
            Console.WriteLine("- Total Pizza Price: " + totalPizzaPrice + " TL");
            Console.WriteLine("- Total Fries Price: " + totalFriesPrice + " TL");
            Console.WriteLine("- Total Coke Price: " + totalCokePrice + " TL");
            Console.WriteLine("- Total Lemonade Price: " + totalLemonadePrice + " TL");
            Console.WriteLine("- Total Water Price: " + totalWaterPrice + " TL");
            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalPizzaPrice + totalFriesPrice + totalCokePrice + totalLemonadePrice + totalWaterPrice;

            Console.WriteLine("Total Price: " + totalPrice + " TL");

            #endregion

            Console.Read();
        }
    }
}
