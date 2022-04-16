using TaxiManager9000.DataAccess;

namespace TaxiManager9000.Shared
{
    public static class DependencyResolver
    {
        private static readonly Dictionary<Type, object> _dependencies = new Dictionary<Type, object>()
        {
            { typeof(IUserDataBase), new UserDatabase() }
        };


        public static T GetService<T>()
        {
            return (T)_dependencies[typeof(T)];
        }
    }
}