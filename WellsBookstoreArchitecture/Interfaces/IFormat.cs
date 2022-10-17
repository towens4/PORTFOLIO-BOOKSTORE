using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellsBookstoreArchitecture.Interfaces
{
    public interface IFormat
    {
        Guid ID { get; set; }
        string FormatType { get; set; }
    }
}
