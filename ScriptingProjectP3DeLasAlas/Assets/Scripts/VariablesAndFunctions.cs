using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    public int myInt = 5;
    void Start()
    {
       myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

  
   
    void Update()
    {
        
    }

    int MultiplyByTwo(int num)
    {
        int result;
        result = num * 2;
        return result;
    }

}

