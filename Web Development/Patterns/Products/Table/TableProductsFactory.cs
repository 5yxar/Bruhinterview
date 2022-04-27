using System.Drawing;

namespace Patterns.Products.Table
{
    class TableProductsFactory : ProductsFactory
    {
        public override IProduct CreateProduct()
        {
            return GiveMe.Table().WithName("Just Plain Bread")
                         .WithSize(new Size(100, 200))
                         .Build();
        }
    }
}