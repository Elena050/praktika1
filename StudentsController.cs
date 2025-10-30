using Microsoft.AspNetCore.Mvc;

namespace TestingPlatform.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsContriller : ControllerBase
{
  [HttpGet]
  public IActonResult GetAllStudents() => Ok("Список студентов");

  [HttpGet("{id:int}")]
  public IActionResult CreateStudent()
  {
    return Created("/api/students/1", "Создан студент с id=1");
  }

  [HttpPost("id:int}")]
  public IactionResult UpdateStudent(int id)
  {
    if (id <= 0) return BadRequest("Некорректный id");
    if (id != 1) return NotFound();
    return NoContent();
  )
  
