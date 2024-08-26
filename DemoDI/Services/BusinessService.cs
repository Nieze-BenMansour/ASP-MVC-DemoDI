namespace DemoDI.Services
{
    public interface IBusinessService
    {
    }

    public class BusinessService : IBusinessService
    {
        private readonly SingletonService _singletonService;
        private readonly IScopedService _scopedService;
        private readonly ITransientService _transientService;

        public BusinessService(SingletonService singletonService, IScopedService scopedService, ITransientService transientService)
        {
            _singletonService = singletonService;
            _scopedService = scopedService;
            _transientService = transientService;
        }
    }
}
