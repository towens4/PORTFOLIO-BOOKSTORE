using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellsBookstoreArchitecture.Interfaces
{
    public interface IOrderLine
    {
        Guid ID { get; set; }
        IBook Book { get; set; }
        IOrder Order { get; set; }
        int Quantity { get; set; }
        int Discount { get; set; }
    }
}
