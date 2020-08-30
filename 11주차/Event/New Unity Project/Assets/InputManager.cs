using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static event Action<KeyCode> onKeyPress;
    public static event Action<Vector3> onMoveKeyPress;


    Dictionary<KeyCode, Vector3> _moveDic = new Dictionary<KeyCode, Vector3>()
    {
        {KeyCode.W, Vector3.forward },
        {KeyCode.S, Vector3.back },
        {KeyCode.A, Vector3.left },
        {KeyCode.D, Vector3.right }
    };

    // Update is called once per frame
    void Update()
    {
        #region onMoveKeyPress 구현단
        Vector3 dir = Vector3.zero;
        foreach(var data in _moveDic)
        {
            if (Input.GetKey(data.Key))
            {
                dir += data.Value;
            }
        }
        if(dir != Vector3.zero)
        {
            onMoveKeyPress?.Invoke(dir.normalized);
        }
        #endregion
    }

}
