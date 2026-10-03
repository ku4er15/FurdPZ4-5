using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

using System;

namespace ATM_System
{
    public class AuthenticationModule
    {
        // Проверка пароля и возврат флага аутентификации
        public bool Authenticate(string correctPin)
        {
            Console.WriteLine("\n[Модуль аутентификации]: Введите ПИН-код (по умолчанию: 1234): ");
            Console.Write("> ");
            string inputPin = Console.ReadLine();

            if (inputPin == correctPin)
            {
                Console.WriteLine("[Модуль аутентификации]: Успешно! ПИН-код верный.");
                return true; // Autentification flag = true
            }
            else
            {
                Console.WriteLine("[Модуль аутентификации]: Ошибка! Неверный ПИН-код.");
                return false; // Autentification flag = false
            }
        }
    }
}