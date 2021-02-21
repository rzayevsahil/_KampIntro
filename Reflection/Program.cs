using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //    DortIslem dortIslem = new DortIslem(2, 3); //1
            //    Console.WriteLine(dortIslem.Topla2());
            //    Console.WriteLine(dortIslem.Topla(3, 4));

            var tip = typeof(DortIslem);
            //var dortIslem = Activator.CreateInstance(type); //1 numaralı satırla bu aynı 
            //DortIslem dortIslem =(DortIslem) Activator.CreateInstance(tip,6,7);
            //Console.WriteLine(dortIslem.Topla(5, 4));
            //Console.WriteLine(dortIslem.Topla2());

            var instance = (DortIslem)Activator.CreateInstance(tip, 6, 5);
            //Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null));  //parametresiz topla2 çalıştığı için invoke null yaptık...incoke la o metoda ulaşıb çalıştırıyoruz
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));

            Console.WriteLine("--------------------------------------------------");
            var metotlar = tip.GetMethods();
            foreach (var info in metotlar)
            {
                Console.WriteLine("Metot adı : {0}",info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre : {0}",parameterInfo.Name);
                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Atrtibute Name : {0}", attribute.GetType().Name);
                }
            }

            Console.ReadLine();
            
        }
    }
    public class DortIslem
    {
        int _sayi1;
        int _sayi2;
        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public DortIslem()
        {

        }

        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        [MetodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

        public class MetodNameAttribute:Attribute
        {
            string _name;

            public MetodNameAttribute(string name)
            {
                _name = name;
            }
        }
    }
}
