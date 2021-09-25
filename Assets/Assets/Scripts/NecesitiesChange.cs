using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NecesitiesChange : MonoBehaviour
{
    [SerializeField] Necesities necesities;
    [SerializeField] string foodORenergy;
    [SerializeField] float amount;

    private void Start()
    {
        necesities = necesities.GetComponent<Necesities>();
    }

    public void Changes()
    {
        necesities.ModifyNecesities(foodORenergy, amount);
    }

}
