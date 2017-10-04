using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {  

    int dummyInt = 0; 
    var newList = new List<int>();
    
    foreach(object o in listOfItems){     
     if(o is int)
      newList.Add((int)o);    
    }                               
                                
    return newList;
      
   }
}
