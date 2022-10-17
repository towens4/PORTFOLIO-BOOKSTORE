using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Collections;

namespace WellsBookstoreArchitecture.Interfaces
{
    public interface IBook
    {
        Guid ID { get; set; }
        char ISBN { get; set; }
        string Title { get; set; }
        int NumberOfPages { get; set; }
        DateTime PublishedDate { get; set; }
        IGenre Genre { get; set; }
        IPublisher Publisher { get; set; }
        IList<ILanguage> SupportedLangauges { get; set; }
        ICollection<IAuthor> Authors { get; set; }
        string ImgUrl { get; set; }
        string Description { get; set; }
        decimal Price { get; set; }
        int IsActive { get; set; }

    }
}
