namespace Patterns.Products
{
    public abstract class ProductsFactory
    {
        public ProductEntitiesBuilder GiveMe = new ProductEntitiesBuilder();
        public abstract IProduct CreateProduct();
    }
}