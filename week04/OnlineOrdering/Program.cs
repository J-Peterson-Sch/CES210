using System;

class Program
{
    
    static void Main(string[] args)
    {
        Order johnsOrder = new Order(new Customer("John Timbrook", new Address("123 A street", "New York", "New York", "USA")));
        johnsOrder.addProduct(new Product("Dove",1234,12.83,1));
        johnsOrder.addProduct(new Product("Banana",6666,10,45));
        johnsOrder.addProduct(new Product("Protin Bar",9909,3.50,10));
        johnsOrder.addProduct(new Product("Gold Krugerrand",989988,15000,8));
        
        Console.Clear();
        Console.WriteLine($"{johnsOrder.printPackingLabel()}");
        Console.WriteLine($"{johnsOrder.orderTotal():C2}");
        Console.WriteLine("");
        Console.WriteLine($"{johnsOrder.printShippingLabel()}");
        
        Console.WriteLine("");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("");

        Order jennysOrder = new Order(new Customer("Jenny Popstine", new Address("234 D street", "Westhaven", "Eastland", "Austira")));
        jennysOrder.addProduct(new Product("Cow",1212320990,1289.34,1));
        jennysOrder.addProduct(new Product("Dirt",00389,13.99,5));
        jennysOrder.addProduct(new Product("Cow Food",933489988,500,2));

        Console.WriteLine($"{jennysOrder.printPackingLabel()}");
        Console.WriteLine($"{jennysOrder.orderTotal():C2}");
        Console.WriteLine("");
        Console.WriteLine($"{jennysOrder.printShippingLabel()}");
        
        Console.WriteLine("");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("");
    }
}