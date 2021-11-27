
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
        // Массив, стэк, пузырьковая - 78
        static void Main(string[] args)
        {
            FixedStack<int> myStack = new();
            Random rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                myStack.Push(rnd.Next(1, 100));
            }
            myStack.Print();
            int temp;
            for (int i = 0; i < myStack.Count() - 1; i++) // Во внешнем цикле мы берем элемент, который будем сравнивать:
            {
                for (int j = i + 1; j < myStack.Count(); j++) //запускаем вложенный цикл, который начинается, со следующего элемента:
                {
                    if (myStack.Get(i) > myStack.Get(j)) //Если элемент с меньшим индексом больше элемента с большим индексом, то меняем элементы местами.
                    {
                        temp = myStack.Get(i);
                        myStack.Set(i,myStack.Get(j));
                        myStack.Set(j,temp);
                    }
                }
            }
            Console.WriteLine("Отсортированный массив: ");
            myStack.Print();
            Console.ReadLine();
        }
        
    }
}

