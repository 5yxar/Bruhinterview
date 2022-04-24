namespace Patterns.Products
{
    abstract class ProductBuilder
    {
        public ProductItem ProductItem { get; private set; }

        public void CreateProduct()
        {
            ProductItem = new ProductItem();
        }
    }

    public class ProductItem
    {
    }
}