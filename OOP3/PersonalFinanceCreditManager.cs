using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceCreditManager : IBankCreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi hesaplandı");
        }

        public void ListPaymentPlan()
        {
            throw new NotImplementedException();
        }
    }
}
