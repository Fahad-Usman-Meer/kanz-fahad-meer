using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace KanzWayScreeningAPI.Controllers;


[ApiController]
[Route("api/v1/[controller]")]
public class ScreeningController : ControllerBase
{
    [HttpGet("{number}")]
    public IActionResult GetScreeningResult(int number)
    {
        var results = new List<string>();

        for (int i = 1; i <= number; i++)
        {
            if (i % 15 == 0) // for both 3 and 5
                results.Add("KanzWay");
            else if (i % 3 == 0)
                results.Add("Kanz");
            else if (i % 5 == 0)
                results.Add("Way");
            else
                results.Add(i.ToString());
        }

        return Ok(new { results });
    }
}