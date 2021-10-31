using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeRiceCooker : MonoBehaviour
{
    public Camera iphonecamera;
    public int xx;
    public int yy;
    public int zz;
    Vector3 pos;
    public bool isFirstTime;
    void Start()
    {
        //cam = GetComponent<Camera>();
        xx = 108;
        yy = 120;
        zz = 0;
        pos = new Vector3(xx, yy, zz);
        isFirstTime = true;
    }

    void Update()
    {
        
        //pos = new Vector3(xx, yy, zz);
        Ray ray = iphonecamera.ScreenPointToRay(pos);
        //Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
        RaycastHit hitinfo;
        if (Physics.Raycast(ray, out hitinfo))
        {
            if (hitinfo.transform.name == "SteamCooker" && isFirstTime)
            {
                Debug.Log("SteamCooker captured");
                // !!!!!!! TODO: Replaced with dialogue later.
                SoundMgr.Instance.PlayDialogue(3);
                isFirstTime = false;
            }
            //Debug.Log(hitinfo.transform.name + "::" + hitinfo.collider.isTrigger);
        }
    }
}
