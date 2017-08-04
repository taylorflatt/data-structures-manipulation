using System;
using System.Collections.Generic;

namespace c_sharp_trees
{
    public class Node {

        public int data;
        public Node left;
        public Node right;

        // When a node/tree is initially created, it is never attached to anything. Thus, the left and right
        // are null.
        public Node(int val) {
            data = val;
            left = null;
            right = null;
        }
}
