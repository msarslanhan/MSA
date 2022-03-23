using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject StartUI;
    public void PlayButton()
    {
        PlayerPrefs.SetInt("CanRun",1);
        StartUI.SetActive(false);
    }
}
