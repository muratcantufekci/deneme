﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();            
            IKrediManager tasitKrediManager = new TasitKrediManager();            
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerServise = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ıhtiyacKrediManager,tasitKrediManager};
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
            Console.ReadKey();
        }
    }
}
