using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int inputLineCount = int.Parse(Console.ReadLine());
        int[] inputs = new int[inputLineCount];
        for(int i=0;i<inputLineCount;i++){
            inputs[i]=int.Parse(Console.ReadLine());
        }
        foreach(int number in inputs){
            int divisorCount = 0;
            foreach(char c in number.ToString()){
                int digit = c - '0';
                if (digit!=0 && number % digit==0){
                    divisorCount++;
                }
            }
            Console.WriteLine(divisorCount);
        }
    }
}