using System;

namespace WorkFlowExerciseWithMosh
{
	public class SendMessage : ITask
	{
		public void Execute()
		{
			Console.WriteLine("Executing send message");
		}
	}
}
