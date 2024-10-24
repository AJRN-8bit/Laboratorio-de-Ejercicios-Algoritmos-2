using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2_Algoritmos
{
    public class Char_Stack_Structure
    {
        class Pointer
        {
            public char Value { get; set; } // change the value type
            public Pointer Next { get; set; }
            public Pointer(char Value)
            {
                this.Value = Value;
                Next = null;
            }
        }
        // Creates a new stack
        public class Pile
        {
            private Pointer peek;
            public Pile()
            {
                peek = null;
            }

            public void Push(char Value)
            {
                // Adds a new node to the stack, therefor increasing the peek.
                Pointer newNode = new Pointer(Value);
                newNode.Next = peek;
                peek = newNode;

            }
            public char Pop()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("La pila esta vacía.");
                }
                // It moves to the next node, or previous peek of the stack.
                char Value = peek.Value;
                peek = peek.Next;
                return Value;
            }
            public char Top()
            {
                if (peek == null)
                    throw new InvalidOperationException("La pila esta vacía.");
                return peek.Value;
            }
            public bool IsEmpty()
            {
                // Checks if the stack is empty
                return peek == null;
            }

        }
    }
}
