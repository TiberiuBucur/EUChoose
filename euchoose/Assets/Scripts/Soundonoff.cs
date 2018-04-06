using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Soundonoff : MonoBehaviour
{
    public GameObject buton,audioSource;
    public void OnClick()
    {
        if (audioSource.activeSelf == true)
        {
            buton.GetComponentInChildren<Text>().text = "Sound off";
            audioSource.SetActive(false);
        }
        else
        {
            buton.GetComponentInChildren<Text>().text = "Sound on";
            audioSource.SetActive(true);
        }
    }
}
