namespace Patterns.Products.TV
{
    class TvProduct : Product
    {
        public Patterns.TV GetTv()
        {
            return GiveMe.TV().WithName("LG")
                              .WithModel("NANO8900")
                              .WithSerialNumber(132302139)
                              .Build();
        }
    }
}