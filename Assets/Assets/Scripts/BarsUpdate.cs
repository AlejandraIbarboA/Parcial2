using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarsUpdate : MonoBehaviour
{
    [SerializeField] Scrollbar barFood;
    [SerializeField] Scrollbar barEnergy;
    private Necesities necesities;

    void Start()
    {
        necesities = GetComponent<Necesities>();
    }

    void Update()
    {
        barFood.size = (1f / necesities.foodCapacity) * necesities.foodActual;
        barEnergy.size = (1f / necesities.energyCapacity) * necesities.energyActual;
    }
}
