using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellsBookstoreArchitecture.Interfaces
{
    public interface ILanguage
    {
        Guid ID { get; set; }
        string LanguageCode { get; set; }
        string LanguageName { get; set; }
    }
}
