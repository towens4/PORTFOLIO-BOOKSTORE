namespace WellsBookstoreArchitecture.Interfaces
{
    public interface IPhysicalBook : IBook
    {
        string Dimensions { get; set; }
        int Weight { get; set; }
    }
}