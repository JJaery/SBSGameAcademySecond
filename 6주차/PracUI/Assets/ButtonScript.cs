using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Text targetText;
    private int clickCount = 0;
    
    /// <summary>
    /// 버튼이 눌릴 때마다 이 메소드가 호출되도록 설정할 것임.
    /// </summary>
    public void OnClickButton()
    {
        //clickCount = clickCount + 1;
        //clickCount++;
        targetText.text = $"{++clickCount}회 만큼 눌림";
    }
}
