using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
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
        this.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = false;
        GameReplay();

    }

    public void GameReplay() {
        //SceneManager.LoadScene("BeginScene");
        GameManager.Instance.ChangeScene("BeginScene");
    }
}
