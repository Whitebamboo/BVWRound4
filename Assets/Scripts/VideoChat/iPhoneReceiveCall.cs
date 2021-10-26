using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class iPhoneReceiveCall : MonoBehaviour
{
    public GameObject VideoChatObj;
    //public GameObject SoundMgrObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Hand")
        {
            Debug.Log("!OntriggerEnter");
            this.gameObject.GetComponentInParent<iPhone>().isPressed = true;

            //this.gameObject.SetActive(false);
            this.gameObject.GetComponent<Image>().enabled = false;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;

            StartCoroutine(PlayDialog2());
        }
        //VideoChatObj.SetActive(true);

        //SoundMgrObj.GetComponent<AudioSource>().Stop();

    }

    IEnumerator PlayDialog2()
    {
        Debug.Log("=====It works!====");
        float waittime = SoundMgr.Instance.PlayDialogue(2);
        yield return new WaitForSeconds(waittime);
        GameManager.Instance.ChangeScene("EnddingScene");
    }

}
