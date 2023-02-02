using Lab1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Product p = new Product("Railgun");
Order o = new Order(p);

PackingRobot packingRobot = new PackingRobot("Terminator");
DispatchRobot dispatchRobot = new DispatchRobot("Big O");
DeliveryRobot deliveryRobot = new DeliveryRobot("Wall-e");

packingRobot.ProccessOrder(o);

var robotList = new List<WarehouseRobot>
{
    packingRobot,
    dispatchRobot,
    deliveryRobot
};

var orderList = new List<Order>();

foreach (var item in robotList)
{
    item.ProccessOrder(o);
}

while (true)
{
    Console.WriteLine("Welcome to the warehouse management system. Choose one of the following:");
    Console.WriteLine("1. Add a new order");
    Console.WriteLine("2. Display status of all orders");
    Console.WriteLine("3. Proccess the last order by each robot");
    Console.WriteLine("4. Exit the program");
    var key = Console.ReadLine();

    switch (key)
    {
        case "1":
            Console.WriteLine("Type the name of the product to be ordered: ");
            var input = Console.ReadLine();
            var product = new Product(input);
            var order = new Order(product);
            orderList.Add(order);
            break;

        case "2":
            foreach (var item in orderList)
            {
                Console.WriteLine($"{item.OrderedProduct.Name} status: {item.State}");
            }
            break;

        case "3":
            var lastOrder = orderList.Last();

            foreach (var robot in robotList)
            {
                robot.ProccessOrder(lastOrder);
            }
            break;

        case "4":
            return;

        default:
            break;
    }
}