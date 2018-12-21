namespace RESTfulAPI.Services
{
    using System.Threading.Tasks;

    public class FakeTranslator : ITranslator
    {
        public Task<string> TranslateFromAsync(string language, string value)
        {
            return Task.FromResult($"The {language} word, {value}, is \"Hello world!\" in English.");
        }

        public Task<string> TranslateToAsync(string language, string value)
        {
            return Task.FromResult($"The English word, {value}, is \"Hello world!\" in {language}.");
        }
    }
}