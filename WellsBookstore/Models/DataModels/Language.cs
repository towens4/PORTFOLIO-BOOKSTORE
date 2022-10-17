namespace WellsBookstore.Models.DataModels;

public class Language : WellsBookstoreArchitecture.Interfaces.ILanguage
{
    public Language(string languageCode, string languageName)
    {
        this.ID = new Guid();
        this.LanguageCode = languageCode;
        this.LanguageName = languageName;
    }

    public Guid ID { get; set; }
    public string LanguageCode { get; set; }
    public string LanguageName { get; set; }
}
