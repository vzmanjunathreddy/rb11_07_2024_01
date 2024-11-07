using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class StoreClass<T> : IStoreClass<T> where T : class
    {
        private readonly Stack<T> stackList;
        public StoreClass()
        {
            stackList = new();
        }
        public int Count()
        {
            return stackList.Count;
        }

        public bool IsEmpty()
        {
            return Count() == 0;
        }

        public T Pop()
        {
            if (Count() > 0)
                return stackList.Pop();

            throw new InvalidOperationException("The stack is empty!");
        }

        public T Peek()
        {
            if (Count() > 0)
                return stackList.Peek();

            throw new InvalidOperationException("The stack is empty!");
        }

        public Stack<T> Push(T value)
        {
            stackList.Push(value);
            return stackList;
        }
    }
}
