using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Sahil";

            //string[] students2 = new[] { "Engin", "Derin", "Sahil" }; //böyle de tanımlaya biliriz...
            //string[] students2 = new string[3] { "Engin", "Derin", "Sahil" };
            string[] students2 = { "Engin", "Derin", "Sahil" };
            students2[0] = "Engin";
            students2[1] = "Derin";
            students2[2] = "Sahil";

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();

        }
    }
}
