using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CsharpPractice
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		//How many times will this loop iterate
		//Answer: 1 times
		public void LoopsQuiz1()
		{
			int x = 0;
			while (x < 1)
			{
				x++;
			}

		}

		[TestMethod]
		//What will be the output that is written by Trace.WriteLine after the test finishes execution
		//Answer: 0
		public void LoopsQuiz2()
		{
			int x = 0;
			while (x < 1)
			{
				Trace.WriteLine(x);
				x++;
			}
		}

		[TestMethod]
		//How many times will this loop iterate
		//Answer: 0 times
		public void LoopsQuiz3()
		{
			int x = 1;
			while (x < 1)
			{
				Trace.WriteLine(x);
				x++;
			}
		}

		[TestMethod]
		//How many times will this loop iterate
		//Answer: infinite loop because always will be true
		public void LoopsQuiz4()
		{
			int x = 1;
			while (true)
			{
				Trace.WriteLine(x);
				x++;
			}
		}

		[TestMethod]
		//How many times will this loop iterate, !true = not true = false
		//Answer: 0
		public void LoopsQuiz5()
		{
			int x = 1;
			while (!true)
			{
				Trace.WriteLine(x);
				x++;
			}
		}

		[TestMethod]
		//How many times will this loop iterate
		//Answer: 
		public void LoopsQuiz6()
		{
			int x = 1;
			while (x <= 11)
			{
				Trace.WriteLine(x);
				x++;
			}
		}
	}
}
