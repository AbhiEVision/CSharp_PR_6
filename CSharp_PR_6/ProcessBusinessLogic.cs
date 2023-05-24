namespace CSharp_PR_6
{
	public delegate void Notify();

	internal class ProcessBusinessLogic
	{
		public event Notify ProcessCompleted;

		public void StartProcess()
		{
			Console.WriteLine("Process Started...!");

			Thread.Sleep(1000);

			OnProcessCompleted();
		}

		protected virtual void OnProcessCompleted()
		{
			if (ProcessCompleted != null)
			{
				ProcessCompleted?.Invoke();
			}
		}
	}
}
