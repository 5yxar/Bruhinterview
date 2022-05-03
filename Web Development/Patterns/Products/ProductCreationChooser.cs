using System;
using Patterns.Products.Bread;
using Patterns.Products.Table;
using Patterns.Products.TV;

namespace Patterns.Products
{
    public class ProductCreationChooser
    {
        public ProductsFactory GetProductCreationFactory(ProductType productType)
        {
            return productType switch
            {
                ProductType.TV => new TvProductsFactory(),
                ProductType.Bread => new BreadProductsFactory(),
                ProductType.Table => new TableProductsFactory(),
                _ => throw new ArgumentOutOfRangeException(nameof(productType), productType, null)
            };
        }
    }
}