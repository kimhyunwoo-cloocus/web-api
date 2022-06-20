namespace webapi_tutorial
{
    public class MyDependency : IMyDependency
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine($"Test Msg: {message}");
        }
    }
}
