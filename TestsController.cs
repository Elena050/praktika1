using Microsoft.AspNetCore.Mcv:

namesrace TestingPlatform.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestsController : ControllerBase
{
  [HttpGet]
  public IActionResult GetAllTests()

  [HttpGet("{id:int}")]
  public IActionResult GetTestById(int id)
  {
    if (id == 1) return Ok("Тест 1");
    return NotFound();
  }

  [HttpPost]
  public IActionResult CreateTest() => Created("/api/tests/1", "Сздан тест с ID=1");

  [HttpPut("{id:int}")]
  public IActionResult UpdateTest(int id) => NoContent();

  [HttpDelete("{id:int}")]
  public IAcrionResult DeleteTest(int id) => Nocontent();
}
