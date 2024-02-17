using System;
using System.Linq.Expressions;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n");

        Product prod1 = new Product();
        Product prod2 = new Product();
        Product prod3 = new Product();
        Product prod4 = new Product();
        Product prod5 = new Product();

        prod1.SetProductId("H77A2");
        prod1.SetName("Countertop Mixer");
        prod1.SetPrice(209.99);
        prod1.SetQuantity(1);
        prod1.MakeProduct(prod1.GetProductId(), prod1.GetName(), prod1.GetPrice(), prod1.GetQuantity());

        prod2.SetProductId("N65Y9");
        prod2.SetName("Hair Dryer");
        prod2.SetPrice(65.99);
        prod2.SetQuantity(2);
        prod2.MakeProduct(prod2.GetProductId(), prod2.GetName(), prod2.GetPrice(), prod2.GetQuantity());

        prod3.SetProductId("L55M5");
        prod3.SetName("Ice Cream Maker");
        prod3.SetPrice(45.99);
        prod3.SetQuantity(1);
        prod3.MakeProduct(prod3.GetProductId(), prod3.GetName(), prod3.GetPrice(), prod3.GetQuantity());

        prod4.SetProductId("T24J8");
        prod4.SetName("Cermaic Bowl");
        prod4.SetPrice(8.99);
        prod4.SetQuantity(5);
        prod4.MakeProduct(prod4.GetProductId(), prod4.GetName(), prod4.GetPrice(), prod4.GetQuantity());

        prod5.SetProductId("K41B4");
        prod5.SetName("Bouncy Ball 5 Pack");
        prod5.SetPrice(2.99);
        prod5.SetQuantity(16);
        prod5.MakeProduct(prod5.GetProductId(), prod5.GetName(), prod5.GetPrice(), prod5.GetQuantity());


        Address add1 = new Address();
        Address add2 = new Address();

        add1.SetStreetAddress("99 W 1350 S");
        add1.SetCity("Boston");
        add1.SetState("MA");
        add1.SetCountry("USA");
        add1.SetZipCode("02108");
        add1.SetAddress(add1.GetStreetAddress(), add1.GetCity(), add1.GetState(), add1.GetCountry(), add1.GetZipCode());
        

        add2.SetStreetAddress("16 Spider Ave");
        add2.SetCity("Sydney");
        add2.SetState("New South Wales");
        add2.SetCountry("Australia");
        add2.SetZipCode("2000");
        add2.SetAddress(add2.GetStreetAddress(), add2.GetCity(), add2.GetState(), add2.GetCountry(), add2.GetZipCode());

        
        

        Customer cust1 = new Customer();
        Customer cust2 = new Customer();

        cust1.SetName("James Edward");
        cust1.SetAddress(add1.GetAddress());
        cust2.SetName("Ruby Sorenson");
        cust2.SetAddress(add2.GetAddress());

        cust1.SetShippingLabel(cust1.GetName(), cust1.GetAddress());
        cust2.SetShippingLabel(cust2.GetName(), cust2.GetAddress());

        
        Order order1 = new Order();
        Order order2 = new Order();

        order1.SetCustomer(cust1.GetName());
        order2.SetCustomer(cust2.GetName());

        order1.AddToOrder(prod1.GetProduct());
        order1.AddToOrder(prod2.GetProduct());
        order1.AddToOrder(prod3.GetProduct());
        order2.AddToOrder(prod4.GetProduct());
        order2.AddToOrder(prod5.GetProduct());

        order1.SetShippingLabel(cust1.GetShippingLabel());
        order2.SetShippingLabel(cust2.GetShippingLabel());


        int add1IsUs = add1.IsUSA(add1.GetCountry());
        int add2IsUs = add2.IsUSA(add2.GetCountry());
        string cust1IsUs = cust1.IsUSA(add1IsUs);
        string cust2IsUs = cust2.IsUSA(add2IsUs);

        


        string order2ShippingLabel = order2.GetShippingLabel();
        double order2ShippingPrice = order2.GetShippingPrice(cust2IsUs);
        double order2Price = order2.GetOrderPrice(order2ShippingPrice, order2.GetOrderList());
        
        string order1ShippingLabel = order1.GetShippingLabel();
        double order1ShippingPrice = order1.GetShippingPrice(cust1IsUs);
        double order1Price = order1.GetOrderPrice(order1ShippingPrice, order1.GetOrderList());


        Console.WriteLine("--------------------------------------");

        Console.WriteLine(order1ShippingLabel);
        Console.WriteLine("");
        order1.PrintPackingLabel(order1.GetOrderList());
        Console.WriteLine($"Total Price: {order1Price}");
        Console.WriteLine("");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("");
        Console.WriteLine(order2ShippingLabel);
        Console.WriteLine("");
        order2.PrintPackingLabel(order2.GetOrderList());
        Console.WriteLine($"Total Price: {order2Price}");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("");



    }
}