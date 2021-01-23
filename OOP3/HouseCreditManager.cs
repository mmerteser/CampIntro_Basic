using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HouseCreditManager : IBankCreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi hesaplandı");
        }

        public void ListPaymentPlan()
        {
            throw new NotImplementedException();
        }
    }
}
