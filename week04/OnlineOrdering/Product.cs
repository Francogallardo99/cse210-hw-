using System;
using System.Collections.Generic;

public class Product
{
    private string _name;
    private int _poductId;
    private decimal _price;
    private int _quantity;
    
    

    public Product(string name , int poductId , decimal price , int quantity)
    {
        _name = name;
        _poductId = poductId;
        _price = price;
        _quantity = quantity;
    }

    public decimal TotalCost()
    {
        return _price * _quantity;
    }

    public int GetProductId()
    {
        return _poductId;
    }
    public string GetName()
    {
        return _name;
    }
}