using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class SoundMgr : MonoBehaviour
{
    [Header("Audio List")]
    [SerializeField] private List<AudioClip> soundList;
    [SerializeField] private List<AudioClip> bgmList;
    [SerializeField] private List<AudioClip> dialoguesList;
    [SerializeField] public static SoundMgr Instance = null;
    [SerializeField] private int dialogueIndex = 0;

    [Header("FadeIn Configs")]
    [SerializeField] private float smoothness = 0.5f;
    [SerializeField] private float increase = 0.05f;
    [SerializeField] private float maxVolume = 1.0f;

    private bool startBgm = true;
    private AudioSource audioSource;

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
        audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        
        //audioSource.volume = 0;
        PlayBGM(1);
        //VolumeFadeIn();
        
    }

    public void PlaySound(int clipIndex)
    {
        audioSource.PlayOneShot(soundList[clipIndex]);
       
    }

    public float PlayDialogue(int times)
    {
        if (dialogueIndex == dialoguesList.Count)
        {
            Debug.LogWarning("dialogue index exceeds range!");
            return 0f;
        }
        StartCoroutine(PlayDialogIE(times));
        float waittime = 0;
        int temp = dialogueIndex;
        for (int i = 0; i < times; i++)
        {
            if(temp== dialoguesList.Count)
            {
                return waittime;
            }
            waittime += dialoguesList[temp].length;
            temp++;
        

        }
        return waittime;
    }

    public void PlayBGM(int clipIndex)
    {
        audioSource.clip = bgmList[clipIndex];
        audioSource.Play();
    }

    public void StopBGM()
    {
        audioSource.Stop();
    }

    private void VolumeFadeIn()
    {
        StartCoroutine(StartVolumeFadeIn(smoothness, increase, maxVolume));
    }

    IEnumerator StartVolumeFadeIn(float smoothness, float inc, float maxVol)
    {
        while (audioSource.volume < maxVol)
        {
            audioSource.volume += inc;
            yield return new WaitForSeconds(smoothness);
        }
    }

    IEnumerator PlayDialogIE(int times)
    {
        for(int i = 0; i < times; i++)
        {
            audioSource.PlayOneShot(dialoguesList[dialogueIndex]);
            yield return new WaitForSeconds(dialoguesList[dialogueIndex].length);
            dialogueIndex++;
            
        }
        
    }
}
