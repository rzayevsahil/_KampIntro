using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = Topla; //3 tane int yazmamızın sebebi ilk değerlerin tipi int sonucun da değer tipi int olması demek
            Console.WriteLine(add(3, 5));
            Console.WriteLine("-------------------------");
            Func<int> getRandomNumber = delegate ()
              {
                  Random random = new Random();
                  return random.Next(1, 100);
              };
            Console.WriteLine(getRandomNumber());
            Console.WriteLine("-------------------------");

            Thread.Sleep(1000);//randomlar aynı sayıyı üretiyor diye 1 saniye beklediyoruz randomların birini

            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber2());

            Console.WriteLine("-------------------------");
            Console.WriteLine(Topla(2, 3));

            Console.ReadLine();
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }
    }
}
