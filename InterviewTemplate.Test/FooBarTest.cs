using InterviewTemplate.GameLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewTemplate.Test
{
	[TestClass]
	public class FooBarTest
	{
		private readonly FooBar _fooBar = new();

		[TestMethod]
		public void TestFootballIsCorrect()
		{
			Assert.AreEqual(false, _fooBar.IsCorrect(0, "0"));
			Assert.AreEqual(true, _fooBar.IsCorrect(1, "1"));
			Assert.AreEqual(false, _fooBar.IsCorrect(1, "Foo"));
			Assert.AreEqual(false, _fooBar.IsCorrect(1, "Bar"));
			Assert.AreEqual(false, _fooBar.IsCorrect(1, "FooBar"));

			Assert.AreEqual(false, _fooBar.IsCorrect(3, "3"));
			Assert.AreEqual(true, _fooBar.IsCorrect(3, "Foo"));
			Assert.AreEqual(false, _fooBar.IsCorrect(3, "Bar"));
			Assert.AreEqual(false, _fooBar.IsCorrect(3, "FooBar"));

			Assert.AreEqual(false, _fooBar.IsCorrect(5, "5"));
			Assert.AreEqual(false, _fooBar.IsCorrect(5, "Foo"));
			Assert.AreEqual(true, _fooBar.IsCorrect(5, "Bar"));
			Assert.AreEqual(false, _fooBar.IsCorrect(5, "FooBar"));

			Assert.AreEqual(false, _fooBar.IsCorrect(15, "15"));
			Assert.AreEqual(false, _fooBar.IsCorrect(15, "Foo"));
			Assert.AreEqual(false, _fooBar.IsCorrect(15, "Bar"));
			Assert.AreEqual(true, _fooBar.IsCorrect(15, "FooBar"));
			Assert.AreEqual(false, _fooBar.IsCorrect(15, "3"));
			Assert.AreEqual(false, _fooBar.IsCorrect(15, "5"));

			Assert.AreEqual(false, _fooBar.IsCorrect(1, "aaa"));
			Assert.AreEqual(false, _fooBar.IsCorrect(3, "aaa"));
			Assert.AreEqual(false, _fooBar.IsCorrect(5, "aaa"));
			Assert.AreEqual(false, _fooBar.IsCorrect(15, "aaa"));
		}
	}
}
