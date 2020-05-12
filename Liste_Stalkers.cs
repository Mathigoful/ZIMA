using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liste_Stalkers : MonoBehaviour
{
    public GameObject[] stalkerlist;
    // Start is called before the first frame update
    void Start()
    {
        stalkerlist = new GameObject[4];
        stalkerlist[0] = GameObject.Find("Stalker1");
        stalkerlist[1] = GameObject.Find("Stalker2");
        stalkerlist[2] = GameObject.Find("Stalker3");
        stalkerlist[3] = GameObject.Find("Stalker4");
    }

    void Update()
    {
        
    }
}
