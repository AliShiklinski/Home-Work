using System;
using System.Collections.Generic;


public class Product
{
    public int Id { get; INIT; }
    public string Name { get; INIT; }
    public decimal CostPrice { get; INIT; } = 1500; 
    public decimal SalePrice { get; INIT; } = 2500; 
}


public class ProductGetDto
{
    public int Id { get; INIT; }
    public string Name { get; INIT; }
    public decimal SalePrice { get; INIT; }
}

public class ProductCreateDto
{
    public string Name { get; INIT; }
    public decimal CostPrice { get; INIT; }
    public decimal SalePrice { get; INIT; }
}
