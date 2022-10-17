using WellsBookstoreArchitecture.Interfaces;

namespace WellsBookstore.Models.DataModels
{
    public class Order : WellsBookstoreArchitecture.Interfaces.IOrder
    {
        public Order(IDelivery delivery, int orderNo, decimal totalPrice,
            string paymentStatus, DateTime paymentDate, int orderStatus)
        {
            this.ID = new Guid();
            this.Delivery = delivery;
            this.OrderNo = orderNo;
            this.TotalPrice = totalPrice;
            this.PaymentStatus = paymentStatus;
            this.PaymentDate = paymentDate;
            this.OrderStatus = orderStatus;
        }

        public Guid ID { get; set; }
        public IDelivery Delivery { get; set; }
        public int OrderNo { get; set; }
        public decimal TotalPrice { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
        public int OrderStatus { get; set; }
    }
}
