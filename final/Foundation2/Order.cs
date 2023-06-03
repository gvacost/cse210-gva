using System;

class Order
{
    private string name, name1, name3, customer;
    private string id, id1, id3, street_, city_, state_province_, country_;
    private double price, price1, price3;
    private int quant, quant1, quant3; 
    List<string> order = new List<string>();
    List<double> prices = new List<double>();
    List<string> products = new List<string>()
    {
        " Product1; ID: AB12; Price: $2",
        " Product2; ID: AB13; Price: $2.5",
        " Product3; ID: CD23; Price: $1.75",
        " Product4; ID: CD24; Price: $4.5",
        " Product5; ID: AC34; Price: $3.25",
        " Product6; ID: AC35; Price: $1.15"
    };

    public Order()
    {

    }
    public Order(string prod1, string id_, double price_, int quanti, string prod2, string _id_, double _price_, int _quanti,
    string customer_, string street, string city, string state_province, string country)
    {
        name = prod1;
        id = id_;
        price = price_;
        quant = quanti;
        name1 = prod2;
        id1 = _id_;
        price1 = _price_;
        quant1 = _quanti;
        street_ = street;
        city_ = city;
        state_province_ = state_province;
        country_ = country;
        customer = customer_;
    }
    public Order(string prod1, string id_, double price_, int quanti, string prod2, string _id_, double _price_, int _quanti,
                 string prod3, string _id2, double _price2, int _quanti3,string customer2, string street, string city, string state_province, string country)
    {
        name3 = prod3;
        id3 = _id2;
        price3 = _price2;
        quant3 = _quanti3;
        name1 = prod2;
        id1 = _id_;
        price1 = _price_;
        quant1 = _quanti;
        name = prod1;
        id = id_;
        price = price_;
        quant = quanti;
        street_ = street;
        city_ = city;
        state_province_ = state_province;
        country_ = country;
        customer = customer2;
    }
    public void ListingOrder()
    {
        
    //     Console.Write("What product do you want? ");
    //     string name = (Console.ReadLine());
    //     Console.Write("What is the ID? ");                              
    //     string id = Console.ReadLine();                                
    //     Console.Write("What is the price");                             
    //     double price = double.Parse(Console.ReadLine());                                                                                
    //     Console.Write("How many do you want? ");
    //     int quant = int.Parse(Console.ReadLine());     
        // string name = "Product1";
        // string id = "AB12";
        // double price = 2;
        // int quant = 2;                 
        Product product = new Product(name, id, price, quant); 
        // string name1 ="Product3";
        // string id1 = "CD23";
        // double price1 = 1.75;
        // int quant1 = 2;
        Product produc1 = new Product(name1, id1, price1, quant1);
        Product produc2 = new Product(name3, id3, price3, quant3);
        // Product product = new Product();
        prices.Add(product.OrderPrice());
        prices.Add(produc1.OrderPrice());
        prices.Add(produc2.OrderPrice());
        order.Add(product.GetOrder());
        order.Add(produc1.GetOrder());
        order.Add(produc2.GetOrder());

        
    }      
    public int ShippingCost()                                          
    {
        int shipping;
        Address shipp = new Address(street_, city_, state_province_,country_);
        if(shipp.LiveUSA() == true)
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        return shipping;
    }


    public void PackingLabel()
    {
      
        foreach(string prod in order)
        {
            Console.WriteLine(prod);
        }
    }
    public void ShippingLabel()
    {
        Customer name = new Customer(customer);
        Address nadd = new Address(street_, city_, state_province_,country_);
        name.GetName();
        nadd.GetAddress();
    }
    public void TotalPrice()
    {
        double _totalprice = 0;
        foreach (double price in prices)
        {
            _totalprice += price;
        }
        
        Console.WriteLine($"{_totalprice + ShippingCost()}");

        
    }

                                                                        // switch (prod)
                                                                        //     {
                                                                        //         case 1:
                                                                        //             name = "Product1";
                                                                        //             id = "AB12";
                                                                        //             price = 2;
                                                                        //         break;
                                                                        //         case 2:
                                                                        //             name = "Product2";
                                                                        //             id = "AB13";
                                                                        //             price = 2.5;
                                                                        //         break;
                                                                        //         case 3:
                                                                        //             name = "Product3";
                                                                        //             id = "CD23";
                                                                        //             price = 1.75;
                                                                        //         break;
                                                                        //         case 4:
                                                                        //             name = "Product4";
                                                                        //             id = "CD24";
                                                                        //             price = 4.5;
                                                                        //         break;
                                                                        //         case 5:
                                                                        //             name = "Product5";
                                                                        //             id = "AC34";
                                                                        //             price = 3.25;
                                                                        //         break;
                                                                        //         case 6:
                                                                        //             name = "Product6";
                                                                        //             id = "AC35";
                                                                        //             price = 1.15;
                                                                        //         break;
                                                                                
                                                                        //     }
        

    

    
}