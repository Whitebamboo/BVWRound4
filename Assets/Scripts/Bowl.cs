using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowl : MonoBehaviour
{
    // Start is called before the first frame update
    public bool hasRice;
    public bool hasWater;
    public GameObject PlaneRice;
    public GameObject InnerPot1;
    public GameObject InnerPotinSteamCooker;
    public Material material;
    public float progress = 0;
    void Start()
    {
        material = InnerPot1.GetComponent<MeshRenderer>().material;
        hasRice = false;
        hasWater = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.name == "SteamCooker" && hasWater)
        {
            SoundMgr.Instance.PlaySound(1);
            InnerPotinSteamCooker.SetActive(true);
            Destroy(gameObject);
            
        }
    }
    public void ActivePlaneRice()
    {
        PlaneRice.SetActive(true);
    }

    public void ActiveInnerPot1()
    {
        InnerPot1.SetActive(true);
    }

    

    
}
