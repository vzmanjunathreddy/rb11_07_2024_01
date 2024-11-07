using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IStoreClass<T> where T : class
    {
        public Stack<T> Push(T value);
        public T Pop();
        public T Peek();
        public int Count();
        public bool IsEmpty();
    }
}
