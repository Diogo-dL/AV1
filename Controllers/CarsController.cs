using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ATV_1.Models;

namespace ATV_1.Controllers;

public class CarsController : Controller
{
    private readonly ILogger<CarsController> _logger;

    public CarsController(ILogger<CarsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Cars()
    {
        return View();
    }

}
