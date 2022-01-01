using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class SearchTree<T> where T : IComparable<T>
    {
        public T nodeData { get; set; }
        public SearchTree<T> leftTree { get; set; }

        public SearchTree<T> rightTree { get; set; }

        public SearchTree(T data)
        {
            this.nodeData = data;
            this.leftTree = null;
            this.rightTree = null;
        }
        int leftCount = 0, rightCount = 0;
        private bool result;

        public void Insert(T item)
        {
            T NodeVal = this.nodeData;
            if ((NodeVal.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new SearchTree<T>(item);
                }
                else
                {
                    this.leftTree.Insert(item);
                }
            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new SearchTree<T>(item);
                }
                else
                {
                    this.rightTree.Insert(item);
                }
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size of Tree " + " " + (1 + this.leftCount + this.rightCount));
        }
        public bool IfExists(T element, SearchTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.nodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST " + " " + node.nodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in BST ", node.nodeData);
            }
            if (element.CompareTo(node.nodeData) < 0)
            {
                IfExists(element, node.leftTree);
            }
            if (element.CompareTo(node.nodeData) > 0)
            {
                IfExists(element, node.rightTree);
            }

            return result;
        }
            public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.nodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }

    }
}