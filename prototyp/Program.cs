using System;
using System.Collections.Generic;

namespace prototyp
{
    public abstract class ProductPrototype
    {
        private decimal price { get; }

        public ProductPrototype(decimal price)
        {
            //
            price = this.price;
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
    //
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
            //
            return (ProductPrototype)this.MemberwiseClone();
        }

    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            //
            Supermarket supermarket = new Supermarket();
            supermarket.AddProduct("Butter", new Butter(5.30m));

            //...
            product = supermarket.GetClonedProduct("Bread");
            Console.WriteLine(String.Format("Bread - {0} zł", product.Price));
            //...

        }
    }
}
