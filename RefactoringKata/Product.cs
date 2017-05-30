using System.Collections.Generic;
using System.Text;

namespace RefactoringKata
{
    public class Product : IJson
    {
        public static int SIZE_NOT_APPLICABLE = -1;

        public string Code { get; set; }
        public ProductColor Color { get; set; }
        public ProductSize Size { get; set; }
        public double Price { get; set; }
        public string Currency { get; set; }

        public bool IsSizeApplicable
        {
            get { return Size != ProductSize.InvalidSize; }
        }

        public string ColorDesc
        {
            get { return Color.GetDescription(); }
        }

        public string SizeDesc
        {
            get { return Size.GetDescription(); }
        }

        public Product(string code, int color, int size, double price, string currency)
        {
            Code = code;

            Color = color.GetEnum<ProductColor>();

            Size = size.GetEnum<ProductSize>();

            Price = price;
            Currency = currency;
        }

        public string ToJson()
        {
            var props = new List<KeyValuePair<string, object>>();
            props.Add(new KeyValuePair<string, object>("code", Code));
            props.Add(new KeyValuePair<string, object>("color", ColorDesc));
            if (IsSizeApplicable)
            {
                props.Add(new KeyValuePair<string, object>("size", SizeDesc));
            }
            props.Add(new KeyValuePair<string, object>("price", Price));
            props.Add(new KeyValuePair<string, object>("currency", Currency));

            return JsonHelper.GetJson(props);
        }
    }
}