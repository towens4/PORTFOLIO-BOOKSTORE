namespace WellsBookstore.Models.DataModels;

public class Delivery : WellsBookstoreArchitecture.Interfaces.IDelivery
{
    public Delivery(string email, string firstName, string lastName,
        char phoneNumber, string addressLine1, string addressLine2, string postcode,
        string suburb, string state, string country, int deliveryStatus,
        DateTime deliveryDate)
    {
        this.ID = new Guid();
        this.Email = email;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.PhoneNumber = phoneNumber;
        this.AddressLine1 = addressLine1;
        this.AddressLine2 = addressLine2;
        this.Postcode = postcode;
        this.Suburb = suburb;
        this.State = state;
        this.Country = country;
        this.DeliveryStatus = deliveryStatus;
        this.DeliveryDate = deliveryDate;
    }

    public Guid ID { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public char PhoneNumber { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string Postcode { get; set; }
    public string Suburb { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public int DeliveryStatus { get; set; }
    public DateTime DeliveryDate { get; set; }
}
