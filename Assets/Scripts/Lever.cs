using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Water;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "OnTrigger")
        {
            Water.GetComponent<PourDetector>().pourCheck=true;
        }

        if (other.gameObject.name == "OffTrigger")
        {
            Water.GetComponent<PourDetector>().pourCheck = false;
        }
    }
}
