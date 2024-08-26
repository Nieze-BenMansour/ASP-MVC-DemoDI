namespace DemoDI.Services
{
    public interface ITransientService
    {
        void DoSomething();
    }

    public class TransientService : ITransientService
    {
        public TransientService()
        {
            Console.WriteLine("Transient service is instanciating.");
        }

        public void DoSomething()
        {
            Console.WriteLine("Transient service is doing something.");
        }
    }

}
