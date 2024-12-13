
using System.Collections.Generic;

namespace RiraTaskTraining;

public class ProductService : AbstractProductService
{
    private readonly List<Product> _products;

    //initialize SeedData of our products with Constructor(ctor)
    public ProductService()
    {
        _products = new List<Product>()
        {
            new Product() { Id = 1, Name = "Product A", Category = Categories.Category1, Price = 100 },
            new Product() { Id = 2, Name = "Product B", Category = Categories.Category1, Price = 150 },
            new Product() { Id = 3, Name = "Product C", Category = Categories.Category2, Price = 120 },
            new Product() { Id = 4, Name = "Product D", Category = Categories.Category3, Price = 200 },
            new Product() { Id = 5, Name = "Product E", Category = Categories.Category1, Price = 80 },
        };
    }


    public override List<Product> GetProdutsByCategoryId(int categoryId)
    {
        //check the input parameter with the index of our category enum
        List<Product> productsByCategoryId = _products.Where(p => (int)p.Category+1 == categoryId).ToList();
        return productsByCategoryId;
    }
    public override Product GetProductByMaxPrice()
    {
        Product product = _products.MaxBy(p => p.Price);
        return product;
    }

    public override long GetProductsPriceSum()
    {
        long sum = _products.Sum(p => p.Price);
        return sum;
    }

    public override List<IGrouping<Categories, Product>> GetProductsByCategorySort()
    {
        //make a group of products by their category and order that with the newGroup(products),
        //actually we have a list of categories that contain each one of them a list of products
        var productsByCategory = _products.GroupBy(p => p.Category).OrderBy(newGroup => newGroup.Key).ToList();
        return productsByCategory;
    }

    public override double GetProductsPriceAvg()
    {
        double avg = _products.Average(p => p.Price);
        return avg;
    }
}
