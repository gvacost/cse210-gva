class Address
{
    private string _street;
    private string _city;
    private string _country;
    private string _address;
    public Address()
    {
    }
    // public Address(string event_title, string description, string date, string time, string speaker_fullname, int capacity) : base (event_title, description, date, time)
    // {
    // }   
    public Address(string street, string city, string country)
    {
        _street = street;
        _city = city;
        _country = country;
    }
    public void GetAddress()
    {
        _address = $"{_street}, {_city}, {_country}";
        Console.WriteLine($"Where? In {_address}\n");
    }
    // public override void FullDetail()
    // {
        
    // }
}