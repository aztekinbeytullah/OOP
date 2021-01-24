using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //BAşvuru bilgilerini içeren bilgiler burdan alınır ve değerlendirilir
            // Ardından kredi hesaplanır
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> kredis)
        {
            foreach (var item in kredis)
            {
                item.Hesapla();
            }
        }
    }
}
