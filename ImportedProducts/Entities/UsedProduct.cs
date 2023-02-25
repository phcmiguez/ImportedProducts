
namespace ImportedProducts.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + $"Date: " + ManufacturedDate.ToString("dd/MM/yyyy") + " (used)";
        }
    }
}
