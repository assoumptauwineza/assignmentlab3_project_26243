namespace foododering.Model
{
    public sealed class CartItemModel
    {
        public int CartItemId { get; set; }
        public int CartId { get; set; }
        public int MenuItemId { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Subtotal => Quantity * UnitPrice;
    }
}
