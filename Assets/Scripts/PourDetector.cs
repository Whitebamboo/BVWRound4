using System.Collections;
using UnityEngine;

public class PourDetector : MonoBehaviour
{
    public int pourThreshold = 45;
    public Transform origin = null;
    public GameObject streamPrefab = null;

    private bool isPouring = false;
    public bool pourCheck = false;
    private Stream currentStream = null;

    private void Update()
    {
        //bool pourCheck = CalculatePourAngle() < pourThreshold;
       
        if (isPouring != pourCheck)
        {
            isPouring = pourCheck;

            if (isPouring)
            {
                StartPour();
            }
            else
            {
                EndPour();
            }
        }
    }

    private void StartPour()
    {
        
        currentStream = CreatStream();
        currentStream.Begin();
    }

    private void EndPour()
    {
        
        currentStream.End();
        currentStream = null;
    }

    private float CalculatePourAngle()
    {
        return transform.forward.y*Mathf.Rad2Deg;
    }

    private Stream CreatStream()
    {
        GameObject streamObject = Instantiate(streamPrefab, origin.position, Quaternion.identity, transform);
        return streamObject.GetComponent<Stream>();
    }
}