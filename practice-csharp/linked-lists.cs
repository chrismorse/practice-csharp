using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_csharp
{
    class linked_lists
    {
        class Node
        {
            public int data;
            public Node next;

            // constructor
            public Node(int i)
            {
                data = i;
                next = null;
            }

            public void Print()
            {
                Console.Write("| " + data + " | ->  ");
                if (next != null)
                    next.Print();
                Console.WriteLine();
            }

            public void AddToEnd(int i)
            {
                if (next != null)
                    next.AddToEnd(i);
                else
                    next = new Node(i);
            }

            public void AddSorted(int i)
            {
                if (next == null)
                {
                    next = new Node(i);
                }
                else if (i < next.data)
                {
                    Node temp = new Node(i);
                    temp.next = this.next;
                    this.next = temp;
                }
                else
                {
                    next.AddSorted(i);
                }

            
            }


        }

        class MyList
        {
            public Node headNode;

            public MyList()
            {
                headNode = null;
            }

            public void AddToEnd(int data) {
                if (headNode == null)
                {
                    headNode = new Node(data);
                } 
                else 
                {
                    headNode.AddToEnd(data);
                }
            }

            public void AddToBeginning(int data)
            {
                if (headNode == null)
                {
                    headNode = new Node(data);
                }
                else
                {
                    Node tempNode = new Node(data);
                    tempNode.next = headNode;
                    headNode = tempNode;

                }

            }

            public void AddSorted(int data)
            {
                if (headNode == null)
                {
                    headNode = new Node(data);
                }
                else if (data < headNode.data)
                {
                    AddToBeginning(data);
                }
                else
                {
                    headNode.AddSorted(data);
                }
            }
            
            public void Print() {
                if (headNode != null)
                    headNode.Print();
            }

        }


        public static void RunAllTests() {
            Console.WriteLine();

/*            
            MyList myList = new MyList();
            myList.AddToBeginning(6);
            myList.AddToEnd(7);
            myList.AddToEnd(5);
            myList.AddToEnd(11);
            myList.AddToEnd(4);
            myList.AddToBeginning(3);
            myList.Print();
  
*/

            MyList myList = new MyList();
            myList.AddSorted(3);
            myList.AddSorted(1);
            myList.AddSorted(4);
            myList.AddSorted(5);
            myList.AddSorted(6);
            myList.AddSorted(0);
            myList.AddSorted(1);
            myList.Print();


        }








    }



}
