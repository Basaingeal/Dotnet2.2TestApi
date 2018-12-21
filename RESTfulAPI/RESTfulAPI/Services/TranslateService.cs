using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Google.Cloud.Translation.V2;
using Microsoft.Extensions.Configuration;

namespace RESTfulAPI.Services
{
    public class TranslateService : ITranslator
    {
        private string googleApiKey;
        private TranslationClient translationClient;


        public TranslateService(IConfiguration configuration)
        {
            googleApiKey = configuration["googleApiKey"];
            translationClient = TranslationClient.CreateFromApiKey(googleApiKey);

        }

        public async Task<string> TranslateToAsync(string language, string value)
        {
            TranslationResult result = await translationClient.TranslateTextAsync(value, language);
            return result.TranslatedText;
        }

        

        public async Task<string> TranslateFromAsync(string language, string value)
        {
            TranslationResult result = await translationClient.TranslateTextAsync(value, LanguageCodes.English, language);
            return result.TranslatedText;
        }
    }
}
