
class Customer
{
    private string _cname, _street, _city, _state_province,_country;

    // public Customer()
    // {
    //     // _cname ="Gonzalo Acosta";
    // }
    public Customer(string cname)
    {
        _cname = cname;
    }
    public Customer (string cname, string street_,string city_,string state_province_,string country_)
    {
        _cname = cname;
        _street = street_;
        _city = city_;
        _state_province = state_province_;
        _country = country_;
    }

    public string GetName()
    {   
        Console.WriteLine($"Name:{_cname}");
        return _cname;
    }


    // public void CreateAddressCustomer()
    // {
    //     Console.Write("Where do you live(country)? ");
    //     string country = Console.ReadLine();
    //     Console.Write("What is the street where you live? ");
    //     string street = Console.ReadLine();
    //     Console.Write("How is the name of the city? ");
    //     string city = Console.ReadLine();
    //     Console.Write("In what state or province");
    //     string state_province = Console.ReadLine();

    //     Address address = new Address(street, city, state_province, country);
    //     address.GetAddress(); 
        
    // }

    public void CountryResidence()
    {
        Address country_ = new Address(_street, _city, _state_province,_country);

        if (country_.Country().ToUpper() == "USA")
        {
            country_.LiveInUSA(true);
            Console.WriteLine("The customer lives in USA");
        }
        else 
        {
            Console.WriteLine("The customer lives out of the USA");
        }
    }
}