using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure._06Stacks
{
    internal class Stacks
    {
        public Stack<string> GetUndo()
        {
            var undoStack = new Stack<string>();
            undoStack.Push("Type 'Hello'");
            undoStack.Push("Delete 'o'");

            return undoStack;
        }
    }
}
