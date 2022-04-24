namespace Patterns.Products.Table
{
    class TableProductsFactory : ProductsFactory
    {
        public override Product CreateProduct()
        {
            return new TableProduct();
        }
    }
}