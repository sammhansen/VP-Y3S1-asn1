public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public VatCategory VatCategory { get; set; }

    public Product(string name, decimal price, VatCategory vatCategory)
    {
        Name = name;
        Price = price;
        VatCategory = vatCategory;
    }

    public decimal GetVatAmount()
    {
        var rate = VatRates.Rates[VatCategory];
        return rate >= 0 ? Price * rate : 0;
    }

    public decimal GetTotalPrice()
    {
        return Price + GetVatAmount();
    }
}
