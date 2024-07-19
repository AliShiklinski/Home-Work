using System.Xml;

public class ProductService
{
    private const string FilePath = "example.txt";

    public void Create(Product product)
    {
        var products = GetAll();
        products.Add(product);
        File.WriteAllText(FilePath, JsonConvert.SerializeObject(products, Formatting.Indented));
    }

    public Product Get(int id)
    {
        var products = GetAll();
        return products.Find(p => p.Id == id);
    }

    public List<Product> GetAll()
    {
        if (!File.Exists(FilePath))
        {
            return new List<Product>();
        }

        var json = File.ReadAllText(FilePath);
        return JsonConvert.DeserializeObject<List<Product>>(json);
    }

    public void Delete(int id)
    {
        var products = GetAll();
        var productToRemove = products.Find(p => p.Id == id);
        if (productToRemove != null)
        {
            products.Remove(productToRemove);
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(products, Formatting.Indented));
        }
    }
}
