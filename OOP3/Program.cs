﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager,new FileLoggerService());

            List<IKrediManager> kredis = new List<IKrediManager>()
            {
                ihtiyacKrediManager,tasitKrediManager
                
            };

            basvuruManager.KrediOnBilgilendirmesiYap(kredis);

        }
    }
}
