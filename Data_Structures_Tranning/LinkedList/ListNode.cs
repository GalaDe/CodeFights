using System;
using System.Collections;
using System.Collections.Generic;

namespace Data_Structures_Tranning.LinkedList
{
    public class ListNode<T> 
    {
        //Getters & Setters
        public T value { get; set; }
        public ListNode<T> next { get; set; }
        public ListNode<T> previous{get; set;}
        public ListNode<T> Head { get; private set; }
        public ListNode<T> Tail { get; private set; }
        private ListNode<T> current { get; set; }
        public int Count;

        //Constructors
        public ListNode(T node)
        {
            value = node;
        }
        public ListNode()
        {
            value = value;
        }

        //public ListNode(ListNode<T> PrevNode, ListNode<T> NextNode)
        //{
        //    nPrevious = PrevNode;
        //    next = NextNode;
        //}

        //Methods
        public void AddFirst(ListNode<T> node)
        {
            ListNode<T> temp = Head;
            Head = node;
            Head.next = temp;
            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddFirst(T node)
        {
            AddFirst(new ListNode<T>(node));
        }

        public void AddLast(ListNode<T> node)
        {
            if (Count == 0)
                Head = node;
            else
                Tail.next = node;

            Tail = node;
            Count++;
        }
        public void AddLast(T node)
        {
            AddLast(new ListNode<T>(node));
        }

        public void Add(T item)
        {
            AddFirst(item);
        }

        public void RemoveFirst()
        {
            if (Count <= 1)
            {
                Clear();
            }
            else
            {
                ListNode<T> current = Head;
                Head = current.next;
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                Count--;
            }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void PrintAllNodes(ListNode<int> node)
        {
            List<int> reverseList = new List<int>();
            for (int i = node.Count - 1; i >= 0; i--)
            {
                reverseList.Add(node.next.value);
                node = node.next;
            }
            reverseList.Reverse();
            foreach (var item in reverseList)
            {
                Console.Write(item + " ");
            }      
        }
    }

    public class Node
    {
        //has the value
        public object Value { get; set; }

        //reference to another node
        public Node Next { get; set; }
    }
}

