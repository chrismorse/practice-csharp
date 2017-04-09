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
			}

		}

		class LinkedList
		{
			private Node _headNode;
			private Node _tailNode;

			public LinkedList()
			{
				_headNode = null;
				_tailNode = null;
			}

			public void AddToEnd(int data)
			{
				if (_headNode == null)
				{
					_headNode = new Node(data);
					_tailNode = _headNode;
				}
				else
				{
					Node newNode = new Node(data);
					_tailNode.next = newNode;
					_tailNode = newNode;
				}
			}

			public void AddToBeginning(int data)
			{
				if (_headNode == null)
				{
					_headNode = new Node(data);
					_tailNode = _headNode;
				}
				else
				{
					Node newNode = new Node(data);
					newNode.next = _headNode;
					_headNode = newNode;
				}

			}




			public void Print() {
				Node iteratorNode = _headNode;

				while(iteratorNode != null) {
					iteratorNode.Print();
					iteratorNode = iteratorNode.next;
				}
				Console.WriteLine();
			}

			public void AddSorted(int data) {
				// if empty list then insert at beginning.
				if (_headNode == null)
				{
					AddToBeginning(data);
				}
				else
				{
					
					Node current = _headNode;

					// Check and see if it needs to go at the beginning
					if (current.data >= data)
					{
						AddToBeginning(data);
					}
					else
					{
						// walk through list and find where to insert
						while (current.next != null && data >= current.next.data)
							current = current.next;

						Node newNode = new Node(data);
						newNode.next = current.next;
						current.next = newNode;

						if (current == _tailNode)
							_tailNode = newNode;

					}

				}




			}


		}


		public static void RunAllTests()
		{
			Console.WriteLine();


			LinkedList myList = new LinkedList();
			myList.AddToEnd(1);
			myList.AddToBeginning(2);
			myList.Print();

			LinkedList myList2 = new LinkedList();
			myList2.AddSorted(3);
			myList2.AddSorted(2);
			myList2.AddSorted(1);
			myList2.AddSorted(4);
			myList2.Print();


		}








	}



}
