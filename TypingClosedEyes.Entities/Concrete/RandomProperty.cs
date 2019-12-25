using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using TypingClosedEyes.Entities.Interface;

namespace TypingClosedEyes.Entities.Concrete
{
    public class RandomProperty<T> : IRandomProperty<T> where T : class, IEntity
    {
        public T GetRandomProperty()
        {
            
            var properties = ReflectiveEnumerator.GetEnumerableOfType<T>();
            return properties.Skip(new Random().Next(0, properties.Count())).Take(1).First();
        }
    }

    public static class ReflectiveEnumerator
    {
        static ReflectiveEnumerator() { }

        public static IEnumerable<T> GetEnumerableOfType<T>(params object[] constructorArgs) where T : class, IEntity
        {
            List<T> objects = new List<T>();
            foreach (Type type in
                Assembly.GetAssembly(typeof(T)).GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T))))
            {
                objects.Add((T)Activator.CreateInstance(type, constructorArgs));
            }
            //objects.Sort();
            return objects;
        }
    }
}
