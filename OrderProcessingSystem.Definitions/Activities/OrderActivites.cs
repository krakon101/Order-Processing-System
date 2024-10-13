using OrderProcessingSystem.Definitions.Inventory;
using OrderProcessingSystem.Definitions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temporalio.Activities;

namespace OrderProcessingSystem.Definitions.Activities
{
    public static class OrderActivites
    {
        [Activity]
        public static bool ValidateOrder(Order order)
        {
            var car = FakeOrdersInventory.Cars.Where(x => x.Id == order.CarId).FirstOrDefault();
            if(car is not null && car.Quantity >= order.Quantity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [Activity]
        public static void PlaceOrder(Order order)
        {
            FakeOrdersInventory.Cars.Where(x => x.Id == order.CarId).FirstOrDefault().Quantity -= order.Quantity;
            Console.WriteLine("Order Placed.");
        }

        [Activity]
        public static void InformSeller(Order order)
        {
            Console.WriteLine($"Informing Seller to send this Order. OrderID = {order.CarId} & Order Quantity = {order.Quantity}");
        }

        [Activity]
        public static void ShipOrder(Order order)
        {
            Console.WriteLine("Order Shipped Successfully");
        }

        [Activity]
        public static void OrderFailure(Order order)
        {
            FakeOrdersInventory.Cars.Where(x => x.Id == order.CarId).FirstOrDefault().Quantity += order.Quantity;
            Console.WriteLine("Order Processing Failed");
        }
    }
}
