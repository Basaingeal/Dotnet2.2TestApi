using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTfulAPI.Services
{
    public interface ITranslator
    {
        Task<string> TranslateToAsync(string language, string value);
        Task<string> TranslateFromAsync(string language, string value);
    }
}
