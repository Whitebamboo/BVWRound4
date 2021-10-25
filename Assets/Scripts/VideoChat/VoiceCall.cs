using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VoiceCall : MonoBehaviour
{
    public float clickTime;
    public GameObject iPhoneObject;
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
        this.gameObject.GetComponent<Image>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;

        iPhoneObject.GetComponent<iPhone>().isBeingCalled = true;
    }
}
