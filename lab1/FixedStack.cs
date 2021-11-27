using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class FixedStack<T>
    {
        private List<int> stack = new List<int>();
        
        
        // размер стека
        public int Count()
        {
             return stack.Count; 
        }
        // добвление элемента
        public void Push(int item)
        {
            stack.Add(item);
        }
        // извлечение элемента
        public int Pop()
        {
            int result = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);

            return result;
        }
        public int Get(int pos)
        {
            Stack<int> tmp = new Stack<int>();
            for (int i = Count() - 1; i > pos; i--)
            {
                tmp.Push(Pop());
            }
            int Result = stack[Count() - 1];
            for (int i = tmp.Count() - 1; i >= 0; i--)
            {
                Push(tmp.Pop());
            }
            return Result;
        }

        public void Set(int pos, int value)
        {
            Stack<int> tmp = new Stack<int>();
            for (int i = Count() - 1; i > pos; i--)
            {
                tmp.Push(Pop());
            }
            stack[Count() - 1] = value;
            for (int i = tmp.Count() - 1; i >= 0; i--)
            {
                Push(tmp.Pop());
            }
        }
        public void Print()
        {
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }

}
