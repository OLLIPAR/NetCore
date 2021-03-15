using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AddDbContent addDbContent;
        private readonly ShopCart shopCart;

        public OrdersRepository(AddDbContent addDbContent, ShopCart shopCart)
        {
            this.addDbContent = addDbContent;
            this.shopCart = shopCart;
        }
        public void createOrder(Order order)
        {
            order.ordertime = DateTime.Now;
            addDbContent.Order.Add(order);
            addDbContent.SaveChanges();
            var items = shopCart.listshopitems;
            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {

                    carId = el.car.id,
                    price = el.car.price,
                    orderId = order.id

                };
                addDbContent.OrderDetail.Add(orderDetail);
            }
            addDbContent.SaveChanges();
        }
    }
}
