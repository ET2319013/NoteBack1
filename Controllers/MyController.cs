using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class HelloController : ControllerBase
{
	[HttpGet]
	public IActionResult GetHello()
	{
		return Ok(new { message = "Hello, World, from my C# backend!" });
	}
}
