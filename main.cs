using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) 
  {
    var list = new List<int>();
    for(var i = 0; i <= 10; i+=2)
        {
            list.Add(i);
        }
    for(var i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    Console.ReadLine();
  }
}
