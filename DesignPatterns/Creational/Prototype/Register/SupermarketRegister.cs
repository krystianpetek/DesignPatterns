using System.Collections.Generic;
using Prototype.Contracts;
using Prototype.Products;

namespace Prototype.Register;

public class SupermarketRegister
{
    private readonly Dictionary<string, ProductPrototype> _productList = new Dictionary<string, ProductPrototype>();
    private bool _anotherBread = false;

    public void AddProduct(string key, ProductPrototype productPrototype)
    {
        _productList.Add(key, productPrototype);
    }

    public ProductPrototype GetClonedProduct(string key)
    {
        var product = _productList[key].Clone();
        if (product is Bread)
        {
            if (!_anotherBread)
            {
                _anotherBread = true;
                product.Price -= product.Price * 0.1m;
            }
            return product;
        }
        return product;
    }
}
