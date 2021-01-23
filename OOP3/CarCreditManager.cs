using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class CarCreditManager : IBankCreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Araç kredisi hesaplandı");
        }

        public void ListPaymentPlan()
        {
            throw new NotImplementedException();
        }
    }
}
