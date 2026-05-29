namespace Gemini.API.Services
{
    public interface IGeminiService
    {
        Task<string> GenerateAsync(string prompt);
    }
}
