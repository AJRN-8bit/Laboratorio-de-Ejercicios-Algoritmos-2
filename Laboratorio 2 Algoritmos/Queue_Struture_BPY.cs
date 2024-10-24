﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2_Algoritmos
{
    // Queue structure for priority
    public class Queue_Struture_BPY
    {
        // Pointer
        class Node
        {
            // can be remove 
            public bool priority { get; set; }
            public string name { get; set; }
            public Node nextElement { get; set; }
            public Node(string name, bool priority)
            {
                this.name = name;
                this.priority = priority;
                nextElement = null;
            }
        }
        public class Queue
        {
            int elementNumber = 1;
            private Node _front;
            private Node _last;
            public Queue()
            {
                _front = null;
                _last = null;
            }

            public void Add(string name, bool priority, string ifAdded, string desPriority)
            {
                // can be modified
                name = name + $" {elementNumber++}" + " " + desPriority + " " + ifAdded;

                Node newElement = new Node(name, priority);
                if (_front == null)
                {
                    _front = _last = newElement;
                }
                else
                {
                    _last.nextElement = newElement;
                    _last = newElement;
                }
                Console.WriteLine(name + " " + ifAdded);
            }
            public void Delete(string ifEmpty, string ifDeleted)
            {
                // Shows if there is no element in the front of the queue.
                if (_front == null)
                {
                    Console.WriteLine(ifEmpty);
                    elementNumber = 1;
                }

                else
                {
                    Console.WriteLine(_front.name + " " + ifDeleted);

                    _front = _front.nextElement; // Moves the pointer to the next element.

                    if (_front == null)
                    {
                        _last = null;
                    }
                }
            }
            public void ShowQueue(string ifEmpty, string ShowTitle)
            {
                // If show if the queue is empty.
                if (_front == null)
                {
                    Console.WriteLine(ifEmpty);
                }

                else
                {
                    Console.WriteLine(ShowTitle + ":");
                    Node actualElement = _front;
                    while (actualElement != null)
                    {
                        Console.WriteLine($"- {actualElement.name}");
                        actualElement = actualElement.nextElement;
                    }
                }
            }
        }
    }
}