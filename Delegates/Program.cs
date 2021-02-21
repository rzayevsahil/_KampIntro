using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);
    class Program
    {
        
        static void Main(string[] args)
        {
            CustomerManager customermanager = new CustomerManager();
            //customermanager.SendMessage();
            //customermanager.ShowAlert();

            MyDelegate myDelegate = customermanager.SendMessage;
            myDelegate += customermanager.ShowAlert;
            myDelegate();
            Console.WriteLine("-----------------------");
            myDelegate -= customermanager.SendMessage;
            myDelegate();
            Console.WriteLine("-----------------------");

            MyDelegate2 myDelegate2 = customermanager.SendMessage2;
            myDelegate2 += customermanager.ShowAlert2;
            myDelegate2("Hello"); //aynı delegate i iki operasyona da aynı olarak gönderiyoruz
            Console.WriteLine("-----------------------");

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;
            var sonuc = myDelegate3(2, 3);
            Console.WriteLine(sonuc);


            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    public class Matematik
    {
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
