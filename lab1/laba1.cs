
using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello,Leonid!");
            FixedStack<int> myStack = new FixedStack<int>(5);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(15);
            myStack.Push(77);
            myStack.Push(3);
            myStack.Pop();
            int[] copyStack = new int[myStack.Count];
            Console.WriteLine($"Количество элементов в стэке: {myStack.Count}");
            Program.BubbleSort(myStack.items);
            Console.ReadLine();


        }
        public static void BubbleSort(int[]nums)
        {
            // сортировка
            int temp;
            for (int i = 0; i < nums.Length - 1; i++) // Во внешнем цикле мы берем элемент, который будем сравнивать:
            {
                for (int j = i + 1; j < nums.Length; j++) //запускаем вложенный цикл, который начинается, со следующего элемента:
                {
                    if (nums[i] > nums[j]) //Если элемент с меньшим индексом больше элемента с большим индексом, то меняем элементы местами.
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            // вывод
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
        public class FixedStack<T>
        {
            public int[] items; // элементы стека
            private int count;  // количество элементов
            const int n = 10;   // количество элементов в массиве по умолчанию
            public FixedStack()
            {
                items = new int[n];
            }
            public FixedStack(int length)
            {
                items = new int[length];
            }
            // пуст ли стек
            public bool IsEmpty
            {
                get { return count == 0; }
            }
            // размер стека
            public int Count
            {
                get { return count; }
            }
            // добвление элемента
            public void Push(int item)
            {
                // если стек заполнен, выбрасываем исключение
                if (count == items.Length)
                    throw new InvalidOperationException("Переполнение стека");
                items[count++] = item;
            }
            // извлечение элемента
            public int Pop()
            {
                // если стек пуст, выбрасываем исключение
                if (IsEmpty)
                    throw new InvalidOperationException("Стек пуст");
                int item = items[--count];
                items[count] = default(int); // сбрасываем ссылку
                return item;
            }
            // возвращаем элемент из верхушки стека
            public int Peek()
            {
                // если стек пуст, выбрасываем исключение
                if (IsEmpty)
                    throw new InvalidOperationException("Стек пуст");
                return items[count - 1];
            }

            private void Resize(int max)
            {
                int[] tempItems = new int[max];
                for (int i = 0; i < count; i++)
                    tempItems[i] = items[i];
                items = tempItems;
            }
        }
    }
    
    
}

