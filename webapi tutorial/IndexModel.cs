namespace webapi_tutorial
{
    public class IndexModel : IMyDependency
    {
        private readonly IMyDependency myDependency;

        public IndexModel(IMyDependency myDependency)
        {
            this.myDependency = myDependency;
        }

        public void WriteMessage(string message)
        {
            Console.WriteLine($"Index message {message}");
        }
    }
}
