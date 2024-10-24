using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2_Algoritmos
{
    public class Int_Stack_Structure 
    {
        // Pointer
        class Pointer
        {
            public int Value { get; set; } // change the value type
            public Pointer Next { get; set; }
            public Pointer(int Value)
            {
                this.Value = Value;
                Next = null;
            }
        }
        // Creates a new pile
        public class Pile 
        {
            private Pointer peek;
            public Pile()
            {
                peek = null;
            }
            
            public void Push(int Value)
            {
                // Adds a new node to the pile, therefor increasing the peek.
                Pointer newNode = new Pointer(Value);
                newNode.Next = peek;
                peek = newNode;

            }
            public int Pop()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("La pila esta vacía.");
                }
                // It moves to the next node, or previous peek of the pile.
                int Value = peek.Value;
                peek = peek.Next;
                return Value;
            }
            public int Top()
            {
                if(peek == null)
                    throw new InvalidOperationException("La pila esta vacía.");
                return peek.Value;
            }
            public bool IsEmpty()
            {
                // Checks if the pile is empty
                return peek == null;
            }
            
        }
    }
}
