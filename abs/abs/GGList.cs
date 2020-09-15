using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace abs
{
    class GGList<P>
    {
        // P - int, string, bool.
        private P[] mas;
        //private int Len;
        /*
            int count = 0;
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        count = numbers.Count; //5
numbers.Add(6);
numbers.Add(7);
count = numbers.Count; //7
//преобразуем список в массив
int[] numbers2 = numbers.ToArray<int>();
        */
        public GGList(int len)
        {
            mas = new P[len];
        }

        public void Add(P numb)
        {
            Array.Resize(ref mas, mas.Length + 1);
            mas[mas.Length - 1] = numb;
        }
        public void Remove(int ind)
        {
           for(int i = ind; i < mas.Length - 1;i++)
            {
                int b = i+1;
                mas[i] = mas[b];
            }
            Array.Resize(ref mas, mas.Length - 1);
        }
        public void Insert(int ind, P numb)
        {
            Array.Resize(ref mas, mas.Length + 1);
            for (int i = mas.Length - 1; i > ind; i--)
            {
                //int s = mas[i++];
                int q = i-1;
                mas[i] = mas[q];
            }
            mas[ind] = numb;
        }
        //Array.Resize(ref mas, mas.Length - 1);
        public int Len()
        {
           return mas.Length;
        }
        public P this[int index]
        {
            get { return mas[index]; }
            set { mas[index] = value; }
        }
        public IEnumerator<P> GetE()
        {
            for (int i = 0; i < mas.Length; i++)
            {
                yield return mas[i];
            }
        }
        public override string ToString()
        {
            string v = "[";
            int c;
            for (int i =0; i < mas.Length-1; i++)
            {
                v += " " + this.mas[i] + ",";
            }
            v += " " + this.mas[mas.Length - 1] + "]";
            return v;
        }
    }
}
