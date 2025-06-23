namespace Service.Client
{
    public interface ICachingTrigger
    {
        void FillCache(dynamic result);
        void FillCachePostResult(dynamic result);
        T GetCahe<T>(string id);
        void SetCache(dynamic result);
    }
}