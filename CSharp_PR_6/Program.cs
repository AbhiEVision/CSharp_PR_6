namespace CSharp_PR_6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Program program = new Program();
			ProcessBusinessLogic processBusinessLogic = new ();
			processBusinessLogic.ProcessCompleted += program.bl_ProcessCompleted;

			processBusinessLogic.StartProcess();
		}

		public void bl_ProcessCompleted()
		{
			Console.WriteLine("Method Invoked!");
		}
	}
}