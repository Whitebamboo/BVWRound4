using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSceneiPhone : MonoBehaviour
{
    public float startTime;
    public bool isFirstTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        isFirstTime = true;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time - startTime > 5f) && isFirstTime)
        {
            PhoneViberates();
            isFirstTime = false;
        }
    }

    public void PhoneViberates()
    {
        SoundMgr.Instance.PlaySound(8);
        SoundMgr.Instance.PlaySound(10);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        StartCoroutine(FadeoutScene());
    }
    IEnumerator FadeoutScene()
    {
        Debug.Log("FADING OUT");
        URPScreenFade.Instance.SceneFadeOut();
        yield return new WaitForSeconds(2f);
    }
}
