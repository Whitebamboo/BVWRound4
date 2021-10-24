using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour
{
    // Start is called before the first frame update
    private bool hasRice;
    public GameObject Rice;
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
        if (other.gameObject.name == "RiceBag"&&!hasRice)
        {
            hasRice = true;
            Rice.SetActive(true);
            SoundMgr.Instance.PlaySound(0);
        }

        if (other.gameObject.name == "CookerInnerPot" && hasRice)
        {
            
            if (other.gameObject.GetComponent<Bowl>().hasRice == false)
            {
                SoundMgr.Instance.PlayDialogue();
            }
            SoundMgr.Instance.PlaySound(0);
            hasRice = false;
            other.gameObject.GetComponent<Bowl>().hasRice = true;
            Rice.SetActive(false);
            other.gameObject.GetComponent<Bowl>().ActivePlaneRice();
        }
    }
}
