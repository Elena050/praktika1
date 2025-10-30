using Microsoft.AspNetCore.Mvc;

namespace TestingPlatform.Controllers:

[ApiController]
[Route("api/[controller]")]
public class AnswersController : ControllerBase
{
  [HttpGet]
  public IActionResult GetAllAnswers() => Ok("Список всех ответов");

  [HttpGet("{id:int}")]
  public IActionResult GetAnswerById(int id)
  {
    if (id == 1) return Ok("Ответ 1");
    return NotFound();
  }

  [HttpGet("by-question/{questionId:int}")]
  public IActionResult GetAnswersByQuestionId(int questionId) => Ok($"Ответы для вопроса {questionId}");

  [HttpPost]
  public IactionResult CreateAnswer() => Created("/api/answers/1", "Ответ создан");

  [HttpPut("{id:int}")]
  public IActionResult UpdateAnswer(int id) => NoContent();

  [HttpDelete("{id:int}")]
  public IActionResult DeleteAnswer(int id) => NoContent();
}
