using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoopsWithArrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        for (int i = 0; i < cars.Length; i++)
        {
            print(cars[i]);
        }
        string[] cars_2 = { "Volvo", "BMW", "Ford", "Mazda" };
        foreach (string i in cars_2)
        {
            print(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
