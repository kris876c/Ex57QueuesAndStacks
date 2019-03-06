using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ex_57_StacksAndQueues;
using System.Collections.Generic;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestQueue()
		{
			Queue<int> stdQueue = new Queue<int>();   // standard queue implemented by .NET
			MyQueue<int> ourQueue = new MyQueue<int>();   // our manually implemented queue

			// Test generates 100 random integers and adds to both queues
			Random r = new Random();
			for (int i = 0; i < 100; i++)
			{
				int randVal = r.Next();
				stdQueue.Enqueue(randVal);
				ourQueue.Enqueue(randVal);
			}

			// Test reading back half the added integers
			for (int i = 0; i < 50; i++)
			{
				Assert.AreEqual(stdQueue.Dequeue(), ourQueue.Dequeue());
				Assert.AreEqual(stdQueue.Count, ourQueue.Count());
			}

			// Test adding 50 more random integers
			for (int i = 0; i < 50; i++)
			{
				int randVal = r.Next();
				stdQueue.Enqueue(randVal);
				ourQueue.Enqueue(randVal);
			}

			// Test reading back all the remaining values
			for (int i = 0; i < 100; i++)
			{
				Assert.AreEqual(stdQueue.Dequeue(), ourQueue.Dequeue());
				Assert.AreEqual(stdQueue.Count, ourQueue.Count());
			}

			// Test queue is empty now
			Assert.AreEqual(true, ourQueue.IsEmpty());
		}
	}
}
