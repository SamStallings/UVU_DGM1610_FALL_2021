using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int month = 6;
        switch (month)
        {
            case 1:
                print("January");
                break;
            case 2:
                print("February");
                break;
            case 3:
                print("March");
                break;
            case 4:
                print("April");
                break;
            case 5:
                print("May");
                break;
            case 6:
                print("June");
                break;
            case 7:
                print("July");
                break;
            case 8:
                print("August");
                break;
            case 9:
                print("September");
                break;
            case 10:
                print("October");
                break;
            case 11:
                print("November");
                break;
            case 12:
                print("December");
                break;
        }
        // Outputs "Thursday" (day 4)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
