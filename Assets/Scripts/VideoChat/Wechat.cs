using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wechat : MonoBehaviour
{
    public GameObject WechatObject;
    
    // Start is called before the first frame update
    void Start()
    {
        //SoundMgr.Instance.PlayDialogue(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {


        //this.gameObject.SetActive(false);
        SoundMgr.Instance.PlaySound(9);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        this.gameObject.GetComponent<Image>().enabled = false;

        WechatObject.SetActive(true);
        //WechatObject.GetComponentInChildren<BoxCollider>().enabled = true;
        StartCoroutine(PlayDialog());
    }

    IEnumerator PlayDialog()
    {
        float waittime = SoundMgr.Instance.PlayDialogue(2);
        yield return new WaitForSeconds(waittime);
        WechatObject.GetComponent<BoxCollider>().enabled = true;

    }
}
