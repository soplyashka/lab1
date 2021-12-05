using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class FixedStack
    {
        public int N_op = 0;
        private List<int> stack = new List<int>(); 
        // размер стека
        public int Count()
        {
             return stack.Count; //2
             
        }
        // добвление элемента
        public void Push(int item) //2
        {
            stack.Add(item); //2
            N_op += 2;
        }
        // извлечение элемента
        public int Pop() //5
        {

            int result = stack[stack.Count - 1]; //3
            stack.RemoveAt(stack.Count - 1); //2
            N_op += 5;

            return result;
        }
        public int Get(int pos)
        {
            FixedStack tmp = new FixedStack(); N_op += 2;
            int result = 0; N_op += 2;
            for (int i = Count() - 1; i > pos; i--)
            {
                N_op++;
                tmp.Push(Pop());
                N_op +=8;
            }
            if (Count() != 0)
            {
                result = stack[Count() - 1]; N_op += 3;
            }

            for (int i = tmp.Count() - 1; i >= 0; i--)
            {
                N_op++;
                Push(tmp.Pop());
                N_op += 8;
            }

            return result;
        }


        public void Set(int pos, int value)
        {
            FixedStack tmp = new FixedStack(); N_op += 2;
            for (int i = Count() - 1; i > pos; i--)
            {
                N_op++;
                tmp.Push(Pop());
            }
            if (Count() != 0)
            {
                stack[Count() - 1] = value; N_op += 3;
            }
            for (int i = tmp.Count() - 1; i >= 0; i--)
            {
                N_op++;
                Push(tmp.Pop());
                N_op += 8;
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
