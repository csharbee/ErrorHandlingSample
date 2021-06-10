using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace ErrorHandlingSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? id)
        {
            _logger.Log(LogLevel.Information, "Home Index Fired");
            if (id.HasValue)
            {
                if (id == 1)
                {
                    throw new Exception("Invalid Operation");
                }
                else if (id == 2)
                {
                    return StatusCode(500);
                }
                else if (id == 3)
                {
                    return NotFound();
                }
            }
            return View();
        }
    }
}
