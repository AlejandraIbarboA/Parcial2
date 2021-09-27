using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruta : MonoBehaviour, I_Interactable
{
    public void Interactable(Necesities necesities)
    {
        necesities.ModifyNecesities("food", 3);
    }
}
