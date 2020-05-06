int GivenNumber = 100;
List<int> ReducingList = new List<int>(0);
for (int i=2; i<GivenNumber; i=i+1)
{
  ReducingList.Add(i);
}

for (int i=2; i<GivenNumber; i=i+1)
{
  for (j=i; j<GivenNumber; j=i+1)
  {
    if (!(ReducingList(j)%i))
    {
      ReducingList.Remove(j);
    }
  }
  
}


