using System;

class Program
{
    static void Main(string[] args)
    {
       Order order1 = new Order("Product1", "AB12",2,2,"Product3", "CD23", 1.75, 2, "Gonzalo Acosta", 
       "Wallabi 42", "Sidney", "New Wales South", "Australia");
       order1.ListingOrder();
    //    Address nadd = new Address();
    //    Customer cname = new Customer("Gonzalo Acosta");
       order1.ShippingLabel();
       order1.PackingLabel();
       order1.TotalPrice();
       
       Order order2 = new Order("Product1", "AB12",2,2,"Product3", "CD23", 1.75, 2, "Product3", "CD23", 1.75, 2,
       "Valentin Acosta", "Wallabi 42", "Sidney", "New Wales South", "usa");
       order2.ListingOrder();
    //    Address nadd1 = new Address("Wallabi 42", "Sidney", "New Wales South", "usa");
    //    Customer cname1 = new Customer("Valentin Acosta");
       order2.ShippingLabel();
       order2.PackingLabel();
       order2.TotalPrice();

       


    }
}

        // " Product1; ID: AB12; Price: $2",
        // " Product2; ID: AB13; Price: $2.5",
        // " Product3; ID: CD23; Price: $1.75",
        // " Product4; ID: CD24; Price: $4.5",
        // " Product5; ID: AC34; Price: $3.25",
        // " Product6; ID: AC35; Price: $1.15"