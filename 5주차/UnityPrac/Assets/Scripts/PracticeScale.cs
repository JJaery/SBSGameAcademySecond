using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeScale : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.localScale = transform.localScale + new Vector3(1.0f, 1.0f, 0);
    }
}
