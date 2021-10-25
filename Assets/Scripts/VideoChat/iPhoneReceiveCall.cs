using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iPhoneReceiveCall : MonoBehaviour
{
    public GameObject VideoChatObj;
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
        this.gameObject.SetActive(false);
        VideoChatObj.SetActive(true);

        SoundMgr.Instance.PlaySound(0);
    }
}
