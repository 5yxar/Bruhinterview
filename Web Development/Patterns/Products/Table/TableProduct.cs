using System.Drawing;

namespace Patterns.Products.Table
{
    public class TableProduct : IProduct
    {
        public string Name { get; set; }
        public Size Size { get; set; }
    }
}