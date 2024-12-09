using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure._12ConcurrentStack
{
    internal class ConcurrentStacks
    {
        public ConcurrentStack<string> GetUndoStack()
        {
            var undoStack = new ConcurrentStack<string>();
            // Add operations
            undoStack.Push("Operation1");
            undoStack.Push("Operation2");

            return undoStack;
        }
    }
}
