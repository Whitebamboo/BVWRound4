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
        if (Time.time - clickTime > 1f)
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.SetActive(false);
        WechatDannyObj.SetActive(true);
    }
}
