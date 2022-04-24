namespace Patterns.Products.Bread
{
    class BreadProduct : Product
    {
        public Patterns.Bread GetBread()
        {
            return GiveMe.Bread().WithName("Just Plain Bread")
                                 .Build();
        }
    }
}