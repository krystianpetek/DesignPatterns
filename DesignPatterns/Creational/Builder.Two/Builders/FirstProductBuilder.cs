using Builder.Two.Contracts;
using Builder.Two.Entities;
using System;

namespace Builder.Two.Builders;

public class FirstProductBuilder : IBuilder
{
    private Product _product;
    public FirstProductBuilder() => Reset();
    public void Reset() => _product = new Product();
    public void BuildA() => _product.Add("Building block A");
    public void BuildB() => _product.Add("Building block B");
    public void BuildC() => _product.Add("Building block C");

    public void GetProduct()
    {
        Console.WriteLine(_product.ListParts());
        Reset();
    }
}
