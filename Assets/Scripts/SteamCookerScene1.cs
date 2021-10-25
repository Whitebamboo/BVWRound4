using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamCookerScene1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject image;
    private bool isSelect = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowImage()
    {
        if (!isSelect)
        {
            isSelect = true;
            StartCoroutine(FadeIn(image, 0.01f, 3f));
            SoundMgr.Instance.PlaySound(15);
        }
    }

    IEnumerator FadeIn(GameObject i, float smoothness, float duration)
    {
        float progress = 0; //This float will serve as the 3rd parameter of the lerp function.
        float increment = smoothness / duration; //The amount of change to apply.
        SpriteRenderer sr = i.GetComponent<SpriteRenderer>();
        while (progress < 1)
        {
            sr.color = Color.Lerp(new Color(sr.color.r, sr.color.g, sr.color.b, 0), new Color(sr.color.r, sr.color.g, sr.color.b, 1), progress);
            progress += increment;
            yield return new WaitForSeconds(smoothness);
            
        }
        if (this.gameObject.name == "SteamCooker")
        {
            GameManager.Instance.ChangeScene("CookingScene");
        }
        else if (this.gameObject.name == "iPad")
        {
            GameManager.Instance.ChangeScene("VideoChatScene");
        }
        
    }
}
