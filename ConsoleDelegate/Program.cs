// See https://aka.ms/new-console-template for more information

ProcessService.ProcessHandler processHandler = new ProcessService.ProcessHandler(ProcessService.Accepted);

processHandler += ProcessService.Send;

processHandler.Invoke();

internal static class ProcessService
{
    public delegate void ProcessHandler();
    private static bool OperationSucess = true;
    public static void Accepted()
    {
        if (OperationSucess != true)
        {
            Console.WriteLine("Operation is failed");
        }
        else 
        {
            Console.WriteLine("Accepted");
        }
    }

    public static void Send()
    {
        if (!OperationSucess)
        {
            Console.WriteLine("Operaiton is failed");
        }
        else
        {
            Console.WriteLine("Sending");
        }
    }
}