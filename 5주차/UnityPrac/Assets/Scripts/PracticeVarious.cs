using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PracticeVarious : MonoBehaviour
{
    public int num1 = 10;
    public float num2;
    public string text;
    public char character;
    public Color color;
    public Vector3 vec;
    public List<int> list;
    public float[] floatArr;

    public PracticeVarious script;

    //안되는 것들
    public Dictionary<string, string> dic; // 딕션어리는 안된다.
    public Queue<int> queue;
    public Stack<int> stack;

    void Start()
    {
        Debug.Log(num1);
    }
}