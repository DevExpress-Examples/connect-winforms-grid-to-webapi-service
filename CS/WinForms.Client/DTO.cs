namespace WinForms.Client {
    public class DTO {
        public Guid ID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }
        public DateTime OrderDate { get; set; }
        //
        public static DTO Create(OData.Server.BusinessObjects.OrderItem item) {
            return new DTO() {
                ID = item.ID,
                ProductName = item.ProductName,
                UnitPrice = item.UnitPrice,
                Quantity = item.Quantity,
                Discount = item.Discount,
                OrderDate = item.OrderDate.Date
            };
        }
        public void ApplyChanges(OData.Server.BusinessObjects.OrderItem item) {
            item.ID = ID;
            item.OrderDate = OrderDate;
            item.Quantity = Quantity;
            item.Discount = Discount;
            item.UnitPrice = UnitPrice;
            item.ProductName = ProductName;
        }
    }

}
