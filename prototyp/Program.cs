using System;
using System.Collections.Generic;
using System.Text;

namespace prototyp
{
    public abstract class ProductPrototype
    {
        public decimal Price;

        public ProductPrototype(decimal price)
        {
            Price = price;
        }

        public ProductPrototype Clone()
        {
            return (ProductPrototype)this.MemberwiseClone();
        }
    }

    public class Bread : ProductPrototype
    {
        public Bread(decimal price) : base(price) { }
    }
    public class Butter : ProductPrototype
    {
        public Butter(decimal price) : base(price) { }
    }

    public class Supermarket
    {
        private Dictionary<string, ProductPrototype> _productList = new Dictionary<string, ProductPrototype>();

        public void AddProduct(string key, ProductPrototype productPrototype)
        {
            _productList.Add(key, productPrototype);
        }

        public ProductPrototype GetClonedProduct(string key)
        {
            return _productList[key].Clone();
        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Supermarket supermarket = new Supermarket();
            supermarket.AddProduct("Bread", new Bread(9.50m));
            supermarket.AddProduct("Butter", new Butter(5.30m));

            ProductPrototype product = supermarket.GetClonedProduct("Bread");
            Console.WriteLine(String.Format("Bread - {0:F2} zł > {1:F2} zł", product.Price, (product.Price - (product.Price*0.1m))));
            product = supermarket.GetClonedProduct("Bread");
            Console.WriteLine(String.Format("Bread - {0:F2} zł", product.Price));
            product = supermarket.GetClonedProduct("Butter");
            Console.WriteLine(String.Format("Butter - {0:F2} zł", product.Price));

        }
    }
}
