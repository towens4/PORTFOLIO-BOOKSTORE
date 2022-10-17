using System;

namespace WellsBookstoreArchitecture.Interfaces
{
    public interface IDelivery
    {
        Guid ID { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        char PhoneNumber { get; set; }
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        string Postcode { get; set; }
        string Suburb { get; set; }
        string State { get; set; }
        string Country { get; set; }
        int DeliveryStatus { get; set; }
        DateTime DeliveryDate { get; set; }
    }
}