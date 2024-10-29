using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //void customerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //}

            //CustomerList();
            //Console.WriteLine("--------------------");
            //CustomerList();
            //Console.WriteLine("--------------------");
            //CustomerList();
            //Console.WriteLine("--------------------");
            //CustomerList();

            //void sumMethods()
            //{
            //    int number1 = 15;
            //    int number2= 22;
            //    int result = number1 + number2;
            //    Console.WriteLine(result);
            //}

            //sumMethods();

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void writeMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //writeMethod("Kerim Acar");

            //void customerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name+ " " + surName);
            //}

            //customerCard("Kerim", "Acar");
            //customerCard("Tuna", "Durukan");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void sum(int num1, int num2, int num3)
            //{
            //    int result = num1 + num2 + num3;
            //    Console.WriteLine("Sonuç: " + result);
            //}

            //sum(42, 33, 21);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string customerName()
            //{
            //    return "Kerim ACAR";
            //}

            //customerName();

            //string studentCard()
            //{
            //    string name = "Kerim";
            //    string surname = "ACAR";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(studentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + "\n" + "Başkent: " + capital + "\n" + "Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x= Console.ReadLine();
            //Console.Write("Başkenti Giriniz: ");
            //y= Console.ReadLine();
            //Console.Write("Bayrak Rengini Giriniz: ");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı - Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int num1, int num2)
            //{
            //    int result = num1 + num2;
            //    return result;
            //}

            //Console.WriteLine(Sum(41,55));
            //Console.WriteLine(Sum(36,346));
            //Console.WriteLine(Sum(44,67));
            //Console.WriteLine(Sum(84,61));

            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " " + result + " puan ile " + "Başarılı oldu.";
            //    }
            //    else
            //    {
            //        return student + " " + result + " puan ile " + "Başarısız oldu.";
            //    }
            //}

            //Console.WriteLine(ExamResult("Kerim Acar", 87, 53, 83));
            //Console.WriteLine(ExamResult("Tuna Durukan", 45, 65, 42));

            #endregion

            Console.Read();
        }
    }
}
