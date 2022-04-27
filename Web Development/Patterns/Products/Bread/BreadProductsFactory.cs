namespace Patterns.Products.Bread
{
    class BreadProductsFactory : ProductsFactory
    {
        public override IProduct CreateProduct()
        {
            return GiveMe.Bread()
                         .WithName("Just Plain Bread")
                         .Build();
        }
    }
}