using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager Instance = null;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
        DontDestroyOnLoad(gameObject);

    }
    void Start()
    {
       
        
        
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    
    public void ChangeScene(string scenename)
    {
        StartCoroutine(WaitForChangeScene(scenename));
        
    }

    IEnumerator WaitForChangeScene(string scenename)
    {
        URPScreenFade.Instance.SceneFadeOut();
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(scenename);
    }
    

}
