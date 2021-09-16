using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStates : MonoBehaviour
{
    float porridgeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        porridgeTemperature -= Time.deltaTime * 5f;
    }


    void TemperatureTest()
    {
        // If the Porridge's temperature is greater than the hottest eating temperature...
        if (porridgeTemperature > hotLimitTemperature)
        {
            // ... do this.
            print("Porridge is too hot.");
        }
        // If it isn't, but the porridge temperature is less than the coldest eating temperature...
        else if (porridgeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("Porridge is too cold.");
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            print("Porridge is just right.");
        }
    }
}
