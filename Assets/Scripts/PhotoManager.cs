using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PhotoManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject photo1;
    public GameObject photo2;
    public GameObject photo3;
    public GameObject photo4;
    public GameObject credit;
    public GameObject title;
    void Start()
    {
        StartCoroutine(ShowPics());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FadeIn(GameObject i, float smoothness, float duration)
    {
        float progress = 0; //This float will serve as the 3rd parameter of the lerp function.
        float increment = smoothness / duration; //The amount of change to apply.
        SpriteRenderer sr = i.GetComponent<SpriteRenderer>();
        while (progress < 1)
        {
            sr.color = Color.Lerp(new Color(sr.color.r, sr.color.g, sr.color.b, 0), new Color(sr.color.r, sr.color.g, sr.color.b, 1), progress);
            if (i.transform.GetChild(0).GetComponent<TextMeshPro>() != null)
            {
                i.transform.GetChild(0).GetComponent<TextMeshPro>().color = Color.Lerp(Color.black, Color.white, progress);
            }
           
            progress += increment;
            yield return new WaitForSeconds(smoothness);




        }
    }

    IEnumerator ShowPics()
    {
        yield return new WaitForSeconds(3f);
        photo1.SetActive(true);
        StartCoroutine(FadeIn(photo1, 0.01f, 5f));
        
        yield return new WaitForSeconds(SoundMgr.Instance.PlayDialogue(1));
        photo1.SetActive(false);

        photo2.SetActive(true);
        StartCoroutine(FadeIn(photo2, 0.01f, 5f));
        yield return new WaitForSeconds(SoundMgr.Instance.PlayDialogue(1));
        photo2.SetActive(false);

        photo3.SetActive(true);
        StartCoroutine(FadeIn(photo3, 0.01f, 5f));
        yield return new WaitForSeconds(SoundMgr.Instance.PlayDialogue(1));
        photo3.SetActive(false);

        photo4.SetActive(true);
        StartCoroutine(FadeIn(photo4, 0.01f, 5f));
        yield return new WaitForSeconds(5f);
        photo4.SetActive(false);

        credit.SetActive(true);
        StartCoroutine(FadeIn(credit, 0.01f, 5f));
        yield return new WaitForSeconds(5f);
        credit.SetActive(false);

        title.SetActive(true);
        StartCoroutine(FadeIn(title, 0.01f, 5f));
    }
}
