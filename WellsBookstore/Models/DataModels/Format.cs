namespace WellsBookstore.Models.DataModels;

public class Format : WellsBookstoreArchitecture.Interfaces.IFormat
{
    public Format(string formatType)
    {
        this.ID = new Guid();
        this.FormatType = formatType;
    }

    public Guid ID { get; set; }
    public string FormatType { get; set; }
}
