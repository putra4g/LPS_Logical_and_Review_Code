using LPS_Logical_and_Review_Code.Class;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LPS_Logical_and_Review_Code
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Exam A_1 : ");
			Console.WriteLine("-----------");
			var sum = new Sum();
			Console.WriteLine(sum.SumNumbers(null, 0));  // output: NaN, no error

			Console.WriteLine();
			Console.WriteLine("#============================================================#");
			Console.WriteLine();

			Console.WriteLine("Exam A_2 : ");
			Console.WriteLine("-----------");
			var App = new Application();
			var TupleInfo = App.GetApplicationInfo();
			Console.WriteLine($"Id = { TupleInfo.Item1}");
			Console.WriteLine($"First Name = { TupleInfo.Item2}");

			Console.WriteLine();
			Console.WriteLine("#============================================================#");
			Console.WriteLine();

			Console.WriteLine("Exam A_3 : ");
			Console.WriteLine("-----------");
			var laptop = new Laptop("macOs");
			Console.WriteLine("Laptop os: " + laptop.Os); // Laptop os: macOs

			Console.WriteLine();
			Console.WriteLine("#============================================================#");
			Console.WriteLine();

			Console.WriteLine("Exam A_4 : ");
			Console.WriteLine("-----------");
			var myList = new List<Product>();
			//remove comment on while for test
			//while (true)
			{
				// populate list with 1000 integers  
				for (int i = 0; i < 1000; i++)
				{
					myList.Add(new Product(Guid.NewGuid().ToString(), i));
				}
				// do something with the list object  
				Console.WriteLine(myList.Count);
				// clear the list and set its reference to null 
				myList.Clear();
			}

			Console.WriteLine();
			Console.WriteLine("#============================================================#");
			Console.WriteLine();

			Console.WriteLine("Exam A_5 : ");
			Console.WriteLine("-----------");
			var publisher = new EventPublisher();
			//remove comment on while for test
			//while (true)
			{
				var subscriber = new EventSubscriber(publisher);
				// do something with the publisher and subscriber objects
				subscriber.Dispose();
			}

			Console.WriteLine();
			Console.WriteLine("#============================================================#");
			Console.WriteLine();

			Console.WriteLine("Exam A_6 : ");
			Console.WriteLine("-----------");
			var rootNode = new TreeNode();
			//remove comment on while for test 
			//while (true)
			{
				// create a new subtree of 10000 nodes 
				var newNode = new TreeNode();
				for (int i = 0; i < 10000; i++)
				{
					var childNode = new TreeNode();
					newNode.AddChild(childNode);
				}
				rootNode.AddChild(newNode);
				// remove the old subtrees to free up memory 
				if (rootNode.Children.Count > 10)
				{
					rootNode.RemoveChildAt(0);
				}
			}

			Console.WriteLine();
			Console.WriteLine("#============================================================#");
			Console.WriteLine();

			Console.WriteLine("Exam A_7 : ");
			Console.WriteLine("-----------");
			for (int i = 0; i < 1000000; i++)
			{
				Cache.Add(i, new object(), TimeSpan.FromMinutes(1));
			}
			Console.WriteLine("Cache populated");
			Console.ReadLine();
		}

	}
}
