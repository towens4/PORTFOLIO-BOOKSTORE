namespace WellsBookstore.Models.DataModels;

public class Genre : WellsBookstoreArchitecture.Interfaces.IGenre
{
    public Genre(string genreName)
    {
        this.ID = new Guid();
        this.genreName = genreName;
    }

    public Guid ID { get; set; }
    public string genreName { get; set; }
}
