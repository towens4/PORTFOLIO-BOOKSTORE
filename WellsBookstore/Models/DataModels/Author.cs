using WellsBookstoreArchitecture.Interfaces;
namespace WellsBookstore.Models.DataModels;

public class Author : IAuthor
{
    public Author(string firstName, string lastName, 
        DateTime dateOfBirth, string description, string nationality)
    {
        this.ID = new Guid();
        this.FirstName = firstName;
        this.LastName = lastName;
        this.DateOfBirth = dateOfBirth;
        this.Description = description;
        this.Nationality = nationality;
    }

    public Guid ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Description { get; set; }
    public string Nationality { get; set; }
}
