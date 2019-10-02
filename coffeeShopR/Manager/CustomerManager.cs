using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using coffeeShopR.Repository;
using System.Data;
using coffeeShopR.Model;


namespace coffeeShopR.Manager
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();

        public bool Add(Customer customer)
        {
            return _customerRepository.Add(customer);
        }

        public bool IsNameExist(Customer customer)
        {
            return _customerRepository.IsNameExist(customer);
        }

        public bool Delete(Customer customer)
        {
            return _customerRepository.Delete(customer);
        }

        public bool Update(Customer customer)

        {
            return _customerRepository.Update(customer);
        }

        public DataTable Display()
        {
            return _customerRepository.Display();
        }

        public DataTable Search(Customer customer)
        {
            return _customerRepository.Search(customer);
        }
    }
}
