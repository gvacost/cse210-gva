
class Address
{
    private string address;
    private string _street;
    private string _city;
    private string _state_province;
    private string _country;
    private bool _usa;

    public Address()
    {
        // _street = "Wallabie";
        // _city = "Sidney";
        // _state_province = "New South Wales";
        // _country = "Australia";
    }
    public Address(string street, string city, string state_province, string country)
    {
        _street = street;
        _city = city;
        _state_province = state_province;
        _country = country;
    }

    public string GetAddress()
    {
        address = $"{_street}, {_city}, {_state_province}, {_country}";
        Console.WriteLine($"Address: {address}");
        return address;
    }
    public void DisplayAddress()
    {
        Console.WriteLine($"{address}");
    }
    public string Country()
    {
        return _country;
    }
  
    public bool LiveUSA()
    {
        bool usa = false;

        if (Country().ToUpper() == "USA")
        {
            usa = true;
            Console.WriteLine("The customer lives in USA");
        }
        else 
        {
            Console.WriteLine("The customer lives out of the USA");
        }
        _usa = usa;
        return _usa;
    }
    public void LiveInUSA(bool usa)
    {
        
        if (Country().ToUpper() == "USA")
        {
            usa = true;
            Console.WriteLine("The customer lives in USA");
        }
        else 
        {
            usa = false;
            Console.WriteLine("The customer lives out of the USA");
        }
        _usa = usa;
    }
}