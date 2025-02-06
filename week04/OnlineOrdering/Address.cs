    using System;
    using System.Collections.Generic;

public class Address
{
    private string _street;
    private string _stateProvince;
    private string _city;
    private string _country;

    public Address(string street , string stateProvince , string city , string  counry)
    {
        _street = street;
        _stateProvince = stateProvince;
        _city = city;
        _country = counry;
    }
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }
    public string GetFullAddress()
    {
        return $"{_street} \n {_city} {_stateProvince}\n {_country}";
    }
}