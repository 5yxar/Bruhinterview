using System.Drawing;

namespace Patterns.Products.Table
{
    public class TableBuilder
    {
        private string name;
        private Size size;

        public TableBuilder WithName(string name)
        {
            this.name = name;
            return this;
        }
        
        public TableBuilder WithSize(Size size)
        {
            this.size = size;
            return this;
        }

        public TableProduct Build()
        {
            return new TableProduct()
            {
                Name =name,
                Size = size
            };
        }
    }
}