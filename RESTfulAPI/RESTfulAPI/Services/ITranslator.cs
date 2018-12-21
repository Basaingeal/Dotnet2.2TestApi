namespace RESTfulAPI.Services
{
    using System.Threading.Tasks;

    public interface ITranslator
    {
        Task<string> TranslateToAsync(string language, string value);

        Task<string> TranslateFromAsync(string language, string value);
    }
}
