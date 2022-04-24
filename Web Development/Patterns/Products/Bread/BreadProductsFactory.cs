namespace Patterns.Products.Bread
{
    class BreadProductsFactory : ProductsFactory
    {
        public override Product CreateProduct()
        {
            return new BreadProduct();
        }
    }
}