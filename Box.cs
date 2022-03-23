using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    int boxNumber;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") // filter the objects that collide with the checkpoint. You can assign the tag in the inspector
        {
            PlayerPrefs.SetInt("boxNumber",PlayerPrefs.GetInt("boxNumber")+1);
            boxNumber = PlayerPrefs.GetInt("boxNumber");
            GameObject box = GameObject.Find("Player/Boxes/Box"+boxNumber);
            box.SetActive(true);/*
            var boxCollider = box.GetComponent<BoxCollider>();
            boxCollider.enabled = !boxCollider.enabled;*/
            box.SetActive(true);
            Destroy(gameObject);
        }
    }
}
