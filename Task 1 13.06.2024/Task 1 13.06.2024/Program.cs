public class Program
{
    public static void Main()
    {
        ProductService productService = new ProductService();

        Product newProduct = new Product { Id = 1, Name = "Product1", CostPrice = 100, SalePrice = 150 };
        productService.Create(newProduct);

        Product product = productService.Get(1);
        Console.WriteLine($"Retrieved Product: {product.Name}, {product.CostPrice}, {product.SalePrice}");

        List<Product> products = productService.GetAll();
        foreach (var p in products)
        {
            Console.WriteLine($"Product: {p.Id}, {p.Name}, {p.CostPrice}, {p.SalePrice}");
        }

        productService.Delete(1);
    }
}