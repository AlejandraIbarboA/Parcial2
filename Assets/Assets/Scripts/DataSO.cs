using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObjects/DataSO")]
public class DataSO : ScriptableObject
{
    [SerializeField] int value = 0;
    public event UnityAction<int> OnValueChanged;

    public void OnValueChange()
    {
        value++;
        OnValueChanged?.Invoke(value);
    }
}
