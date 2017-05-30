using System.Collections.Generic;

namespace RefactoringKata
{
    public class Orders : IJson
    {
        private List<Order> _orders = new List<Order>();

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public int GetOrdersCount()
        {
            return _orders.Count;
        }

        public Order GetOrder(int i)
        {
            return _orders[i];
        }

        public string ToJson()
        {
            var props = new List<KeyValuePair<string, object>>();
            props.Add(new KeyValuePair<string, object>("orders", _orders));            

            return JsonHelper.GetJson(props);
        }
    }
}
