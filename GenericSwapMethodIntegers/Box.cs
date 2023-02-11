using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodIntegers
{
    public class Box<T>
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
