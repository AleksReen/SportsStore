using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Domain.Concrete
{
    public class OrderProcessor : IOrderProcessor
    {
        public void ProcessOrder(Cart cart, ShippingDetails shippingDetails)
        {
            //to do: save data to DB;
        }
    }
}
