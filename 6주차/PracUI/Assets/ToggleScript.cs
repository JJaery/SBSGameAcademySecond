using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour
{
    public Toggle targetToggle;
    public Text targetText;

    /// <summary>
    /// 토글이 발생할 때 호출되도록 설정할 것임
    /// </summary>
    public void OnClickToggle()
    {
        //Debug.Log(targetToggle.isOn);
        //if (targetToggle.isOn)
        //{
        //    targetText.text = "토글상태: ON";
        //}
        //else
        //{
        //    targetText.text = "토글상태: OFF";
        //}
        targetText.text = targetToggle.isOn ? "토글상태: ON" : "토글상태: OFF";
    }
}
