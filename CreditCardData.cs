using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_System
{
    // Данные кредитной карты, хранящиеся в общей памяти
    public class CreditCardData
    {
        public string Parol { get; set; } = "2223"; // Заранее заданный PIN-код
        public string ClientAttributes { get; set; } = "Иван Иванов, Карта: *4589";
        public decimal LimitOfMoney { get; set; } = 15000.00m; // Доступный лимит
    }
}
