using System.Globalization;

namespace ImportedProducts.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return Name + ", $" + (Price + CustomsFee) + $" (Customs fee: $" + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ") ";
        }

        public double TotalPrice()
        {
            return CustomsFee + Price;
        }
    }
}
