
using System.Reflection;
using Task_1;

namespace Task_2
{
    public static class Extensions
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = list.GetType().
                GetField("_array", BindingFlags.NonPublic | 
                BindingFlags.Instance).GetValue(list) as T[];

            return array;
        }
    }
}
