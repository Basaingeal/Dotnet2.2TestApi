namespace RESTfulAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using RESTfulAPI.Services;

    [Route("api/[controller]")]
    [ApiController]
    public class TranslateController : ControllerBase
    {
        private readonly ITranslator translator;

        public TranslateController(ITranslator translator)
        {
            this.translator = translator;
        }

        // GET: api/Translate/Latin/Hello world!
        [HttpGet("{language}/{value}")]
        public async Task<string> Get(string language, string value)
        {
            return await this.translator.TranslateToAsync(language, value);
        }

        [HttpGet("{language}/{value}/toEn")]
        public async Task<string> GetToEn(string language, string value)
        {
            return await this.translator.TranslateFromAsync(language, value);
        }
    }
}
