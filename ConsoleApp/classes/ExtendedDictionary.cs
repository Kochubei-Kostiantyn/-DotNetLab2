using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.classes
{
    public class ExtendedDictionary<T, U, V>
    {
        private Dictionary<T, U> dicU { get; set; }
        private Dictionary<T, V> dicV { get; set; }

        public ExtendedDictionary()
        {
            dicU = new Dictionary<T, U>();
            dicV = new Dictionary<T, V>();
        }
        public void Add (T key, U value1, V value2)
        {
            dicU[key] = value1;
            dicV[key] = value2;
        }
        public void Remove (T key)
        {
            dicU.Remove(key);
            dicV.Remove(key);
        }
        public bool ContainsKey(T key)
        {
            return dicU.ContainsKey(key);
        }
        public bool ContainsValues (U value1, V value2)
        {
            List<T> keys = new List<T>();
            foreach (var (key, item) in dicU)
                if (item.Equals(value1))
                    keys.Add(key);

            foreach (var (key, item) in dicV)
                if (item.Equals(value2))
                    foreach (T k in keys)
                        if (k.Equals(key))
                            return true;
            return false;
        }
        public (U, V) this[T ind]
        {
            get => (dicU[ind], dicV[ind]);
            set => Add(ind, value.Item1, value.Item2);
        }
        public int Count()
        {
            return dicU.Count;
        }
    }
}
