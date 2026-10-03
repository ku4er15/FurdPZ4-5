using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ATM_System
{
    public class ReceptionAndProcessingModule
    {
        // Главное меню и обработка операций
        public void ProcessRequest(CreditCardData cardData)
        {
            Console.WriteLine($"\n--- Обслуживание клиента: {cardData.ClientAttributes} ---");
            Console.WriteLine("1. Выдача наличных");
            Console.WriteLine("2. Распечатка баланса");
            Console.WriteLine("3. Печать чека последней операции");
            Console.Write("Выберите операцию (1-3): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите сумму для снятия: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal amount))
                    {
                        if (amount <= cardData.LimitOfMoney)
                        {
                            cardData.LimitOfMoney -= amount;
                            Console.WriteLine($"[Обработка]: Выдано {amount} руб.");
                            Console.WriteLine($"[Обработка]: Уведомление отправлено в банк. Остаток: {cardData.LimitOfMoney} руб.");
                        }
                        else
                        {
                            Console.WriteLine("[Обработка]: Ошибка! Превышен лимит средств на карте.");
                        }
                    }
                    break;

                case "2":
                    Console.WriteLine($"\n[Обработка]: Чек баланса");
                    Console.WriteLine($"Клиент: {cardData.ClientAttributes}");
                    Console.WriteLine($"Доступный лимит: {cardData.LimitOfMoney} руб.");
                    break;

                case "3":
                    Console.WriteLine("\n[Обработка]: Печать квитанции по последней операции... Выполнено.");
                    break;

                default:
                    Console.WriteLine("[Обработка]: Неверный выбор операции.");
                    break;
            }
        }
    }
}


