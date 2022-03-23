using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject Box1,Box2,Box3,Box4,Box5,Box6,Box7,Box8;
    public int Hiz;
    public Animator animasyonOynatici;
    public Animator BoxAnim, truck;
    float yatay;
    void Start()
    {
        PlayerPrefs.SetInt("CanRun",0);
        PlayerPrefs.SetInt("boxNumber",0);
    }
    void Update()
    {
        if(PlayerPrefs.GetInt("CanRun")==1)
        {
            yatay = Input.GetAxis("Horizontal");
            BoxAnimasyon();
            transform.position -= new Vector3(yatay*Hiz*Time.deltaTime,0,0);
            Run();
            animasyonOynatici.SetBool("IsRun",true);
        }else
        {
            animasyonOynatici.SetBool("IsRun",false);
        }
    }
    void Run()
    {
        transform.position -= new Vector3(0,0,Hiz*Time.deltaTime);
    }
    public void GameEnd()
    {
        BoxAnim.SetBool("gameEnd",true);
        animasyonOynatici.SetBool("IsGameEnd",true);
        int kickTime = PlayerPrefs.GetInt("boxNumber");
        kickAnimationController(kickTime);
    }
    void kickAnimationController(int kickTime)
    {
        if(kickTime ==1)
        {
            Invoke("KickEnder",1.8f);
        }
        else if(kickTime ==2)
        {
            Invoke("KickEnder",3.2f);
        }
        else if(kickTime ==3)
        {
            Invoke("KickEnder",4.4f);
        }
        else if(kickTime ==4)
        {
            Invoke("KickEnder",6f);
        }
        else if(kickTime ==5)
        {
            Invoke("KickEnder",7.6f);
        }
        else if(kickTime ==6)
        {
            Invoke("KickEnder",9.1f);
        }
        else if(kickTime ==7)
        {
            Invoke("KickEnder",10.5f);
        }
        else if(kickTime ==8)
        {
            Invoke("KickEnder",11.9f);
        }
    }
    void KickEnder()
    {
        animasyonOynatici.SetBool("EndKick",true);
        truck.SetBool("closeDoor",true);

    }
    void BoxAnimasyon()
    {
        if(yatay>0.5f)
        {
            BoxAnim.SetBool("moveleft3",true);
            Invoke("noMove",0.5f);
        }
        else if(yatay>0.33f)
        {
            BoxAnim.SetBool("moveleft2",true);
            Invoke("noMove",0.33f);
        }
        else if(yatay>0f)
        {
            BoxAnim.SetBool("moveleft",true);
            Invoke("noMove",0.02f);
        }
        else if(yatay<-0.5f)
        {
            BoxAnim.SetBool("moveright3",true);
            Invoke("noMove",0.5f);
        }
        else if(yatay<-033f)
        {
            BoxAnim.SetBool("moveright2",true);
            Invoke("noMove",0.33f);
        }
        else if(yatay<0f)
        {
            BoxAnim.SetBool("moveright",true);
            Invoke("noMove",0.02f);
        }
        else if(yatay==0)
        {
            Invoke("noMove",0.2f);
        }
    }
    void noMove()
    {
        BoxAnim.SetBool("moveleft",false);
        BoxAnim.SetBool("moveright",false);
        BoxAnim.SetBool("moveleft2",false);
        BoxAnim.SetBool("moveright2",false);
        BoxAnim.SetBool("moveleft3",false);
        BoxAnim.SetBool("moveright3",false);
        BoxAnim.SetBool("noMove",true);
        yatay=0f;
    }
}
