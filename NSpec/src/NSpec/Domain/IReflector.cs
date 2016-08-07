using System;
using System.Reflection;
using System.Runtime.Loader;

namespace NSpec.Domain
{
    public class Reflector : IReflector
    {
        readonly string dll;

        public Reflector(string dll)
        {
            this.dll = dll;
        }

        public Type[] GetTypesFrom()
        {
            var context = AssemblyLoadContext.Default;
            var assembly = context.LoadFromAssemblyPath(dll);

            return assembly.GetTypes();
        }

        public Type[] GetTypesFrom(Assembly assembly)
        {
            return assembly.GetTypes();
        }
    }

    public interface IReflector
    {
        Type[] GetTypesFrom();
        Type[] GetTypesFrom(Assembly assembly);
    }
}