using System;   


namespace ATM_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Подсистема обслуживания по кредитной карте в банкомате";

            // Инициализация модулей
            // Инициализация модулей
            var cardControl = new CreditCardControlModule();
            var authModule = new AuthenticationModule();
            var processingModule = new ReceptionAndProcessingModule();

            Console.WriteLine("=== БАНКОМАТ ГОТОВ К РАБОТЕ ===");
            Console.WriteLine("Нажмите Enter, чтобы вставить карту...");
            Console.ReadLine();

            Console.WriteLine("Добро пожаловать в банкомат!");

            // 1. Обращение к модулю считывания карты
            CreditCardData sharedMemory = cardControl.ReadCardData();

            // 2. Вызов модуля аутентификации
            bool autentificationFlag = authModule.Authenticate(sharedMemory.Parol);

            // 3. В зависимости от результата аутентификации
            if (autentificationFlag)
            {
                // Если успешно — передаем данные карты в модуль обработки запроса
                processingModule.ProcessRequest(sharedMemory);
            }

            // 4. После завершения (или при ошибке ПИН) вызываем модуль удаления карты
            cardControl.EjectCard();

            Console.WriteLine("\n=== Сеанс завершен ===");
            Console.ReadKey();
        }
    }
}
