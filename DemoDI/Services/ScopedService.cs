namespace DemoDI.Services
{
    public interface IScopedService
    {
        void DoSomething();
    }

    public class ScopedService : IScopedService
    {
        public ScopedService()
        {
            Console.WriteLine("Scoped service is instanciating.");
        }
        public void DoSomething()
        {
            Console.WriteLine("Scoped service is doing something.");
        }
    }

}
