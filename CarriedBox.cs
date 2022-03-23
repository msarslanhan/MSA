using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarriedBox : MonoBehaviour
{
    public GameObject brokingbox;
    void OnTriggerEnter(Collider other)
    {
        print("çalıştı");
        if(other.tag == "Obstacle") // filter the objects that collide with the checkpoint. You can assign the tag in the inspector
        {
            PlayerPrefs.SetInt("boxNumber",PlayerPrefs.GetInt("boxNumber")-1);
            Instantiate(brokingbox,transform.position,Quaternion.identity);
            print("kırıldı");
            gameObject.SetActive(false);
        }
    }
}
