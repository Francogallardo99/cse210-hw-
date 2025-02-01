using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal TotalCost()
    {
        decimal totalProductCost = 0;
        foreach (var product in _products)
        {
            totalProductCost += product.TotalCost();
        }
        decimal shippingCost = _customer.LiveInUSA() ? 5 : 35;
        return totalProductCost + shippingCost;
    }
    public string PackingLabel()
    {
        string label ="";
        foreach (var product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label.Trim();
    }
    public string ShippingLabel()
    {
        string customerName = _customer.GetName();
        string customerAddress = _customer.GetAddress().GetFullAddress();
        return $"{customerName} \n {customerAddress}";

    }
}