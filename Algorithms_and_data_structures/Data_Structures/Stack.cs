using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures.Data_Structures
{
    public class Stack<T> : IEnumerable<T>
    {
        T[] mass;
        int count;
        int size;

        public int Count { get => count; }

        // По умолчанию 10 элементов
        public Stack(int defaultSize = 10)
        {
            size = defaultSize;
            mass = new T[size];
            count = 0;
        }

        public void Push(T val)
        {
            if(count >= size)
            {
                RelocateMemory();
            }
            mass[count] = val;
            count++;
        }

        public T Pop()
        {
            if (Empty())
                throw new InvalidOperationException("Stack is empty.");
            T item = mass[--count];
            mass[count] = default; // сбрасываем ссылку
            return item;
        }

        public T Top()
        {
            if (Empty())
                throw new InvalidOperationException("Stack is empty.");
            return mass[count - 1];
        }

        public bool Empty()
        {
            return count == 0;
        }

        // Перевыделение памяти под стек
        private void RelocateMemory()
        {
            T[] tmp = new T[size];
            tmp = mass;
            size = size * size;
            mass = new T[size];

            for(int i = 0; i < tmp.Length; i++)
                mass[i] = tmp[i];
        }

        // Реализация интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for(int i = 0; i < count; i++)
            {
                yield return mass[i];
            }
        }
    }
}
