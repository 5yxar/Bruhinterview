namespace Patterns.Products.TV
{
    public class TvBuilder
    {
        private string name;
        private string model;
        private int serialNumber;
        
        public TvBuilder WithName(string name)
        {
            this.name = name;
            return this;
        }
        
        public TvBuilder WithModel(string model)
        {
            this.model = model;
            return this;
        }
        
        public TvBuilder WithSerialNumber(int serialNumber)
        {
            this.serialNumber = serialNumber;
            return this;
        }
        
        public TvProduct Build()
        {
            return new TvProduct()
            {
                Name =name,
                Model = model,
                SerialNumber = serialNumber
            };
        }
    }
}