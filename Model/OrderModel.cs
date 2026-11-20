namespace foododering.Model
{
    public sealed class OrderModel
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; } = string.Empty;
        public int CustomerId { get; set; }
        public int RestaurantId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string RestaurantName { get; set; } = string.Empty;
        public string DeliveryAddress { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string OrderStatus { get; set; } = "Pending";
        public string PaymentStatus { get; set; } = "Pending";
    }
}
