using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ATM_System
{
    public class CreditCardControlModule
    {
        // Ввод и считывание информации с карты
        public CreditCardData ReadCardData()
        {
            Console.WriteLine("\n[Модуль картридера]: Карта вставлена. Считывание данных...");
            System.Threading.Thread.Sleep(800); // Имитация задержки чтения
            Console.WriteLine("[Модуль картридера]: Данные карты успешно считаны в общую память.");

            return new CreditCardData();
        }

        // Извлечение/удаление карты
        public void EjectCard()
        {
            Console.WriteLine("\n[Модуль картридера]: Завершение сеанса. Карта извлечена. Заберите карту.");
        }
    }
}
