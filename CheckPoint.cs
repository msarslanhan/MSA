using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public CharacterController characterController;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") // filter the objects that collide with the checkpoint. You can assign the tag in the inspector
        {
            PlayerPrefs.SetInt("CanRun",0);
            characterController.GameEnd();
        }
    }
}
