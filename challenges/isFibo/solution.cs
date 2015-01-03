using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Prlong output to STDOUT. Your class should be named Solution */
        long inputLineCount = long.Parse(Console.ReadLine());
        long[] inputs = new long[inputLineCount];
        for(long i=0;i<inputLineCount;i++){
            inputs[i]=long.Parse(Console.ReadLine());
        }
        foreach(long number in inputs){
            CheckFibo(number);
        }
    }
    static List<long> fibos=new List<long>{0,1};
    static void CheckFibo(long number){
        while(fibos.Max()<number){
            fibos.Add(fibos[fibos.Count-1]+fibos[fibos.Count-2]);
        }
        if(fibos.Contains(number)){
            Console.WriteLine("IsFibo");
        } else {
            Console.WriteLine("IsNotFibo");
        }
        
        
    }
}