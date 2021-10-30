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

    void Start()
    {
        //cam = GetComponent<Camera>();
        xx = 108;
        yy = 120;
        zz = 0;
        pos = new Vector3(xx, yy, zz);
    }

    void Update()
    {
        
        //pos = new Vector3(xx, yy, zz);
        Ray ray = iphonecamera.ScreenPointToRay(pos);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
        RaycastHit hitinfo;
        if (Physics.Raycast(ray, out hitinfo))
        {
            if (hitinfo.transform.name == "SteamCooker")
            {
                Debug.Log("SteamCooker captured");
                // !!!!!!! TODO: Replaced with dialogue later.
                SoundMgr.Instance.PlaySound(0);
            }
            //Debug.Log(hitinfo.transform.name + "::" + hitinfo.collider.isTrigger);
        }
    }
}
