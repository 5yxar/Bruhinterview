namespace Patterns.Products.TV
{
    class TvProductsFactory : ProductsFactory
    {
        public override Product CreateProduct()
        {
            return new TvProduct();
        }
    }
}