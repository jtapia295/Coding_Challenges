using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenges
{
    public class Node<T> where T : IComparable
    {
        public Node(T data)
        {
            Data = data;
        }

        // TODO - implement the following properties (they should be readonly)
        public Node<T> Left { get; private set; }
        public Node<T> Right { get; private set; }
        readonly T Data;

        public void Insert(T data)
        {
            //My Solution
            //------------------------
            //var parentNode = this;
            //Node<T> currentNode = this;
            //Node<T> nodeInsert = new Node<T>(data);
            //int compare = nodeInsert.Data.CompareTo(currentNode.Data);
            //if (compare == -1)
            //{
            //    if (currentNode.Left != null)
            //    {
            //        currentNode = currentNode.Left;
            //        currentNode.Insert(nodeInsert.Data);
            //    }
            //    else if (currentNode.Left == null)
            //    {
            //        currentNode.Left = nodeInsert;
            //        Console.WriteLine($"Node {currentNode.Left.Data} inserted to the left of {currentNode.Data}");
            //    }
            //}
            //currentNode = parentNode;
            //if (compare == 1)
            //{
            //    if (currentNode.Right != null)
            //    {
            //        currentNode = currentNode.Right;
            //        currentNode.Insert(nodeInsert.Data);
            //    }
            //    else if (currentNode.Right == null)
            //    {
            //        currentNode.Right = nodeInsert;
            //        Console.WriteLine($"Node {currentNode.Right.Data} inserted to the right of {currentNode.Data}");
            //    }

            //Optimal Solution
            //--------------------------------
            if (data.CompareTo(Data) < 0)
            {
                //Add to left
                if (Left == null)
                    Left = new Node<T>(data);
                else
                    Left.Insert(data);
            }
            else
            {
                //Add to right
                if (Right == null)
                    Right = new Node<T>(data);
                else
                    Right.Insert(data);
            }
        }
    



         public static List<T> nodes = new List<T>();
         
        public IEnumerable<T> GetTreeData()
        {
            var parentNode = this;
            var currentNode = this;
            nodes.Add(currentNode.Data);

            if (currentNode.Left != null)
            {
                currentNode = currentNode.Left;
                currentNode.GetTreeData();
            }
            currentNode = parentNode;
            if (currentNode.Right != null)
            {
                currentNode = currentNode.Right;
                currentNode.GetTreeData();
            }
            nodes.Sort();
            // TODO - add code here to return an enumerable collection of tree
            // objects (of type 'T') in ascending order
            return nodes;
        }
    }
}
