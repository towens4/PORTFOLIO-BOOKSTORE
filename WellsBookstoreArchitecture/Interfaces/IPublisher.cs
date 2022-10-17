using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellsBookstoreArchitecture.Interfaces
{
    public interface IPublisher
    {
        Guid Id { get; set; }
        string PublisherName { get; set; }
    }
}
