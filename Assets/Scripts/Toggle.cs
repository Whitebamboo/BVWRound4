using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    public GameObject Cacookerp;
    private bool isStart = false;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartCook()
    {
        if (Cacookerp.activeSelf&& isStart==false)
        {
            SoundMgr.Instance.PlaySound(14);
            isStart = true;
            animator.SetTrigger("Trigger");
            StartCoroutine(Dialog4());
        }
    }

    IEnumerator Dialog4()
    {
        float waittime = SoundMgr.Instance.PlayDialogue(2);
        yield return new WaitForSeconds(waittime);
        GameManager.Instance.ChangeScene("BeginScene 2");
    }
}
