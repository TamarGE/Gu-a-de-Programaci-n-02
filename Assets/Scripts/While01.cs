using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 
 * 
*/
public class While01 : MonoBehaviour
{
    int counter = 1;
    int counterMax = 100;
    void Start()
    {
        while (counter < counterMax)
        {
            Debug.Log("Este mensaje se repetirá, está en la vuelta número "+counter);
            counter++;
        }
        Debug.Log("Ternminó el while");
    }

    void Update()
    {
        
    }
}
