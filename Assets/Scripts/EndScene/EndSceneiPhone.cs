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
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        isFirstTime = true;
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

    public void PhoneViberates()
    {
        this.gameObject.GetComponentInChildren<Image>().enabled = true;
        SoundMgr.Instance.PlaySound(8);
        SoundMgr.Instance.PlaySound(10);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");

        // !!!!!!! TODO: Replaced with dialogue later.
        SoundMgr.Instance.PlaySound(0);
        this.gameObject.GetComponentInChildren<Image>().enabled = false;
        LiveVideoObj.SetActive(true);
        this.gameObject.GetComponent<XRGrabInteractable>().enabled = true;

        


        //StartCoroutine(FadeoutScene());
    }
    IEnumerator FadeoutScene()
    {
        Debug.Log("FADING OUT");
        URPScreenFade.Instance.SceneFadeOut();
        yield return new WaitForSeconds(2f);
    }
}
