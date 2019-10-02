using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Data;
using coffeeShopR.Repository;
using coffeeShopR.Model;

namespace coffeeShopR.Manager
{
    public class OrderManager
    {
        OrderRepository _orderRepository = new OrderRepository();

        public bool Add(Order order)
        {
            return _orderRepository.Add(order);
        }

        public bool IsNameExist(Order order)
        {
            return _orderRepository.IsNameExist(order);
        }

        //public bool Delete(Order order)
        //{
        //    return _orderRepository.Delete(order);

        //}

        //public bool Update(Order order)

        //{
        //    return _orderRepository.Update(order);

        //}

        public DataTable Display()
        {
            return _orderRepository.Display();
        }

        //public DataTable Search(Order order)
        //{
        //    return _orderRepository.Search(order);

        //}

        public DataTable ItemCombo()
        {
            return _orderRepository.ItemCombo();

        }

        public DataTable CustomerCombo()
        {

            return _orderRepository.CustomerCombo();

        }

        //public bool IsInameExist(string name)
            //{
            //    return _orderRepository.IsInameExist(name);
            //}
        }

}
