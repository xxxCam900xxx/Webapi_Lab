using Microsoft.AspNetCore.Mvc;

namespace M223HelloWorld.Controllers;

[ApiController]
[Route("hello")]
public class HelloController : ControllerBase 
{

    [HttpGet("{num1}/{num2}")]
    public IActionResult Sum(int num1, int num2)
    {
        int result = num1 + num2;
        return Ok(result);
    }

}