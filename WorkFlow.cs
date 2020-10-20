using System.Collections.Generic;

namespace WorkFlowExerciseWithMosh
{
	public class WorkFlow : IWorkFlow
	{
		private readonly List<ITask> _task;
		public WorkFlow()
		{
			_task = new List<ITask>();
		}
		public void AddWorkflow(ITask task)
		{
			_task.Add(task);
		}

		public IEnumerable<ITask> GetTask()
		{
			return _task;
		}

		public void RemoveWorkflow(ITask task)
		{
			_task.Remove(task);
		}
	}
}
