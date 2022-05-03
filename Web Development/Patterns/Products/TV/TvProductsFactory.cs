namespace Patterns.Products.TV
{
    class TvProductsFactory : ProductsFactory
    {
        public override IProduct CreateProduct()
        {
            return GiveMe.TV().WithName("LG")
                         .WithModel("NANO8900")
                         .WithSerialNumber(132302139)
                         .Build();
        }
    }
}