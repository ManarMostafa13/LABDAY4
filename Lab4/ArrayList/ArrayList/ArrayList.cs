using System.Collections;
using System.ComponentModel.DataAnnotations;
using System;
public class ArrayList : IEnumerable
{ 
    private object[] List;
    private int count;

    public int capacity
    {
        
        get { return List.Length; } 
    }

    public int Count 
    { get => count; set => count = value; }

    public ArrayList(int length=1)
    {
        count = 0;

        List = new object[length];
    }

    public void Add(object item) 
    { 
     if (count== List.Length)
        {
            Array.Resize(ref List, List.Length*2);
        }
        List[count++] = item;
    }

    public IEnumerator GetEnumerator() 
    {
        for (int i = 0;i<count;i++)
        {
          yield return List[i];   
        }

    }

    public object this[int index]
    { get { return List[index]; }
        set { List[index] = value; }
      
    }


    public void Trimitem()

    {
        object[] temp = new object[count];
        Array.Copy(List, temp, count);
        List = temp;
    }


    public void RemoveAt(int index) {
      for(int i = 0;i<count;i++)
        {
            if (i == index)
            {
                List[i] = List[i+1];
               
            }
        }

        List[count - 1] = null;
        count = count - 1;

    }
    //public class Enumer : IEnumerator
    //{
    //    ArrayList list;
    //    private int index = -1;

    //    public Enumer(ArrayList array)
    //    { this.list = array; }

    //    public object Current
    //    {

    //        get {return list.List[index]; }
    //    }

    //    public bool MoveNext()
    //    {
    //        index++;
    //        return index<list.Count;
    //    }

    //    public void Reset()
    //    {
    //        list.count=0;
    //    }
    //}


}

