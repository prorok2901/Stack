using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<int> stack = new Stack<int>();
			stack.Push(10);
			stack.Push(12);
			stack.Push(1021);
			stack.Push(122);
			stack.Push(101);
			stack.Push(12);
			Console.WriteLine("Вывод 1-го элемента");
			var stackElement = stack.Top();
			Console.ReadKey();
		}
	}
	class Stack<T>
	{
		int count; //размер
		Node<T> myNode;		
		
		public void Push(T element)//добавление элемента
		{
			var newnode = new Node<T>(element);
			newnode.Next = myNode;
			myNode = newnode;
			count++;
		}
		public void Pop ()//удаление элемента 
		{
			myNode = myNode.Next;

			count--;
		}
		public Node<T> Top () //вывод последнего элемента
		{
			return myNode;
		}
		public bool IsEmpty()//пуст ли стек?
		{
			return count == 0;
		}
	
	}
	class Node<T>
	{
		public Node(T data)
		{
			Data = data;
		}
		public T Data;
		public Node<T> Next;
	}
}
