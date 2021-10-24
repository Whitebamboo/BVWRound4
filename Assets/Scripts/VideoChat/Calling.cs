using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calling : MonoBehaviour
{

    public GameObject BlackObject;
    public GameObject MeObject;
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
        MeObject.SetActive(false);
        this.gameObject.SetActive(false);
        BlackObject.SetActive(false);
        CalliPhone();
    }

    public void CalliPhone()
    {
        iPhoneObject.GetComponent<iPhone>().isBeingCalled = true;
        Debug.Log("=====Call>>==");
    }

    //IEnumerator Waitforcall()
    //{
    //    iPhoneBlackObject.SetActive(false);
    //    yield return new WaitForSeconds(3f);
    //    Debug.Log("-----------------------------");
    //}
}
