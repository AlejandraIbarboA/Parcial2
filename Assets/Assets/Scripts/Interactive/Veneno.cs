using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veneno : MonoBehaviour, I_Interactable
{
    public void Interactable(Necesities necesities)
    {
        necesities.ModifyNecesities("food", -2);
        necesities.ModifyNecesities("energy", -2);
    }
}
