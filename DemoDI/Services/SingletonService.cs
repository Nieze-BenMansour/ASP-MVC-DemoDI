namespace DemoDI.Services
{
    public interface ISingletonService
    {
        void DoSomething();
    }

    public class SingletonService : ISingletonService
    {
        public SingletonService()
        {
            Console.WriteLine("Singleton service is instanciating.");
        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton service is doing something.");
        }
    }
}
