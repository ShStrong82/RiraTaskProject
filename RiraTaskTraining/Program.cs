using RiraTaskTraining;





var service = new ProductService();


//products with categories sort
var productsByGroupSort = service.GetProductsByCategorySort();
//products in category 1
List<Product> productsByCategoryId = service.GetProdutsByCategoryId(1);
Product maximumProductPrice = service.GetProductByMaxPrice();
long productsPriceSum = service.GetProductsPriceSum();
double productsPriceAvg = service.GetProductsPriceAvg();






//print products sorted by categories
foreach (var category in productsByGroupSort)
{
    Console.WriteLine($"category: {category.Key}");
    foreach (Product product in category)
    {
        Console.WriteLine($"{product.Name}");
    }
    Console.WriteLine();
}



