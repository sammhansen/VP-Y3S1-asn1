public class SaleItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public SaleItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    public decimal Subtotal => Product.Price * Quantity; public decimal Vat => Product.GetVatAmount() * Quantity; public decimal Total => Product.GetTotalPrice() * Quantity;
}
