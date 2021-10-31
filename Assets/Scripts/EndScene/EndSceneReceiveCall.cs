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
            Debug.Log("============Received clic=========");
            HaveClicked = true;
            Debug.Log("Triggered");
            iPhoneObj.GetComponentInChildren<Image>().enabled = false;
            StartCoroutine(PlayDialog());
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
        //StartCoroutine(FadeoutScene());
    }

    IEnumerator PlayDialog()
    {
        float waittime = SoundMgr.Instance.PlayDialogue(4);
        yield return new WaitForSeconds(waittime);
        LiveVideoObj.SetActive(true);
        iPhoneObj.GetComponent<XRGrabInteractable>().enabled = true;
    }
}
