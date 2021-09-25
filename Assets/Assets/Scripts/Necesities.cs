using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Necesities : MonoBehaviour
{
    public float foodActual = 0f;
    public float energyActual = 0f;

    public float foodCapacity = 10f;
    public float energyCapacity = 10f;

    public void ModifyNecesities(string foodORenergy, float value)
    {
        try
        {

            if (foodORenergy == "food")
            {
                foodActual += value;
            }
            if (foodORenergy == "energy")
            {
                energyActual += value;
            }
        }
        catch
        {
            Debug.Log("cagaste");
        }
    }

    private void Update()
    {
        if (foodActual >= foodCapacity)
        {
            foodActual = foodCapacity;
        }
        if (energyActual >= energyCapacity)
        {
            energyActual = energyCapacity;
        }
    }
}
