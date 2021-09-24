using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFood : MonoBehaviour
{
    [SerializeField] Image imageFood;
    [SerializeField] Sprite foodIcon;
    [SerializeField] DataSO channel;
    
    private void OnEnable()
    {
        channel.OnValueChanged += UpdateImage; 
    }
    private void OnDisable()
    {
        channel.OnValueChanged -= UpdateImage;

    }
    void UpdateImage(int value)
    {
        if(value>=1)
        {
            imageFood.sprite = foodIcon;
        }
        //imageFood.sprite = null;

    }
}
