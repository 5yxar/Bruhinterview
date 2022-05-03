namespace Patterns.Products.Bread
{
    public class BreadBuilder
    {
        private string name;

        public BreadBuilder WithName(string name)
        {
            this.name = name;
            return this;
        }
        
        public BreadProduct Build()
        {
            return new BreadProduct()
            {
                Name =name,
            };
        }
    }
}