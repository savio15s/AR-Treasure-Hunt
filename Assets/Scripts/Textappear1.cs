using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textappear1 : MonoBehaviour
{
    public GameObject CText1;
    float TmStart;
    float TmLen = 5f;

    void Start()
    {
        TmStart = Time.time;
        //CText1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > TmStart + TmLen)
        {

            GUI.Label(new Rect(10, 10, 100, 100), "20 seconds has elapsed");
        }
    }
}
       