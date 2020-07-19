using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeTransform : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, 0.1f, 0);
        //transform.position = transform.position + Vector3.up * 0.1f; // 같은 뜻
    }
}
