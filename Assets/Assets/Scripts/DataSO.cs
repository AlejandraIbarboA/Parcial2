using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObjects/DataSO")]
public class DataSO : ScriptableObject
{
    public event UnityAction OnValueChanged;

    public void OnValueChange()
    {
        OnValueChanged?.Invoke();
    }
}
