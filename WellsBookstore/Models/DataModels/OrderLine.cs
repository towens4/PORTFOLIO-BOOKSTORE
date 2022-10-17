using WellsBookstoreArchitecture.Interfaces;

namespace WellsBookstore.Models.DataModels;

public class OrderLine : WellsBookstoreArchitecture.Interfaces.IOrderLine
{
    public OrderLine(IBook book, IOrder order, int quantity, int discount)
    {
        this.ID = new Guid();
        this.Book = book;
        this.Order = order;
        this.Quantity = quantity;
        this.Discount = discount;
    }

    public Guid ID { get; set; }
    public IBook Book { get; set; }
    public IOrder Order { get; set; }
    public int Quantity { get; set; }
    public int Discount { get; set; }
}
