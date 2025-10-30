using Microsoft.AspNetCore.Mvc;

namesrace TestingPlatform.controllers;

[Apicontroller]
[Route("api/[controller]")]
public class QuestionsController : ControllerBase
{
  [HttpGet]
  public IActionResult GetAllQuestions() => Ok("Список всех вопросов");

  [HttpGet("{id:int}")]
  public IactionResult GetQuestionById(int id)
  {
    if (id == 1) return Ok("Вопрос 1");
    return NotFound();
  }

  [HttpGet("by-test/{testId:int}")]
  public IactionResult CreateQuestionByTestId(int testId) => Ok($"Вопросы для теста {testId}");

  [HttpPost]
  public IactionResult CreareQuestion() => Created("/api/questions/1", "Вопрос создан");

  [HttpPut("{id:int}")]
  public IActionResult UpdateQuestion(int id) => NoContent();

  [HttpDelete("{id:int}")]
  public IActionResult DeleteQuestion(int id) => Nocontont();
}
