using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();*/

            //alt ve üst satır aynı 
            //yani interfaceler de referans alır

            /*IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();*/


            //interface tüm nesnelerde aynı operasyon adları olacaq ama 
            //o operasyonlarda farklı kodlar da olabilir



            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            //ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };//***

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);
            //basvuruManager.BasvuruYap(tasitKrediManager);

            //basvuruManager.BasvuruYap(tasitKrediManager,new FileLoggerService());//böyle de olur
            //basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);//böyle de
            //basvuruManager.BasvuruYap(new EsnafKredisiManager(),new SmsLoggerService());//list yapmazdan önce

            //basvuruManager.BasvuruYap(new EsnafKredisiManager(),new List<ILoggerService>{new DatabaseLoggerService(),new SmsLoggerService() });
            //üstdeki satırı varmek yerine *** olan satırı yazıp aşağıdakı satırı yazabilirdik.
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);

            //List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };

           // basvuruManager.KrediOnBİlgilendirmesiYap(krediler);


            Console.ReadLine();
        }
    }
}
