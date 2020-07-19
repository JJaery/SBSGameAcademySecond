using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeMoveObject : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            transform.position = transform.position + new Vector3(0, 1f, 0);
        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            transform.position = transform.position + new Vector3(-1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            transform.position = transform.position + new Vector3(0, -1f, 0);
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            transform.position = transform.position + new Vector3(1f, 0, 0);
        }
    }
}
