using System.Collections;
using System.Collections.Generic;

namespace WorkFlowExerciseWithMosh
{
	public interface IWorkFlow
	{
		void AddWorkflow(ITask task);
		void RemoveWorkflow(ITask task);
		IEnumerable<ITask> GetTask();
	}
}
