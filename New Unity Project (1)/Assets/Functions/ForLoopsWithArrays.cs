using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsWithArrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            print(i);
        }
        for (int i = 0; i <= 10; i = i + 2)
        {
            print(i);
        }
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        foreach (string i in cars)
        {
            print(i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
