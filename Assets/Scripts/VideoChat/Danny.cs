using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danny : MonoBehaviour
{
    public GameObject WechatDannyObj;
    public float clickTime;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - clickTime > 5f)
        {
            Debug.Log("===Being able to click danny====");
            this.gameObject.GetComponent<BoxCollider>().enabled = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(PlayDialog4());
        this.gameObject.SetActive(false);
        WechatDannyObj.SetActive(true);
    }

    IEnumerator PlayDialog4()
    {
        float waittime = SoundMgr.Instance.PlayDialogue(2);
        yield return new WaitForSeconds(waittime);
    }
}
