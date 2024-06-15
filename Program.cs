using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4_Implementing_a_stack_using_an_array
{
    internal class Program
    {
        class StackUSingArray
        {
            private int MaxSize;
            private int[] stackArray;
            private int top;

            public StackUSingArray(int size)
            {
                MaxSize = size;
                stackArray = new int[size];
                top = -1;
            }
            public void Push(int value)
            {
                if (top < MaxSize - 1)
                {
                    stackArray[++top] = value;
                }
                else 
                {
                    Console.WriteLine($"Stack is full. Cannot push Element");
                }
            }
            public void Stackprint() 
            {
                Console.WriteLine("Stack: ");
                for (int i = 0; i <= top; i++) 
                {
                    Console.Write($"{stackArray[i]} ");
                }
                Console.WriteLine();
            }
            public int Pop() 
            {
                if(top >= 0) 
                {
                    return stackArray[top--];
                }else 
                {
                    Console.WriteLine("Stack is Empty. Cannot Pop Element");
                }
                return -1;
            }
        }

        static void Main(string[] args)
        {
            StackUSingArray stack = new StackUSingArray(4);
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Stackprint();
            int poppedValue = stack.Pop();
            Console.WriteLine($"Popped Value: {poppedValue}");

        }
    }
}
