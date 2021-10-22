using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowl : MonoBehaviour
{
    // Start is called before the first frame update
    public bool hasRice;
    public bool hasWater;
    void Start()
    {
        hasRice = false;
        hasWater = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Water" && hasRice)
        {
            hasWater = true;
            GetComponent<MeshRenderer>().material.color = Color.blue;
        }

        if (other.gameObject.name == "RiceCooker" && hasWater)
        {
            Destroy(gameObject);
            
        }
    }
}
