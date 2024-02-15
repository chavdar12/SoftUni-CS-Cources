﻿namespace Ex003;

public class Person
{
    private readonly string name;
    private readonly List<Product> products;
    private decimal money;

    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;

        products = new List<Product>();
    }

    public string Name
    {
        get => name;
        private init
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Name cannot be empty");
            name = value;
        }
    }

    public decimal Money
    {
        get => money;
        private set
        {
            if (value < 0) throw new ArgumentException("Money cannot be negative");
            money = value;
        }
    }

    public IReadOnlyCollection<Product> Products
        => products;

    public void AddProduct(Product product)
    {
        Money -= product.Cost;
        products.Add(product);
    }
}