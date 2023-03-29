using InterviewTemplate.IGameLogic;

namespace InterviewTemplate.GameLogic
{
	public class FooBar : IFooBar
	{
		private const int POSITION_FOO = 3;
		private const int POSITION_BAR = 5;
		private const string ANSWER_FOO = "foo";
		private const string ANSWER_BAR = "bar";

		public bool IsCorrect(int position, string answer)
		{
			bool pFoo = position % POSITION_FOO == 0;
			bool pBar = position % POSITION_BAR == 0;
			answer = answer.Trim().ToLower();

			if (pFoo && pBar && answer == ANSWER_FOO + ANSWER_BAR)
			{
				return true;
			}
			if (pFoo && !pBar && answer == ANSWER_FOO)
			{
				return true;
			}
			if (pBar && !pFoo && answer == ANSWER_BAR)
			{
				return true;
			}
			if (position > 0 && !pFoo && !pBar && int.TryParse(answer, out _) && position == int.Parse(answer))
			{
				return true;
			}
			return false;
		}
	}
}
