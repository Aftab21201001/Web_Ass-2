namespace PAKWEAR.Services.ProductService

{
    public interface IProductService
    {
        List<Product> GetAllProduct();
        Product? GetSingleProduct(int id);
        List<Product> AddProduct(Product product);
        List<Product>? UpdateProduct(int id, Product req);
        List<Product>? DeleteProduct(int id);
    }
}