using System;

public class Customer
{
    private string _name;
    private Address _address; // usa assim pois quem sabe o endeeçp é a classe Address que fica no outro arquivo

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public string GetFullAddress()
    {
        return _address.GetFullAddress();
    }

     public bool LivesInUsa()
    {
        return _address.IsUSA();
    }

}