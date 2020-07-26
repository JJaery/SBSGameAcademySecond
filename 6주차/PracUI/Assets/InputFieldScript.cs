using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldScript : MonoBehaviour
{
    public InputField targetInput;
    public Text targetText;

    void Start()
    {
        targetText.text = "";
    }

    public void OnClickLoginBtn()
    {
        if (targetInput.text == "931005")
        {
            targetText.text = "로그인 성공!";
            targetText.color = Color.blue;
        }
        else
        {
            targetText.text = "로그인 실패!";
            targetText.color = Color.red;
        }
    }
}
