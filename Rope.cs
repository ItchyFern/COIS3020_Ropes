using System;

namespace COIS3020_Ropes
{
    class Rope
    {
        private RopeNode root;

        public RopeNode Root {
            get {return this.root;}
            set {this.root = value;}
        }
        //Create an empty rope (1 mark).
        public Rope( ) {
            this.root = new RopeNode();
        } 
        
        // Create a balanced rope from a given string S (8 marks).
        public Rope(string S) {}

        // Return the concatenation of ropes R1 and R2 (4 marks).
        public Rope Concatenate(Rope R1, Rope R2) {
            // build a new rope r to return
            Rope r = new Rope();
            // build a new rope node n to set as the new rope's root
            // set the new rope node's weight to the length of R1, the left rope
            RopeNode n = new RopeNode(R1.Length());
            // set the left leaf to rope R1 root
            n.Left = R1.Root;
            // set the right leaf to rope R2 root
            n.Right = R2.Root;
            // set root of rope r to n rope node 
            r.Root = n;
            // return new rope r
            return r;
        } 

        // Return the two ropes split at index i (10 marks).
        public void Split(int i, Rope R1, Rope R2) {} 

        // Insert string S at index i (6 marks).
        public void Insert(string S, int i) {
            // build two new empty Ropes to hold the split Rope left and right
            Rope leftRope = new Rope();
            Rope rightRope = new Rope();
            // split and fill the ropes
            Split(i, leftRope, rightRope);
            // build a new rope with the string
            Rope middleRope = new Rope(S);
            // build a new temp rope to hold the left and middle concatenated rope
            Rope temp = Concatenate(leftRope, middleRope);
            // set the root of this rope to the root of the new concatenated rope root
            // from the concatenation of the temp (left and middle) rope with the right rope
            Root = Concatenate(temp, rightRope).Root;
        } 

        // Delete the substring S[i, j] (6 marks).
        public void Delete(int i, int j) {
            // check to make sure that j > i
            if (j <= i) {return;}
            // build new ropes for splitting. right will hold right side of final rope
            Rope rightRope = new Rope();
            // temp will be split again to get the left side of the rope
            Rope temp = new Rope();
            // split the rope at j
            Split(j, temp, rightRope);
            // build a new rope that will hold the left side of the tree
            Rope leftRope = new Rope();
            // split temp, right side of the tree will be deleted so rope doesn't need
            // to be saved. 
            temp.Split(i, leftRope, new Rope());
            // set this root to the root of the concatenated tree from the new left and 
            // right ropes
            this.Root = Concatenate(leftRope, rightRope).Root;
        } 

        // Return the substring S[i, j] (8marks).
        public string Substring(int i, int j) {return "";} 

        // Return the character at index i (4 marks).
        public char CharAt(int i) {
            RopeNode n = root;
            while (n.Value != null){
                // if the weight of the node is less than i, 
                // subtract weight from i and go right (if node exists)
                if (n.Weight < i && n.Right != null){
                    n = n.Right;
                    i -= n.Weight;
                }
                // if the weight of the node is greater than or equal to i, 
                // go left (if node exists)
                else if (n.Left != null)
                {
                    n = n.Left;
                }
            }
            return n.Value[i - 1];
        } 

        //Return the index of the first occurrence of character c (4 marks).

        public int IndexOf(char c) {return -1;} 

        // Reverse the string represented by the current rope (6 marks).
        public void Reverse() {} 

        // Return the length of the string (1 mark).
        public int Length() {return -1;} 

        // Return the string represented by the current rope (4 marks).
        public override string ToString() {return "";} 

        // Print the augmented binary tree of the current rope (4 marks).
        public void PrintRope() {} 
    }
}