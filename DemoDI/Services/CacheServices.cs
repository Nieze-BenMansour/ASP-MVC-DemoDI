namespace DemoDI.Services
{
    public interface ICacheSmallService
    {
        object Get(string key);
    }

    public interface ICacheBigService
    {
        object Get(string key);
    }

    public class BigCache : ICacheBigService
    {
        public BigCache()
        {
            
        }
        public object Get(string key)
        {
            return $"Resolving {key} from big cache.";
        }
    }

    public class SmallCache : ICacheSmallService
    {
        public SmallCache()
        {
            
        }
        public object Get(string key) => $"Resolving {key} from small cache.";
    }
}
