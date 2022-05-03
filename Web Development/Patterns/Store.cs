using Patterns.Products;

namespace Patterns
{
    public class Store : IStore
    {
        private readonly ProductCreationChooser _strategyChooser;

        public Store(ProductCreationChooser strategyChooser)
        {
            _strategyChooser = strategyChooser;
        }
        
        public Cart BuySomething(Cart cart, ProductType productType)
        {
            var strategy = _strategyChooser.GetProductCreationFactory(productType);
            cart.Add(strategy.CreateProduct());
            
            return cart;
        }
    }
}