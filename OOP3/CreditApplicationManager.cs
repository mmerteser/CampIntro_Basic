using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class CreditApplicationManager
    {
        //Method injection
        public void CreditApplication(IBankCreditManager bankCreditManager,List<ILoggerService> loggerServices)
        {
            bankCreditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void GetCreditInformation(List<IBankCreditManager> bankCreditManager)
        {
            foreach (var item in bankCreditManager)
            {
                item.Calculate();
            }
        }
    }
}
