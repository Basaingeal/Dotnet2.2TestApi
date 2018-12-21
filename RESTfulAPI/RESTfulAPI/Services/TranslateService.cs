namespace RESTfulAPI.Services
{
    using System.Threading.Tasks;
    using Google.Cloud.Translation.V2;
    using Microsoft.Extensions.Configuration;

    public class TranslateService : ITranslator
    {
        private readonly TranslationClient translationClient;

        public TranslateService(IConfiguration configuration)
        {
            var googleApiKey = configuration["googleApiKey"];
            this.translationClient = TranslationClient.CreateFromApiKey(googleApiKey);
        }

        public async Task<string> TranslateFromAsync(string language, string value)
        {
            TranslationResult result = await this.translationClient.TranslateTextAsync(value, LanguageCodes.English, language);
            return result.TranslatedText;
        }

        public async Task<string> TranslateToAsync(string language, string value)
        {
            var result = await this.translationClient.TranslateTextAsync(value, language);
            return result.TranslatedText;
        }
    }
}