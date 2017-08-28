using System;
using NUnit.Framework;


namespace AcmeTest
{
    [TestFixture]
    class CustomersFixture
    {
        private Customers custs;
        private void ShowCustomerArray(Customer[] arr)
        {
            while (arr !=null)
            {
                int index = 0;
                string id = arr[index].CustomerId.ToString();
                string firstName = arr[index].FirstName;
                string lastName = arr[index].LastName;
                string emailAddress = arr[index].EmailAddress;
                string str = id + firstName + lastName + emailAddress;
                Console.WriteLine(str);
            }
        }
    }
}
