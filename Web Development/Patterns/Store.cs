using Patterns.Logger;
using Patterns.Products;

namespace Patterns
{
    public class Store
    {
        private readonly ProductCreationChooser _strategyChooser;

        public Store(ProductCreationChooser strategyChooser)
        {
            _strategyChooser = strategyChooser;
        }
        
        public Cart BuySomething(Cart cart, ProductType productType)
        {
            var log = "Some log text";
            var logger = new DebugLog();
            logger.PrintLog(log);
            var strategy = _strategyChooser.GetProductCreationFactory(productType);
            cart.Add(strategy.CreateProduct());
            return cart;
        }
    }
}