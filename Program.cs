namespace WorkFlowExerciseWithMosh
{
	class Program
	{
		static void Main(string[] args)
		{
			var workFlow = new WorkFlow();
			workFlow.AddWorkflow(new SendMessage());
			workFlow.AddWorkflow(new GenerateSchema());

			var workFlowEngine = new WorkFlowEngine();
			workFlowEngine.Run(workFlow);
		}
	}
}
