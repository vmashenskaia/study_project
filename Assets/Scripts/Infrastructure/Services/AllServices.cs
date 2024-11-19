using Infrastructure.Factory;

namespace Infrastructure.Services
{
    public class AllServices
    {
        private static AllServices instance;
        public static AllServices Container => instance ?? (instance = new AllServices());

        public void RegisterSingle<TService>(TService implementation) where TService : IService => 
            Implementation<TService>.ServiceInstance = implementation;

        public TService Single<TService>() where TService : IService => 
            Implementation<TService>.ServiceInstance;

        private static class Implementation<TService> where TService : IService//класс имеет дженерик параметр
        {
            public static TService ServiceInstance;
        }
    }
}