namespace foododering.Model
{
    public sealed class DeliveryModel
    {
        public int DeliveryId { get; set; }
        public int OrderId { get; set; }
        public string OrderNumber { get; set; } = string.Empty;
        public int DeliveryPersonId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string DeliveryPersonName { get; set; } = string.Empty;
        public string DeliveryAddress { get; set; } = string.Empty;
        public string DeliveryStatus { get; set; } = "Assigned";
        public DateTime? AssignedAt { get; set; }
        public DateTime? PickedUpAt { get; set; }
        public DateTime? DeliveredAt { get; set; }
    }
}
