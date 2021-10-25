using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        StartCoroutine(PlayDialog2());

        this.gameObject.GetComponentInParent<iPhone>().isPressed = true;
        this.gameObject.SetActive(false);
        VideoChatObj.SetActive(true);
        

        
        


       
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
