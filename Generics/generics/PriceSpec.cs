using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.generics
{
    public class Product
    {
        public double Price { get; set; } = 1200.0;
    }

    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T item);
    }

    public class PriceSpec : ISpecification<Product>
    {
        public bool IsSatisfiedBy(Product p) => p.Price < 100;
    }
}