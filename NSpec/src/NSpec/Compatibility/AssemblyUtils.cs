using System.Reflection;

namespace NSpec.Compatibility
{
    public static class AssemblyUtils
    {
        public static Assembly LoadFromPath(string filePath)
        {
            Assembly assembly;

#if NETSTANDARD1_6
            var context = System.Runtime.Loader.AssemblyLoadContext.Default;
            assembly = context.LoadFromAssemblyPath(filePath);
#endif
#if NET45
            assembly = Assembly.LoadFrom(filePath);
#endif

            return assembly;
        }
    }
}
