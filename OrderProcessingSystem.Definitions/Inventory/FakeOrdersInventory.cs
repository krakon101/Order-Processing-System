using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSystem.Definitions.Inventory
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
    }
    public static class FakeOrdersInventory
    {
        public static List<Car> Cars { get; set; } = new List<Car>()
        {
            new Car
            {
                Id = 1,
                Name = "Nano",
                Brand = "Tata",
                Color = "Green",
                Quantity = 10,
            },
            new Car
            {
                Id = 2,
                Name = "Creta",
                Brand = "Hyundai",
                Color = "grey",
                Quantity = 10,
            }
        };
    }
}
