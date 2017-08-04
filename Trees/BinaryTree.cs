using System;

namespace c_sharp_trees
{
    public class Tree {

        Node root;

        // Empty tree
        public Tree() {
            root = null;
        }

        // Create a tree with a new node assigning the value to that node.
        public Tree(int val) {
            root = new Node(val);
        }

        public void Insert(int val) {
            if (root == null) 
                root = new Node(val);
            else
                root.Insert(val);
        }
}
