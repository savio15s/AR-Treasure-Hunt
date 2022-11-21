using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class texttimer : MonoBehaviour
{
    float time = 5f; //Seconds to read the text

    void Start()
    {
        Invoke("Hide", time);
    }

    void Hide()
    {
        Destroy(gameObject);
    }

}

