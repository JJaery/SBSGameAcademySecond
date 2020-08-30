using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int hp;
    public int dmg;

    void Start()
    {
        InputManager.onMoveKeyPress += Move;
    }
    void OnDestroy()
    {
        InputManager.onMoveKeyPress -= Move;
    }

    public void Move(Vector3 dir)
    {
        transform.Translate(dir * Time.deltaTime * 10);
    }
}
