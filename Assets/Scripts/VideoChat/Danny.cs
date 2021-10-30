using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Danny : MonoBehaviour
{
    public GameObject WechatDannyObj;
    public Animator GrandmaPointing;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
   
    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<Image>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;

        WechatDannyObj.SetActive(true);
        StartCoroutine(PlayDialog());
        
        // <Tempelate usage of Grandma Pointing iPad animation>
        GrandmaPointing.SetTrigger("ShouldPoint");


    }

    IEnumerator PlayDialog()
    {
        float waittime = SoundMgr.Instance.PlayDialogue(2);
        yield return new WaitForSeconds(waittime);
        WechatDannyObj.GetComponentInChildren<BoxCollider>().enabled = true;
    }
}
