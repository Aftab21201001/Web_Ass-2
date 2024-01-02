namespace PAKWEAR.Services.ProductService
namespace PAKWEAR.Services.ProductService
{
    public class ProductService : IProductServices
    {
        private static List<Product> product = new List<Product> {

            new Product {
                    Id = 1,
                    Name = "pc",
                    Price = 666,

                        },


            new Product {
                    Id = 1,
                    Name = "mouse",
                    Price = 888,

                        }
            };


        public List<Product> AddProduct(Product product)
        {
            product.Add(product);
            return product;
        }

        public List<Product>? DeleteProduct(int id)
        {
            var prdct = product.Find(x => x.Id == id);
            if (prdct == null)
            {
                return null;
            }
            product.Remove(prdct);
            return product;

        }

        public List<Product> GetAllProduct()
        {
            return product;
        }

        public Product? GetSingleProduct(int id)
        {
            var result = product.Find(x => x.Id == id);
            if (result == null)
                return null;

            return result;
        }

        public List<Product>? UpdateProduct(int id, Product req)
        {
            var prdct = product.Find(x => x.Id == id);
            if (prdct == null)
            {
                return null;
            }

            return product;
        }
    }
}