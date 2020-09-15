using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace abs
{
    class MEGA_GGList<T, U> // 1 - key; 2 - index
    {
        Dictionary<T, Komp_of_MEGA_GGList<U>> s = new Dictionary<T, Komp_of_MEGA_GGList<U>> ();
        public MEGA_GGList(int len)
        {
            

            for (int i = 0; i < len; i++)
            {
                Komp_of_MEGA_GGList<U> a = new Komp_of_MEGA_GGList<U>(len);

                s.Add((T)Convert.ChangeType(i, typeof(T)),a);
            }
        }
        public Komp_of_MEGA_GGList<U> this[T key]
        {
            
            get { if (s.ContainsKey(key)) { return s[key]; } else { s.Add(key,new Komp_of_MEGA_GGList<U>(1)); return s[key];}  }


        }
        public void Remove(T key)
        {

            s.Remove(key);
        }
        public int Len()
        {

            return s.Count;
        }
        public U this[T key, int index]
        {
            get {
                List<U> z = s[key].get();
                return z[index];
            }
            set
            {
                s[key].set(index, value);
            }
        }
        public override string ToString()
        {
            string v = "[";
            
            foreach (KeyValuePair<T, Komp_of_MEGA_GGList<U>> s in s)
            {
                v += "\n{" + s.Value.ToString() + "}";
            }

            v += "]";
            return v;
        }
    }
}

