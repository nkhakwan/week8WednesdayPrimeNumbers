using System;
using System.Collections.Generic;


namespace PrimeNumbers
{
  public class Program
  {

    public static void Main()
    {
      int GivenNumber = 100;
      List<int> ReducingList = new List<int>(0);
      for (int i=2; i<GivenNumber; i=i+1)
      {
        ReducingList.Add(i);
      }

      for (int i=2; i<GivenNumber; i=i+1)
      {
        for (int j=i+1; j<GivenNumber; j=i+1)
        {
          if ((ReducingList(j)%i))
          {
            ReducingList[j] = 0;
          }
          
        }
        for(int l=0; l<ReducingList.length; l=l+1)
        {
          if (ReducingList[l] == 0)
          {
            ReducingList.Remove[l];
          }
        }
      }
    }
  }
}


