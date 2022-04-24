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
        
        public Patterns.Bread Build()
        {
            return new Patterns.Bread()
            {
                Name =name,
            };
        }
    }
}