using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While02 : MonoBehaviour
{
    public int num1;
    public int num2;
    int counter;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2)
        {
            Debug.Log("Los números son iguales, reintentar");
        }
        else if (num1 > num2)
        {
            if (num1 - num2 == 1)
            {
                Debug.Log("No hay números enteros entre " + num1 + " y " + num2 );
            }
            else
            {
                counter = num2 + 1;
                Debug.Log("Los números entre " + num1 + " y " + num2 + " son:");
                while (num1 > counter && counter > num2)
                {
                    Debug.Log(counter);
                    counter++;
                }
            }
        }
        else if (num1 < num2)
        {
            if (num2 - num1 == 1)
            {
                Debug.Log("No hay números enteros entre " + num1 + " y " + num2 );
            }
            else
            {
                counter = num1 + 1;
                Debug.Log("Los números entre " + num1 + " y " + num2 + " son:");
                while (num2 > counter && counter > num1)
                {
                    Debug.Log(counter);
                    counter++;
                }
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
