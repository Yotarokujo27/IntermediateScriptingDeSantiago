using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClassExample : MonoBehaviour
{
    private void Start()
    {
        GenericClass<int> myClass1 = new GenericClass<int>();

        myClass1.UpdateItem(5);
    }
}
