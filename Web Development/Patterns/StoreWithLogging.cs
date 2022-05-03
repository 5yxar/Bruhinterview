using Patterns.Logger;
using Patterns.Products;

namespace Patterns;

public class StoreWithLogging : IStore
{
    private readonly DebugLog _logger;
    private readonly IStore _store;

    public StoreWithLogging(IStore store)
    {
        _store = store;
        _logger = new DebugLog();
    }

    public Cart BuySomething(Cart cart, ProductType productType)
    {
        _logger.PrintLog("Before buy something");
        
        var result = _store.BuySomething(cart, productType);
        
        _logger.PrintLog("After buy something");

        return result;
    }
}