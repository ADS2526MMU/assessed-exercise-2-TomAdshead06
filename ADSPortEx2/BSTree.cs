using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx2
{
    //Binary Search Tree implementation for Assessed Exercise 2

    //Hints : 
    //Use lecture materials from Week 5
    // and lab sheet 'Lab 5: BinTree and BSTree' to aid with implementation.

    class BSTree<T> : BinTree<T> where T : IComparable
    {
        public BSTree()
        {
            root = null;
        }

        //Functions for EX.2A
        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item);
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }
            else if(item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }
        }

        public int Height()
        {
            return height(ref root);
        }

        public int height(ref Node<T> nodes)
        {
            if (nodes == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(height(ref nodes.Left), height(ref nodes.Right));
            }
        }

        public T EarliestGame()
        {
            throw new NotImplementedException();
        }

        public T earliestGame(ref Node<T> nodes, List<T> years)
        {
            throw new NotImplementedException();
        }

        //Functions for EX.2B
        public int Count()
        {
            return count(ref root);
        }

        public int count(ref Node<T> nodes)
        {
            if (nodes == null)
            {
                return 0;
            }
            else
            {
                return 1 + height(ref nodes.Left) + height(ref nodes.Right);
            }
        }

        public void Update(T item)
        {
            update(item, ref root);
        }

        public void update(T item, ref Node<T> nodes)
        {
            if (item.CompareTo(nodes.Data) < 0)
            {
                update(item, ref nodes.Left);
            }
            else if (item.CompareTo(nodes.Data) > 0)
            {
                update(item, ref nodes.Right);
            }
            else if (item.CompareTo(nodes.Data) == 0)
            {
                VideoGame game = nodes.Data as VideoGame;
                Console.WriteLine("Enter a new name");
                string newName = Console.ReadLine();
                game.gameTitle = newName;
            }

        }

        //Free space, use as necessary to address task requirements... 


    }// End of class
}
