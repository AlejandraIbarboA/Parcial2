using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chargebar : MonoBehaviour
{
    Scrollbar chargeBar;
    private float timer = 0f;
    private float limit = 2f;

    private void Start()
    {
        chargeBar = GetComponent<Scrollbar>();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        chargeBar.size = (1f / limit) * timer;

        if (timer >= limit)
        {
            timer = 0f;
        }
    }


}
