using System;
using System.Collections.Generic;


namespace PrimeNumbers
{
  public class Program
  {

    public static void Main()
    {
      Console.WriteLine("Please input a number that you want to find all the primes below that number");
      string InputNumber = Console.ReadLine();
      int GivenNumber = int.Parse(InputNumber);
      List<int> ReducingList = new List<int>(0);
      for (int i=1; i<GivenNumber+1; i=i+1)
      {
        ReducingList.Add(i);
      }
      for (int i=1; i<ReducingList.Count; i=i+1)
      {
        for (int j=i+1; j<ReducingList.Count; j=j+1)
        {
          
          if ((ReducingList[j]%ReducingList[i])==0 && (ReducingList[i] != 1) && (ReducingList[j]!=1))
          {
            ReducingList[j] =1;
          }
        }
      }
        List<int> AnotherList = new List<int>(0);
        for(int l=0; l<ReducingList.Count; l=l+1)
        {
          if (ReducingList[l]!=1)
          {
            AnotherList.Add(ReducingList[l]);
          }
        }
      
      foreach(int Prime in AnotherList)
      {
        Console.WriteLine(Prime);
      }
    }
  }
}


