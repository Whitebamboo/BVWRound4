using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Video;

public class EndSceneReceiveCall : MonoBehaviour
{

    public bool HaveClicked;
    public GameObject iPhoneObj;
    public GameObject LiveVideoObj;

    public Material iPhoneScreenMaterial;

    public VideoPlayer VideoObj;


    // AWAITING NEW ART ASSET
    //public Sprite GrandmaNewSprite;
    public GameObject SmallGrandmaObj;
    // Start is called before the first frame update
    void Start()
    {
        HaveClicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // ========== This is used for clicking call button on iPhone.=========
        if (other.gameObject.tag == "Hand" && !HaveClicked)
        {
            SoundMgr.Instance.PlaySound(9);
            VideoObj.Play();
            iPhoneObj.GetComponent<EndSceneiPhone>().WechatRing.Stop();
            iPhoneObj.GetComponent<EndSceneiPhone>().ViberateSound.Stop();
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            HaveClicked = true;

            iPhoneObj.GetComponentInChildren<Image>().enabled = false;
            StartCoroutine(PlayDialog());

            LiveVideoObj.SetActive(true);
             
            iPhoneObj.GetComponent<XRGrabInteractable>().enabled = true;
            

        }
        //StartCoroutine(FadeoutScene());
    }

    IEnumerator PlayDialog()
    {
        yield return new WaitForSeconds(0.8f);

        float waittime = SoundMgr.Instance.PlayDialogue(4);
        yield return new WaitForSeconds(waittime);
        iPhoneObj.GetComponentInChildren<Image>().enabled = false;

        // ACTIVATE LIVE VIDEO OBJECT;
        
        SmallGrandmaObj.GetComponent<Image>().enabled = true;
        iPhoneObj.GetComponent<EndSceneiPhone>().finishedPlaying = true;

        LiveVideoObj.GetComponent<MeshRenderer>().material = iPhoneScreenMaterial;

        if (iPhoneObj.GetComponent<EndSceneiPhone>().GripHolding)
        {
            iPhoneObj.GetComponent<EndSceneiPhone>().ShowAround();
        }

    }
}
