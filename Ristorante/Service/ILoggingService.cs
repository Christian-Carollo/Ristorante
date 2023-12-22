using Microsoft.AspNetCore.Mvc;

namespace Ristorante.Service
{
    public interface ILoggingService
    {
        IActionResult Log(string message);
    }
}
