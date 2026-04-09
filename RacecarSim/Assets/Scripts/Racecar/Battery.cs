using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using UnityEngine;

///<Summary>
/// Simulates the battery of the racecar.
///</Summary>
public class Battery : MonoBehaviour
{   
    public float charge = 100f;
    public const string outOfBatteryMessage = "Your Car's Battery has run out! Please reset the car to continue.";
    public void Consume(float amount)
    {
        charge -= amount;
        if (charge < 0)
        {
            charge = 0;
        }
        // UnityEngine.Debug.Log($"Battery charge: {charge}%");
    }
    public void Reset()
    {
        charge = 100f;
    }

}
