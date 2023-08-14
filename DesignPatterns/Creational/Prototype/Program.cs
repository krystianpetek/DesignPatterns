using Prototype.Contracts;
using Prototype.Products;
using Prototype.Register;

namespace Prototype;

public static class Program
{
    public static void Main()
    {
        SupermarketRegister supermarket = new SupermarketRegister();
        supermarket.AddProduct("Bread", new Bread(9.50m));
        supermarket.AddProduct("Butter", new Butter(5.30m));

        ProductPrototype product = supermarket.GetClonedProduct("Bread");
        product.GetProductInfo();
        
        product = supermarket.GetClonedProduct("Bread");
        product.GetProductInfo();
        
        product = supermarket.GetClonedProduct("Butter");
        product.GetProductInfo();
    }
}