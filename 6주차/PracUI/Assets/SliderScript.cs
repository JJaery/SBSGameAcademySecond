using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Slider targetSlider;
    public Text targetText;

    void Start()
    {
        targetText.text = $"{targetSlider.value}";
    }

    /// <summary>
    /// Slider에서 값이 바뀔때 호출되게 설정할 예정
    /// </summary>
    public void OnValueChanged()
    {
        targetText.text = $"{targetSlider.value}";
    }
}
