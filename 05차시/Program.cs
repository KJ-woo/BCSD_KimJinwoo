using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Node<T>
{
    Node<T> Next;
    Node<T> Prev;
}

class MyLinkList<T>
{
    public Node <T> First;
    public Node<T> Last;
}
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> LList = new LinkedList<int>();
            LList.AddFirst(10);
            LList.AddFirst(20);
            LList.AddFirst(33);

            LinkedListNode<int> Cur = LList.First;

            Cur = Cur.Next;

            LList.AddAfter(Cur, 33);
            LList.Remove(10);
            LList.RemoveFirst();
            LList.RemoveLast();
            for (LinkedListNode<int> StartNode = LList.First;
                StartNode != null; StartNode = StartNode.Next){
                Console.WriteLine(StartNode.Value);
            }

            for (LinkedListNode<int> StartNode = LList.Last;
            StartNode != null; StartNode = StartNode.Previous){
                Console.WriteLine(StartNode.Value);
            }
            LList.Clear();//전부삭제
        }
    }
}
