using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Almohada : MonoBehaviour, I_Interactable
{
    public void Interactable(Necesities necesities)
    {
        necesities.ModifyNecesities("energy", 2);
    }
}
