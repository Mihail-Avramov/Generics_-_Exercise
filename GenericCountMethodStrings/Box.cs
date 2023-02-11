using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodStrings
{
    public class Box<T> where T: IComparable<T>
    {
        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }
        
        public void Add(T item)
        {
            items.Add(item);
        }

        public void Swap(int firstIndex, int SecondIndex)
        {
            (items[firstIndex], items[SecondIndex]) = (items[SecondIndex], items[firstIndex]);
        }

        public int Count(T itemToCompare)
        {
            int count = 0;

            foreach (T item in items)
            {
                if(item.CompareTo(itemToCompare) > 0) count++;
            }
            
            return count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString().Trim();
        }

    }
}
