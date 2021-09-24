using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms_and_data_structures.Data_Structures.List;

namespace Algorithms_and_data_structures.Data_Structures.List
{
    public class List<T> : IEnumerable<T>
    {
        Node<T> head;   //Начало списка
        Node<T> tail;   //Конец списка
        int     count;  //Количество элементов в списке

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        // Добавить элемент
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
            }
            tail = node;

            count++;
        }

        // Добавить массив элементов
        public void Add(T []data)
        {
            for(int i = 0; i < data.Length; ++i)
            {
                Add(data[i]);
            }
        }

        // Добавить в начало
        public void AppendFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = head;
            head = node;
            if (count == 0)
                tail = head;
            count++;
        }

        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение head
                        head = head.Next;

                        // если после удаления список пуст, сбрасываем tail
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

        // Содержит ли список элемент
        public bool Contains(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        // Получить значение по индексу
        public T GetValueIndex(int index)
        {
            int i = 0;
            Node<T> current = head;
            while (current != null)
            {
                if (i == index)
                    return current.Data;
                current = current.Next;
                i++;
            }
            return current.Data;
        }

        // Очистка списка
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        // Реализация интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}

