using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTfulAPI.Services;

namespace RESTfulAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslateController : ControllerBase
    {
        private ITranslator _translator;

        public TranslateController(ITranslator translator)
        {
            _translator = translator;
        }

        // GET: api/Translate/Latin/Hello world!
        [HttpGet("{language}/{value}")]
        public async Task<string> Get(string language, string value)
        {
            return await _translator.TranslateToAsync(language, value);
        }

        [HttpGet("{language}/{value}/toEn")]
        public async Task<string> GetToEn(string language, string value)
        {
            return await _translator.TranslateFromAsync(language, value);
        }
    }
}
