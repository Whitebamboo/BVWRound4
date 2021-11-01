using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class iPhone : MonoBehaviour
{
    public GameObject BlackObject;
    public bool isBeingCalled;
    public bool haveCalled;
    public float startTime;
    public bool isPressed;
    public bool isFirstTime;

    public GameObject BeingCalledObj;
    public GameObject WechatObject;
    public Animator GrandmaPointing;

    // Start is called before the first frame update
    void Start()
    {
        isBeingCalled = false;
        haveCalled = false;
        isPressed = false;
        isFirstTime = true;
        // 0
        StartCoroutine(PlayDialog1());

    }

    // Update is called once per frame
    void Update()
    {
        if (isBeingCalled)
        {
            startTime = Time.time;
            isBeingCalled = false;
            haveCalled = true;
        }
        if ((Time.time - startTime > 2.5f) && (haveCalled) && (!isPressed) && (isFirstTime)){
            BlackObject.GetComponent<Image>().enabled = false;
            //BeingCalledObj.SetActive(true);
            //BeingCalledObj.GetComponentInChildren<BoxCollider>().enabled = true;
            SoundMgr.Instance.PlaySound(8);
            SoundMgr.Instance.PlaySound(10);
            // <Tempelate usage of Grandma Pointing iPad animation>
            StartCoroutine(GrandmaAnimation());

            isFirstTime = false;
        }
    }

    IEnumerator PlayDialog1()
    {
        float waittime = SoundMgr.Instance.PlayDialogue(4);
        yield return new WaitForSeconds(waittime);
        WechatObject.GetComponent<BoxCollider>().enabled = true;

    }

    IEnumerator GrandmaAnimation()
    {
        yield return new WaitForSeconds(2.5f);
        GrandmaPointing.SetTrigger("ShouldPoint");
    }

}
