using Microsoft.AspNetCore.Mvc;

namespace PersonalFinance.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class FirstController: ControllerBase
{
    [HttpGet]
    public IActionResult Check()
    {
        return Ok("Working");
    }

}