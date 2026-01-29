using System;
using System.Dynamic;

public class Address
{
    private string _street;
    private string _city;
    private string _state;

    private string _country; // os atributos usam _ na frente e os metodos e classes começam com maiusculo e sem tem mais de uma palavra começa maiuscula também 

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }

    
}




