// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace Dojo_Survey.Controllers;
public class DojoSurveyController : Controller   // Remember inheritance?    
{
    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpPost("process")]
    public IActionResult Process(
        string name,
        string location,
        string language,
        string comment
    )
    {
        Console.WriteLine("Process");
        ViewBag.Test = "test";
        return RedirectToAction("Result");
    }

    // [HttpGet("results")]
    

    [HttpPost("results")]
    public ViewResult Result(
        string name,
        string location,
        string language,
        string comment
    )
    {
        Console.WriteLine("Results");
        if (string.IsNullOrWhiteSpace(name)) ViewBag.Name = "No name provided";
        else ViewBag.Name = name;
        ViewBag.Location = location;
        ViewBag.Language = language;
        ViewBag.Comment = comment;
        return View();
    }
}