using System.Drawing;

namespace Patterns.Products.Table
{
    class TableProduct : Product
    {
        public Patterns.Table GetTable()
        {
            return GiveMe.Table().WithName("Just Plain Bread")
                                 .WithSize(new Size(100, 200))
                                 .Build();
        }
    }
}