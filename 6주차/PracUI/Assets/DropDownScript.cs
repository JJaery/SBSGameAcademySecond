using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownScript : MonoBehaviour
{
    public enum eDropDownItem
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Purple,
    }
    public Dropdown targetDropDown;
    public Image targetImage;

    void Start()
    {
        OnValueChanged();
    }

    /// <summary>
    /// DropDown이 값이 바뀔 때 호출할 예정
    /// </summary>
    public void OnValueChanged()
    {
        switch ((eDropDownItem)targetDropDown.value)
        {
            case eDropDownItem.Red:
                targetImage.color = Color.red;
                break;
            case eDropDownItem.Orange:
                targetImage.color = new Color32(255, 69, 0, 255);
                break;
            case eDropDownItem.Yellow:
                targetImage.color = Color.yellow;
                break;
            case eDropDownItem.Green:
                targetImage.color = Color.green;
                break;
            case eDropDownItem.Blue:
                targetImage.color = Color.blue;
                break;
            case eDropDownItem.Indigo:
                targetImage.color = new Color32(75, 0, 130, 255);
                break;
            case eDropDownItem.Purple:
                targetImage.color = new Color32(128, 0, 128, 255);
                break;
        }
    }
}
