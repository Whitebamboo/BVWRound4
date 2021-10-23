using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaCookerp : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CookerInnerPot;
    public GameObject cacookerp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="SteamCooker"&& CookerInnerPot.activeSelf)
        {
            cacookerp.SetActive(true);
            Destroy(gameObject);
        }
    }
}
