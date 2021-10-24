using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Image flashimage;
    void Start()
    {
        StartCoroutine(FadeOut(flashimage, 0.01f, 2f));
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextScene(string scenename)
    {
        StartCoroutine(FadeIn(flashimage, 0.01f, 2f, scenename));
    }

    IEnumerator FadeIn(Image i, float smoothness, float duration, string sceneName)
    {
        float progress = 0; //This float will serve as the 3rd parameter of the lerp function.
        float increment = smoothness / duration; //The amount of change to apply.

        while (progress < 1)
        {
            i.color = Color.Lerp(new Color(i.color.r, i.color.g, i.color.b, 0), new Color(i.color.r, i.color.g, i.color.b, 1), progress);
            progress += increment;
            yield return new WaitForSeconds(smoothness);

        }
        SceneManager.LoadScene(sceneName);

    }

    IEnumerator FadeOut(Image i, float smoothness, float duration)
    {
        float progress = 0; //This float will serve as the 3rd parameter of the lerp function.
        float increment = smoothness / duration; //The amount of change to apply.

        while (progress < 1)
        {
            i.color = Color.Lerp(new Color(i.color.r, i.color.g, i.color.b, 1), new Color(i.color.r, i.color.g, i.color.b, 0), progress);
            progress += increment;
            yield return new WaitForSeconds(smoothness);

        }
    }

}
