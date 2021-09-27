using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionInteraccion : MonoBehaviour
{
    Necesities necesities;
    I_Interactable interact;

    void Start()
    {
        necesities = GetComponent<Necesities>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("interact"))
        {
            I_Interactable interactive = other.GetComponent<I_Interactable>();
            interactive.Interactable(necesities);
        }
    }
}
