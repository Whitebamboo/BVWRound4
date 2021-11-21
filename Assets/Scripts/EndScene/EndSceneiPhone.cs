using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class EndSceneiPhone : MonoBehaviour
{
    public float startTime;
    public bool isFirstTime;
    
    public GameObject LiveVideoObj;
    public GameObject RiceCookerObj;
    public GameObject ReceiveCallObj;
    public bool isFirstTimeGrabiPhone;

    public bool finishedPlaying;

    public bool GripHolding;

    public AudioSource WechatRing;
    public AudioSource ViberateSound;


    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        isFirstTime = true;
        isFirstTimeGrabiPhone = true;
        finishedPlaying = false;
        GripHolding = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time - startTime > 8f) && isFirstTime)
        {
            PhoneViberates();
            isFirstTime = false;
        }
    }

    public void GripHoldOn()
    {
        GripHolding = true;
    }
    
    public void GripHoldOff()
    {
        GripHolding = false;
    }


    public void ShowAround()
    {
        if (isFirstTimeGrabiPhone && finishedPlaying)
        {
            Debug.Log("====Show around====");
            isFirstTimeGrabiPhone = false;
            StartCoroutine(PlayDialog2());
        }
    }

    public void PhoneViberates()
    {
        this.gameObject.GetComponentInChildren<Image>().enabled = true;
        ReceiveCallObj.GetComponent<BoxCollider>().enabled = true;
        //SoundMgr.Instance.PlaySound(8);
        //SoundMgr.Instance.PlaySound(10);
        WechatRing.Play();
        ViberateSound.Play();
    }


    IEnumerator PlayDialog2()
    {
        // FROM "SHOW YOU AROUND" TO "COOK SOME RICE WITH YOUR RICE COOKER"
        yield return new WaitForSeconds(3f);
        float waittime = SoundMgr.Instance.PlayDialogue(2);
        yield return new WaitForSeconds(waittime);
        RiceCookerObj.GetComponent<BoxCollider>().enabled = true;
    }

    IEnumerator FadeoutScene()
    {
        Debug.Log("FADING OUT");
        URPScreenFade.Instance.SceneFadeOut();
        yield return new WaitForSeconds(2f);
    }

   
}
