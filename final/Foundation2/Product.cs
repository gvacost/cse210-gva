using System.Collections.Generic;
class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quant;
    private double _orderprice;
    private string product;
    
    List<double> prices = new List<double>();


    public Product()
    {

    }
    public Product(string name, string id, double price, int quant)
    {
        _name = name;
        _id = id;
        _price = price;
        _quant = quant;
    }
    public string GetOrder()
    {
        product = $"{_name}; ID:{_id}";
        return product;
    }
    
    public void Price()
    {
        
        double prodprice = double.Parse($"{_price*_quant}");
        
        prices.Add(prodprice);

        
    }
    public double OrderPrice()
    {
        _orderprice = _price*_quant;
        return _orderprice; 
    }
}