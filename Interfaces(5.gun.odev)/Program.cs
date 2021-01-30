using System;

namespace Interfaces_5.gun.odev_
{
    class Program
    {
        static void Main(string[] args)
        {
            //İnterface new'lenemez - çünkü içinde yer aldığı imza veya üye içi boştur
            IPersonManager1 customerManager = new CustomerManager();
            //customerManager.Add();

            IPersonManager1 employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            //projectManager.Add(customerManager);
            //projectManager.Add(employeeManager);
            projectManager.Add(new InternManager());

            Console.ReadLine();
        }
    }


    class PersonManager
    {
        
        public void Add()//burda public yaparız
        {
            //İmplemented operation - implemente edilmiş, içi doldurulmuş operasyon
            Console.WriteLine("Eklendi");
        }
    }



    interface IPersonManager1
    {
        //Unmplemented operation
        void Add();//burda public yapamayız zaten interface default u public dir public yazarsak da hata verir
        void Update();
    }

    //Inheritance - class larda...................Implements - interface lerde
    class CustomerManager : IPersonManager1
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müsteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müsteri güncellendi");
        }
    }

    class EmployeeManager : IPersonManager1
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }

    class InternManager : IPersonManager1 //stajer
    {
        public void Add()
        {
            Console.WriteLine("Stajer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajer güncellendi");
        }
    }


    class ProjectManager
    {
        public void Add(IPersonManager1 personManager)
        {
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add();
            personManager.Add();

        }
    }
}
