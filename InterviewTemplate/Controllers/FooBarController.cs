using InterviewTemplate.IGameLogic;
using Microsoft.AspNetCore.Mvc;

namespace InterviewTemplate.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class FooBarController : ControllerBase
	{
		private readonly IFooBar _fooBar;

		public FooBarController(IFooBar fooBar)
		{
			_fooBar = fooBar;
		}

		[HttpGet]
		public IActionResult Get(int position, string answer)
		{
			if (_fooBar.IsCorrect(position, answer))
			{
				return Ok();
			}
			else
			{
				return BadRequest();
			}
		}
	}
}
