using System;

namespace RefactoringKata
{
    public class Product
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

        public Product(string code, int color, int size, double price, string currency)
        {
            Code = code;

            Color = color.GetEnum<ProductColor>();

            Size = size.GetEnum<ProductSize>();

            Price = price;
            Currency = currency;
        }
    }
}