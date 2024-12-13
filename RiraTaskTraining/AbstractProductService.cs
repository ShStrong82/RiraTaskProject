namespace RiraTaskTraining;

public abstract class AbstractProductService
{
    //CategoryProducts
    public abstract List<Product> GetProdutsByCategoryId(int categoryId);
    //MaxPriceProduct
    public abstract Product GetProductByMaxPrice();
    //ProductsPriceSum
    public abstract long GetProductsPriceSum();
    //CategoryProductsSort
    public abstract List<IGrouping<Categories, Product>> GetProductsByCategorySort();
    //ProductsPriceAvg
    public abstract double GetProductsPriceAvg();
}
