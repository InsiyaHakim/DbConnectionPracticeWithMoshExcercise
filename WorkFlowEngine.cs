
namespace WorkFlowExerciseWithMosh
{
	public class WorkFlowEngine
	{
		public void Run(IWorkFlow workFlow)
		{
			foreach (ITask task in workFlow.GetTask())
				task.Execute();
		}
	}
}
