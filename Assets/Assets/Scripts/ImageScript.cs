using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    [SerializeField] Image imageFood;
    [SerializeField] Sprite icon;
    [SerializeField] DataSO channel;

    private void OnEnable()
    {
        channel.OnValueChanged += UpdateImage;
    }

    private void OnDisable()
    {
        channel.OnValueChanged -= UpdateImage;
    }

    void UpdateImage()
    {
        imageFood.sprite = icon;
    }
}
