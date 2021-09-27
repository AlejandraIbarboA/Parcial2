using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject objectToSpawn;

    public void Spawn()
    {
        objectToSpawn.SetActive(true);
    }

}
