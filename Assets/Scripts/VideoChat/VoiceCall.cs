using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceCall : MonoBehaviour
{
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
        this.gameObject.SetActive(false);
        iPhoneObject.GetComponent<iPhone>().isBeingCalled = true;
    }
}
