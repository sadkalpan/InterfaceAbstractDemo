using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        MernisServiceAdapter _customerCheckManager = new MernisServiceAdapter();

        //public StarbucksCustomerManager(CustomerCheckManager customerCheckManager)
        //{
        //    _customerCheckManager = customerCheckManager;
        //}

        public override void Save(Customer customer)
        {
            if (_customerCheckManager.result)
            {
            base.Save(customer);
            }
            else
            {
            throw new Exception("Not a valid person");
            }
        }
    }
}
