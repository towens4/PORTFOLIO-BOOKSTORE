using WellsBookstoreArchitecture.Interfaces;
namespace WellsBookstore.Models.DataModels;

public class Book : IPhysicalBook
{
    public Book(string dimensions, int weight,
        char iSBN, string title,
        int numberOfPages, DateTime publishedDate,
        IGenre genre, IPublisher publisher, IList<ILanguage> supportedLangauges,
        ICollection<IAuthor> authors, string imgUrl, string description,
        decimal price, int isActive)
    {
        this.ID = new Guid();
        this.Dimensions = dimensions;
        this.Weight = weight;
        this.ISBN = iSBN;
        this.Title = title;
        this.NumberOfPages = numberOfPages;
        this.PublishedDate = publishedDate;
        this.Genre = genre;
        this.Publisher = publisher;
        this.SupportedLangauges = supportedLangauges;
        this.Authors = authors;
        this.ImgUrl = imgUrl;
        this.Description = description;
        this.Price = price;
        this.IsActive = isActive;
    }
    public Guid ID { get; set; }
    public string Dimensions { get; set; }
    public int Weight { get; set; }
    public char ISBN { get; set; }
    public string Title { get; set; }
    public int NumberOfPages { get; set; }
    public DateTime PublishedDate { get; set; }
    public IGenre Genre { get; set; }
    public IPublisher Publisher { get; set; }
    public IList<ILanguage> SupportedLangauges { get; set; }
    public ICollection<IAuthor> Authors { get; set; }
    public string ImgUrl { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int IsActive { get; set; }
}
