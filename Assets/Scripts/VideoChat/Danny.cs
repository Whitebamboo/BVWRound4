using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Danny : MonoBehaviour
{
    public GameObject WechatDannyObj;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
   
    private void OnTriggerEnter(Collider other)
    {
        SoundMgr.Instance.PlaySound(9);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        this.gameObject.GetComponent<Image>().enabled = false;

        WechatDannyObj.SetActive(true);
        StartCoroutine(PlayDialog());


    }

    IEnumerator PlayDialog()
    {
        float waittime = SoundMgr.Instance.PlayDialogue(2);
        yield return new WaitForSeconds(waittime);
        WechatDannyObj.GetComponent<BoxCollider>().enabled = true;
    }
}
