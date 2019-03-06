using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_57_StacksAndQueues
{
	public class MyQueue<T>
	{
		// Insert local datastructures here ...
		private class Node
		{
				public T Data { get; set; }
				public Node Next { get; set; }
		}
			private Node Head;
			private Node Tail; 
		private int NoOfElements { get; set; }

		public MyQueue()
		{
			Head = null;
			Tail = null;


		}

		public void Enqueue(T item)
		{
			Node n = new Node();
			n.Data = item;
			if(Tail == null)
			{
				Tail = n;
				Head = n;
			}
			else
			{
				Tail.Next = n;
				Tail = Tail.Next;
			}
			NoOfElements++;
		}
		public T Dequeue()
		{
			T result;
			if (IsEmpty())
			{
				result = default(T);
			}
			else
			{
				Node n = Head;
				Head = Head.Next;
				if (Head == null)
				{
					Tail = null;
				}
				n.Next = null;
				return n.Data;
			}
			return result;
		}

		public int Count()
		{
			int result = 0;
			Node pointer = Head;
			if (pointer == null)
			{
				result = 0;
			}
			else
			{
				while (pointer != null)
				{
					pointer = pointer.Next;
					result++;
				}
			}
			return result;
		}

		public Boolean IsEmpty()
		{
			return (Head == null);
		}
	}
}
