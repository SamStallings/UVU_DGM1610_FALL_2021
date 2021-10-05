using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        while (i < 5)
        {
            print(i);
            i++;
        }
        do
        {
            print("Hello world");
            i++;
        }
        while (i < 10);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
