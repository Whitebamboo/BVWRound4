using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        this.gameObject.GetComponent<Image>().enabled = false;
        HomeImageCanvas.SetActive(true);
        StartCoroutine(PlayDialog0());

    }

    IEnumerator PlayDialog0()
    {

        // 1,2,3
        float waittime = SoundMgr.Instance.PlayDialogue(3);
        yield return new WaitForSeconds(waittime);
        HomeImage.GetComponent<BoxCollider>().enabled = true;

    }
}
