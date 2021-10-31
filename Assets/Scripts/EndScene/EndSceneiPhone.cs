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
    


    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        isFirstTime = true;
        isFirstTimeGrabiPhone = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time - startTime > 5f) && isFirstTime)
        {
            PhoneViberates();
            isFirstTime = false;
        }
    }

    public void ShowAround()
    {
        if (isFirstTimeGrabiPhone)
        {
            
            isFirstTimeGrabiPhone = false;
            StartCoroutine(PlayDialog2());
        }
    }

    public void PhoneViberates()
    {
        this.gameObject.GetComponentInChildren<Image>().enabled = true;
        ReceiveCallObj.GetComponent<BoxCollider>().enabled = true;
        SoundMgr.Instance.PlaySound(8);
        SoundMgr.Instance.PlaySound(10);
    }


    IEnumerator PlayDialog2()
    {
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
