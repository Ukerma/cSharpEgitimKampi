using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1; 2; 3; 4)
            //1: Değişken türü
            //2: Değişken adı
            //3: In
            //4: Liste, koleksiyon, dizi

            //string[] cities = { "istanbul", "adana", "ankara", "şanlıurfa" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.Write("Lütfen kelimeyi giriniz: ");
            //string word = Console.ReadLine();

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////Sınıftaki öğrenci mevcudunu kullanıcıdan alma

            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfınızda kaç öğrenci var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            ////Öğrenci isim ve ortalamalarını saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //Her öğrenci için 3 sınav notu alınacak
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value; //notları toplama işlemi
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult / 3;
            //}

            ////Sınav ortalamaları
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("------------------------------");
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

            //    //Öğrencilerin geçip kalma durumları
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
            //    }
            //    Console.WriteLine("------------------------------");
            //}

            #endregion

            Console.Read();
        }
    }
}
