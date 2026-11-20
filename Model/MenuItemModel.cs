namespace foododering.Model
{
    public sealed class MenuItemModel
    {
        public int MenuItemId { get; set; }
        public int RestaurantId { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Category { get; set; } = string.Empty;
        public bool IsAvailable { get; set; }
    }
}
