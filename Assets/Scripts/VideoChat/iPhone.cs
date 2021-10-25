using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iPhone : MonoBehaviour
{
    public GameObject BlackObject;
    public bool isBeingCalled;
    public bool haveCalled;
    public float startTime;

    public GameObject BeingCalledObj;
    //public GameObject 

    // Start is called before the first frame update
    void Start()
    {
        isBeingCalled = false;
        haveCalled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (isBeingCalled)
        {
            startTime = Time.time;
            isBeingCalled = false;
            haveCalled = true;
        }
        if ((Time.time - startTime > 2.5f) && (haveCalled)){
            BlackObject.SetActive(false);
            BeingCalledObj.SetActive(true);
        }
    }

}
