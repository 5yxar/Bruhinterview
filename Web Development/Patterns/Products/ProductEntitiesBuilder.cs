using Patterns.Products.Bread;
using Patterns.Products.Table;
using Patterns.Products.TV;

namespace Patterns.Products
{
    public class ProductEntitiesBuilder
    {
        public TvBuilder TV()
        {
            return new TvBuilder();
        }

        public TableBuilder Table()
        {
            return new TableBuilder();
        }

        public BreadBuilder Bread()
        {
            return new BreadBuilder();
        }
    }
}