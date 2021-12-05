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
        public static FixedStack Sort(FixedStack myStack)
        {
            int temp;
            for (int i = 0; i < myStack.Count() - 1; i++)
            {
                for (int j = i + 1; j < myStack.Count(); j++)
                {
                    if (myStack.Get(i) > myStack.Get(j))
                    {
                        temp = myStack.Get(i);
                        myStack.Set(i, myStack.Get(j));
                        myStack.Set(j, temp);
                    }
                }
            }
            return myStack;
        }
        public static void Main(string[] args)
        {
            FixedStack myStack = new();
            int[] mass = new int[3000];
            Random rnd = new Random();
            int N = 300;
            int t_s;
            int t_f;
            for (int i = 0; i < 3000; i++)
            {
                mass[i] = rnd.Next(1, 300);
            }

            for (int i = 0; i < 10; i++)
            {
                for (int z = N - 300; z < N; z++)
                {
                    if (z < 3000)
                    {
                        myStack.Push(mass[z]);
                    }

                }
                myStack.N_op = 0;
                t_s = Environment.TickCount & Int32.MaxValue;
                myStack = Program.Sort(myStack);
                t_f = Environment.TickCount & Int32.MaxValue;
                Console.WriteLine($"Номер сортировки: {i + 1} Колличество отсортированных элементов: {N}  Время сортировки(s): {t_f - t_s} Колличество операций (N_op): {myStack.N_op}");
                N += 300;

            }
        }

        
    }
}


