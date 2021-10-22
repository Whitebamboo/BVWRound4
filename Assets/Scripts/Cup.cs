using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour
{
    // Start is called before the first frame update
    private bool hasRice;
    void Start()
    {
        hasRice = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Rice")
        {
            hasRice = true;
            GetComponent<MeshRenderer>().material.color = Color.white;
        }

        if (other.gameObject.name == "Bowl"&&hasRice)
        {
            hasRice = false;
            other.gameObject.GetComponent<Bowl>().hasRice = true;
            GetComponent<MeshRenderer>().material.color = Color.black;
            other.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }
}
