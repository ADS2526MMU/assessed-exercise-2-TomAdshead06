using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
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

        int treeSize = 0;

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
                treeSize++;
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
            throw new NotImplementedException();
        }

        public T EarliestGame()
        {
            throw new NotImplementedException();
        }

        //Functions for EX.2B

        public int Count()
        {
            return treeSize;
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }

        //Free space, use as necessary to address task requirements... 


    }// End of class
}
