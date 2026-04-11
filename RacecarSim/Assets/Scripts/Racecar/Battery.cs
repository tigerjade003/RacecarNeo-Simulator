using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using UnityEngine;

///<Summary>
/// Simulates the battery of the racecar.
///</Summary>
public class Battery : MonoBehaviour
{
    /// <Summary>
    /// The current charge of the battery.
    /// </Summary>
    public float charge = 100f;

    /// <Summary>
    /// The message to display when the battery runs out.
    /// </Summary>
    public const string outOfBatteryMessage = "Your car's battery has run out! Please reset the car to continue.";

    /// <Summary>
    /// Consume a certain amount of battery charge.
    /// </Summary>
    /// <param name="amount">The amount of battery charge to consume.</param>
    public void Consume(float amount)
    {
        charge -= amount;
        if (charge < 0)
        {
            charge = 0;
        }
        // UnityEngine.Debug.Log($"Battery charge: {charge}%");
    }

    /// <Summary>
    /// Reset the battery charge to 100%.
    /// </Summary>
    public void Reset()
    {
        charge = 100f;
    }
}
