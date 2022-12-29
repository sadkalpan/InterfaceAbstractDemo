using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager();
            customerManager.Save(new Entities.Customer { DateOfBirth = new DateTime(1985,1,6), FirstName="Engin", LastName="Demiroğ", NationalityId= "28861499108" });
        }
    }
}
