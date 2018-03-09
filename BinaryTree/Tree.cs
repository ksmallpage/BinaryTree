using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Tree
    {
        // variable
        Node topOfTree = null;

        // constructor

        public Tree(int initial)
        {

            topOfTree = new Node(initial);
        }
        // Methods

        public void Add(int value)
        {
            if (topOfTree == null)
            {
                Node newNode = new Node(value);
                topOfTree = newNode;
                return;
            }
            Node currentNode = topOfTree; // sets the current node to the top Node
            bool nodeAdded = false;
            do
            {
                if (value < currentNode.value)
                {
                    // Go Left
                    // if left = null then create Node
                    if (currentNode.left == null)
                    {
                        Node newNode = new Node(value);
                        currentNode.left = newNode;
                        Console.WriteLine("Left");
                        nodeAdded = true;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                        
                    }

                }
                else if (value > currentNode.value) {                    
                    // go right
                    if (currentNode.right == null)
                    {
                        Node newNode = new BinaryTree.Node(value);
                        currentNode.right = newNode;
                        Console.WriteLine("Right");
                        nodeAdded = true;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                       
                    }                    

                }
                else
                {
                    Console.WriteLine("Node already exists");
                }
            } while (!nodeAdded);
        }



        public void Find(int value)
        {
            Node currentnode = topOfTree;
            bool foundValue = false;
            while (!foundValue)
            {
                if (currentnode.value == value)
                {

                    Console.WriteLine("We have found the value " + currentnode.value);
                    foundValue = true;
                }
                if (value < currentnode.value)
                {
                    currentnode = currentnode.left;
                    Console.WriteLine("Left");
                    if (value == currentnode.value)
                    {
                        Console.WriteLine("we found the value");
                        foundValue = true;
                        break;
                    }
                    else
                    {
                        currentnode = currentnode.right;
                        Console.WriteLine("Right");
                        if (value == currentnode.value)
                        {
                            Console.WriteLine("we found the value");
                            foundValue = true;
                            break;
                        }
                        


                    }
                }
            }
        }
    }
}
   
               
            

       
       

   
  