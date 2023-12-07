using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.classes
{
    public static class ListExtensions
    {
        public static int MyCount<T>(this List<T> list, T t) where T : IComparable<T>
        {
            int result = 0;
            foreach (T item in list)
                if (item.Equals(t))
                    result++;
            return result;
        }
        public static List<T> MyUnic<T>(this List<T> list) where T : IComparable<T>
        {
            List<T> result = new List<T>();
            Dictionary<T, bool> dic = new Dictionary<T, bool>();
            foreach (T item in list)
            {
                dic[item] = true;
                if (dic.Count > result.Count)
                    result.Add(item);
            }
            return result;
        }
    }
}
