using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCoding
{
    class LinkedLists
    {

    }

    class SinglyLinkedList<T> where T: IComparable
    {
        public Node<T> head;

        public void AddAtStart(T data)
        {
            var newNode = new Node<T>(data);
            newNode.next = head.next;

            head = newNode;
        }

        public void AppendToEnd(T data)
        {
            var newNode = new Node<T>(data);

            var currentNode = head;

            while(currentNode.next != null)
            {
                currentNode = currentNode.next;
            }

            currentNode.next = newNode;
        }

        public void DeleteNode(T data)
        {
            if (head.data.Equals(data))
            {
                head = head.next;
                return;
            }

            var currentNode = head;
            while(currentNode.next != null)
            {
                if (currentNode.next.data.Equals(data))
                {
                    currentNode.next = currentNode.next.next;
                }
            }
            
        }
    }

    class Node<T>
    {
        public Node<T> next;
        public T data;

        public Node(T data)
        {
            this.data = data;
        }
    }
}
