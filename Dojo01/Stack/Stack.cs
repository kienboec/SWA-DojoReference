using System;

namespace SWAStack.Stack
{
    class Stack<T>
    {
        private StackElement<T> _currentElement; //stores the latest entry of the stack

        /// <summary>
        /// Adds new Elements to the stack 
        /// </summary>
        /// <param name="item">item which should be added to the stack</param>
        public void Push(T item)
        {
            if (_currentElement == null)
            {
                _currentElement = new StackElement<T>() { ValueOfElement = item, Successor = null };
            }
            else
            {
                StackElement<T> temp = new StackElement<T>() { ValueOfElement = item, Successor = _currentElement };
                _currentElement = temp;
            }

        }

        /// <summary>
        /// Removes the last entry from the Stack
        /// If the stack is empty pop will return a default value
        /// </summary>
        /// <returns>deleted stack entry</returns>
        public T Pop()
        {
            if (_currentElement != null)
            {
                T temp = _currentElement.ValueOfElement;
                _currentElement = _currentElement.Successor;
                return temp;
            }
            else
            {
                throw new NullReferenceException(); //throw an exception becasue stack is entry
            }
        }

        /// <summary>
        /// Returns the value of the last entry (on top of the stack)
        /// If the stack is empty pop will return a default value
        /// </summary>
        /// <returns>value of current stack entry</returns>
        public T Peek()
        {
            if (_currentElement != null)
            {
                return _currentElement.ValueOfElement;
            }
            else
            {
                return default(T);
            }
        }

    }
}
