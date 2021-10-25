using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Black : MonoBehaviour
{
    public GameObject HomeImageCanvas;
    public GameObject HomeImage;
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
        HomeImageCanvas.SetActive(true);
        StartCoroutine(PlayDialog0());
        this.gameObject.SetActive(false);
        



    }

    IEnumerator PlayDialog0()
    {

        Debug.Log("----------");
        float waittime = SoundMgr.Instance.PlayDialogue(3);
        yield return new WaitForSeconds(waittime);
        HomeImage.GetComponent<BoxCollider>().enabled = true;
    }
}
