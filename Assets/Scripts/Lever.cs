using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Water;
    //public GameObject WaterCollider;
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
            //WaterCollider.SetActive(true);
            Water.GetComponent<PourDetector>().pourCheck=true;
        }

        if (other.gameObject.name == "OffTrigger")
        {
            //WaterCollider.SetActive(false);
            Water.GetComponent<PourDetector>().pourCheck = false;
        }
    }
}
