using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer individualCustomer = new IndividualCustomer();
            individualCustomer.Id = 1;
            individualCustomer.CustomerCode = "I001";
            individualCustomer.FirstName = "Mert";
            individualCustomer.LastName = "ESER";
            individualCustomer.IdentityNum = "11111111111";

            CoorporateCustomer coorporateCustomer = new CoorporateCustomer();
            coorporateCustomer.Id = 1;
            coorporateCustomer.CustomerCode = "C001";
            coorporateCustomer.CorporationName = "FLX Yazılım";
            coorporateCustomer.TaxNumber = "2222222222";

            Customer customer1 = new CoorporateCustomer();
            Customer customer2 = new IndividualCustomer();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);

            

        }
    }
}
