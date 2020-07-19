using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeLocalPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = Vector3.zero; /// 부모를 기준으로 0,0,0
        //transform.position = Vector3.zero; /// 월드를 기준으로 0,0,0
    }
}
