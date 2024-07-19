using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal CostPrice { get; set; }
    public decimal SalePrice { get; set; }
}