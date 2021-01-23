using System;
using System.Linq;

namespace DegerVeReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //********** değer tip ve referans tip farkı **********

            /*int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            //sayi1 ?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);
            //sayilar[0]=? cevap 999....*/

            //******************* ref ve out keyword farkı ***************

            /*int number1=30; //ref için bu değeri set etmemiz gerekir(yani bi değer vermemiz lazım)
            //out da böyle bişeye ihtiyaç yok(değer versek de vermesek de çalışır)
            int number2 = 100;
            //var result = Add(number1, number2);
            //Console.WriteLine(result);
            //Console.WriteLine(number1); //20

            var result2 = Add1(ref number1, number2);
            Console.WriteLine(result2);
            //Console.WriteLine(number1); //30

            var result3 = Add2(out number1, number2);
            Console.WriteLine(result3);
            Console.WriteLine(number1);//30*/

            //********************** Method overloading ***********************

            /*Console.WriteLine(Multiply(2,4)); //8
            Console.WriteLine(Multiply(2, 4, 5)); //40*/

            //********************** Params keyword ********************

            Console.WriteLine(Add3(1,2,3,4,5,6));//parantez içine istediğimiz kadar sayı ekleyerek toplaya biliriz
            




            Console.ReadLine();
        }
        static int Add(int number1, int number2)
        {
            number1= 30;
            return number1 + number2;
        }

        static int Add1(ref int number1, int number2)
        {
            number1 = 30;  //ref için bu değeri set etsek de etmesek de fark etmez.
            return number1 + number2;
        }

        static int Add2(out int number1, int number2)
        {
            number1 = 30; //out için bu değeri set etmemiz gerekir(yani bi değer vermemiz lazım)
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add3(int number,params int[] numbers)//int number eklersek o ilk rakamı alır diğerleri params içinde kalır hesaplanır or:1,2,3 cevap 5 olur
        {
            return numbers.Sum();
        }
    }
}
