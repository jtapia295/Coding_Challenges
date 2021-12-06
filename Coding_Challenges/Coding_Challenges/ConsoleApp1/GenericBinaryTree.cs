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
            Node<T> currentNode = this;
            Node<T> nodeInsert = new Node<T>(data);

            int compare = nodeInsert.Data.CompareTo(currentNode.Data);
            bool operation = true;
            while (operation)
            {
                if (currentNode.Left != null && compare == -1)
                {
                    currentNode = currentNode.Left;
                }
                else if(currentNode.Left == null && compare == -1)
                {
                    currentNode.Left = nodeInsert;
                    Console.WriteLine($"Node inserted to the left of {currentNode.Data}");
                    operation = false;
                }

                if (currentNode.Right != null && compare == 1)
                {
                    currentNode = currentNode.Right;
                }
                else if (currentNode.Right == null && compare == 1)
                {
                    currentNode.Right = nodeInsert;
                    Console.WriteLine($"Node inserted to the right of {currentNode.Data}");
                    operation = false;
                }
            }
            // TODO - add code here to implement inserting new data into tree
        }




        public IEnumerable<T> GetTreeData()
        {
            var nodes = new List<T>();
            var currentNode = this;
            nodes.Add(currentNode.Data);
            if (currentNode.Left != null)
            {
                currentNode = currentNode.Left;
                nodes = (List<T>)currentNode.GetTreeData();
            }
            if (currentNode.Right != null)
            {
                currentNode = currentNode.Left;
                nodes = (List<T>)currentNode.GetTreeData();
            }
            nodes.Sort();
            // TODO - add code here to return an enumerable collection of tree
            // objects (of type 'T') in ascending order

            return nodes;
        }
    }
}
