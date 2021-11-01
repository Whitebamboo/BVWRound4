using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class EndSceneReceiveCall : MonoBehaviour
{

    public bool HaveClicked;
    public GameObject iPhoneObj;
    public GameObject LiveVideoObj;

    //AWAITING NEW ART ASSET
    public Sprite GrandmaNewSprite;
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
            //Debug.Log("============Received clic=========");
            HaveClicked = true;
            //Debug.Log("Triggered");
            iPhoneObj.GetComponentInChildren<Image>().sprite = GrandmaNewSprite;
            StartCoroutine(PlayDialog());
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
        //StartCoroutine(FadeoutScene());
    }

    IEnumerator PlayDialog()
    {
        yield return new WaitForSeconds(0.8f);
        float waittime = SoundMgr.Instance.PlayDialogue(4);
        yield return new WaitForSeconds(waittime);
        iPhoneObj.GetComponentInChildren<Image>().enabled = false;
        LiveVideoObj.SetActive(true);
        iPhoneObj.GetComponent<XRGrabInteractable>().enabled = true;
        SmallGrandmaObj.GetComponent<Image>().enabled = true;
        
    }
}
