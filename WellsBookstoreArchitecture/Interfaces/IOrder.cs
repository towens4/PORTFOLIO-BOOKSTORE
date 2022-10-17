using System;

namespace WellsBookstoreArchitecture.Interfaces
{
    public interface IOrder
    {
        Guid ID { get; set; }
        IDelivery Delivery { get; set; }
        int OrderNo { get; set; }
        decimal TotalPrice { get; set; }
        string PaymentStatus { get; set; }
        DateTime PaymentDate { get; set; }
        int OrderStatus { get; set; }
    }
}