using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour
{
    // Start is called before the first frame update
    private bool hasRice;
    public bool ReadyForWater;
    public GameObject Rice;
    public bool hasWater;
    public GameObject innerWater;
    void Start()
    {
        hasRice = false;
        ReadyForWater = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name == "RiceBag"&&!hasRice)
        {
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
            hasRice = true;
            Rice.SetActive(true);
            SoundMgr.Instance.PlaySound(0);
        }

        if (other.gameObject.name == "CookerInnerPot" && hasRice &&!ReadyForWater)
        {
            
            
            SoundMgr.Instance.PlaySound(0);
            hasRice = false;
            ReadyForWater = true;
            other.gameObject.GetComponent<Bowl>().hasRice = true;
            Rice.SetActive(false);
            other.gameObject.GetComponent<Bowl>().ActivePlaneRice();
        }

        
    }
}
