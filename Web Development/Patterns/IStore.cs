using Patterns.Products;

namespace Patterns;

public interface IStore
{
    Cart BuySomething(Cart cart, ProductType productType);
}