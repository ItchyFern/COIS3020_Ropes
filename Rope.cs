using System;

namespace COIS3020_Ropes
{
    class Rope
    {
        //Create an empty rope (1 mark).
        Rope( ) {} 
        
        // Create a balanced rope from a given string S (8 marks).
        Rope(string S) {}

        // Return the concatenation of ropes R1 and R2 (4 marks).
        Rope Concatenate(Rope R1, Rope R2) {return null;} 

        // Return the two ropes split at index i (10 marks).
        void Split(int i, Rope R1, Rope R2) {} 

        // Insert string S at index i (6 marks).
        void Insert(string S, int i) {} 

        // Delete the substring S[i, j] (6 marks).
        void Delete(int i, int j) {} 

        // Return the substring S[i, j] (8marks).
        string Substring(int i, int j) {return "";} 

        // Return the character at index i (4 marks).
        char CharAt(int i) {return 's';} 

        //Return the index of the first occurrence of character c (4 marks).

        int IndexOf(char c) {return -1;} 

        // Reverse the string represented by the current rope (6 marks).
        void Reverse() {} 

        // Return the length of the string (1 mark).
        int Length() {return -1;} 

        // Return the string represented by the current rope (4 marks).
        public override string ToString() {return "";} 

        // Print the augmented binary tree of the current rope (4 marks).
        void PrintRope() {} 
    }
}