using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellsBookstoreArchitecture.Interfaces
{
    public interface IAuthor
    {
        Guid ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        string Description { get; set; }
        string Nationality  { get; set; }
    }
}
