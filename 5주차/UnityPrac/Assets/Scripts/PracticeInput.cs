using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeInput : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) == true) /// 키를 눌렀을 때 딱 한번 true
        {
            Debug.Log("W키가 입력되었습니다.");
        }
        if (Input.GetKeyUp(KeyCode.W) == true) /// 키를 떼었을 때 딱 한번 true
        {
            Debug.Log("W키가 입력 취소되었습니다.");
        }
        if (Input.GetKey(KeyCode.W) == true) /// 키를 누르고 있으면 항상 true
        {
            Debug.Log("W키가 눌린 상태입니다.");
        }
    }
}
