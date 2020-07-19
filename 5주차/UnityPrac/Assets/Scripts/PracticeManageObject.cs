using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeManageObject : MonoBehaviour
{
    public GameObject prefab;

    private List<GameObject> _list = new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < 10000; i++)
        {
            GameObject instance = Instantiate<GameObject>(prefab);
            instance.name = $"복제품 {i}호";
            instance.transform.position = new Vector3(i * 0.1f,0);

            _list.Add(instance);
        }
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Delete)) /// 플레이어가 Delete버튼을 눌렀을 때 발동
        {
            foreach(GameObject obj in _list)
            {
                Destroy(obj);
            }
            _list.Clear();
        }
    }

}
