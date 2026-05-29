using Gemini.API.Models;
using Gemini.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gemini.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeminiController : ControllerBase
    {
        private readonly IGeminiService _geminiService;

        public GeminiController(
            IGeminiService geminiService)
        {
            _geminiService = geminiService;
        }

        [HttpPost("ask")]
        public async Task<IActionResult> Ask(
            GeminiRequest request)
        {
            var response =
                await _geminiService.GenerateAsync(
                    request.Prompt);

            return Ok(new
            {
                Response = response
            });
        }
    }
}
