namespace WellsBookstore.Models.DataModels;

public class Publisher : WellsBookstoreArchitecture.Interfaces.IPublisher
{
    public Publisher(string publisherName)
    {
        this.Id = new Guid();
        this.PublisherName = publisherName;
    }

    public Guid Id { get; set; }
    public string PublisherName { get; set; }
}
