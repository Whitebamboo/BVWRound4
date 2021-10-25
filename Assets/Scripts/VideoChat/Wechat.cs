using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        StartCoroutine(PlayDialog1());
        this.gameObject.SetActive(false);
        WechatObject.SetActive(true);
        WechatObject.GetComponentInChildren<Danny>().clickTime = Time.time;
    }

    IEnumerator PlayDialog1()
    {
        float waittime = SoundMgr.Instance.PlayDialogue(2);
        yield return new WaitForSeconds(waittime);
    }
}
