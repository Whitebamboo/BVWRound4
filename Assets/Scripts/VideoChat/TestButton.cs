using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButton : MonoBehaviour
{
    public GameObject MeObject;
    public GameObject CallObject;

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
        BroadcastMessage();
        MeObject.SetActive(true);
        CallObject.SetActive(true);
        this.gameObject.SetActive(false);

    }
    public void BroadcastMessage()
    {
        Debug.Log("========Button clicked=======");
    }
}
