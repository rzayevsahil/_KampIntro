using System;

namespace Abstract_5gun.odev_
{
    class Program
    {
        static void Main(string[] args)
        {
            TuretilmisSinif turetilmisSinif = new TuretilmisSinif();
            turetilmisSinif.Metot1();
            turetilmisSinif.Metot2();
            turetilmisSinif.Metot3();


            Console.ReadLine();
        }
    }

    abstract class TemelSinif : AbstractSinif
    {
        public void Metot1()
        {
            Console.WriteLine("Abstract sınıfı içinde tanımlanmış metot");
        }
        public abstract void Metot2();
    }

    abstract class AbstractSinif
    {
        public void Metot3()
        {
            Console.WriteLine("Abstract sınıf");
        }
        
    }

    class TuretilmisSinif : TemelSinif
    {
        public override void Metot2()
        {
            Console.WriteLine("Türetilmiş sınıf içinde tanımlanmış metot");
        }
    }
}
