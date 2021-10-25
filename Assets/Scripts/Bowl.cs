using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowl : MonoBehaviour
{
    // Start is called before the first frame update
    public bool hasRice;
    public bool readyforCook;
    private int waterCount =1;
    public GameObject PlaneRice;
    public GameObject InnerPot1;
    public GameObject InnerPot2;
    public GameObject InnerPotinSteamCooker;

    void Start()
    {
        
        hasRice = false;
        readyforCook = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.name == "SteamCooker" && readyforCook)
        {
            SoundMgr.Instance.PlaySound(1);
            InnerPotinSteamCooker.SetActive(true);
            Destroy(gameObject);
            
        }
        if (other.gameObject.name == "MeasuringCup" && other.gameObject.GetComponent<Cup>().hasWater)
        {
            other.gameObject.GetComponent<Cup>().hasWater = false;
            other.gameObject.GetComponent<Cup>().innerWater.SetActive(false);
            AddWater();
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

    public void AddWater()
    {
        if (waterCount == 1)
        {
            InnerPot1.SetActive(true);
            waterCount++;
            SoundMgr.Instance.PlaySound(13);
        }
        else if (waterCount == 2)
        {
            SoundMgr.Instance.PlaySound(13);
            InnerPot1.SetActive(false);
            InnerPot2.SetActive(true);
            waterCount++;
            StartCoroutine(Dialog3());
        }
    }


    IEnumerator Dialog3()
    {
        float waittime = SoundMgr.Instance.PlayDialogue(2);
        yield return new WaitForSeconds(waittime);
        readyforCook = true;
    }

}
