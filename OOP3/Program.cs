using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankCreditManager carCreditManager = new CarCreditManager();
            IBankCreditManager houseCreditManager = new HouseCreditManager();
            IBankCreditManager personelFinanceCreditManager = new PersonalFinanceCreditManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { databaseLoggerService,fileLoggerService,smsLoggerService};

            CreditApplicationManager creditApplicationManager = new CreditApplicationManager();

            creditApplicationManager.CreditApplication(personelFinanceCreditManager,loggers);

            List<IBankCreditManager> bankCreditManagers = new List<IBankCreditManager>() { personelFinanceCreditManager, carCreditManager, houseCreditManager };
            //creditApplicationManager.GetCreditInformation(bankCreditManagers);


        }
    }
}
