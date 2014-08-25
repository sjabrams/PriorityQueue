using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    public class PriorityQueue<T>
    {

        private List<T> list;

        public PriorityQueue() { 
            list = new List<T>();
        }

        public bool IsEmpty() {
            if (list.Count() <= 0) { 
                return true;
            }
            return false;
        }

        public int Count() {
            return list.Count;
        }

        public void Clear() {
            list.Clear();
        }

        public T Peak() {
            if (this.IsEmpty()) {
                return default(T);
            }
            return list.ElementAt(0);
        }

        public void Enqueue(T item) {
            list.Add(item);
        }

        public void prioritize(T item) {
            if (this.IsEmpty()) {
                return;
            }
            if (list.Contains(item)) {
                int loc = list.IndexOf(item);
                T value = list.ElementAt(loc);
                list.RemoveAt(loc);
                list.Insert(0, value);
            }
        }

        public T Dequeue() {
            if (this.IsEmpty()) {
                return default(T);
            }
            T value = list.ElementAt(0);
            list.RemoveAt(0);
            return value;
        }


    }
}
