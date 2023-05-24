namespace CSharp_PR_6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ProcessBusinessLogic processBusinessLogic = new ();
			processBusinessLogic.ProcessCompleted += bl_ProcessCompleted;

			processBusinessLogic.StartProcess();
		}

		public static void bl_ProcessCompleted()
		{
			Console.WriteLine("Method Invoked!");
		}
	}
}