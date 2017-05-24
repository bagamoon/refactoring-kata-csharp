using System.Collections.Generic;

namespace RefactoringKata
{
    public class Order
    {
        private readonly int id;
        private readonly List<Product> _products = new List<Product>();

        public Order(int id)
        {
            this.id = id;
        }

        public int OrderId
        {
            get { return id; }
        }

        public int ProductsCount
        {
            get { return _products.Count; }
        }

        public Product GetProduct(int j)
        {            
            return _products[j];
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
    }
}