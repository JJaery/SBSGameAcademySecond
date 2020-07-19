using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeGameObject : MonoBehaviour
{
    public GameObject[] targets;

    void Update()
    {
        foreach (GameObject obj in targets)
        {
            obj.SetActive(!obj.activeSelf);
            obj.name = $"아무개 - {obj.activeSelf}"; // -> 부모가 꺼져있어도 자신이 켜져있으면 true
            //obj.name = $"아무개 - {obj.activeInHierarchy}"; // -> 부모가 꺼져있을 때 자신이 켜져있어도 false
        }
    }
}
