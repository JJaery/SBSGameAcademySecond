using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UI;

public class UIBlinkObject : MonoBehaviour
{
    public float intervalSec = 1f;

    Text[] texts;
    Image[] images;

    // Start is called before the first frame update
    void Start()
    {
        texts = this.gameObject.GetComponents<Text>();
        images = this.gameObject.GetComponents<Image>();

        StartCoroutine(Blink());
    }

    IEnumerator Blink()
    {
        ///Color    (0~1) float
        ///Color32  (0~255) byte
        ///속력 = 거리/시간 (Sec)
        ///프레임간 Color 투명도 값을 조절 해야될 수치 = 1 / 시간 * Time.deltaTime

        bool isInverse = false;
        float currentAlpha = 0f;

        while (this.gameObject.activeSelf == true)
        {
            float offset = 1f / intervalSec * Time.deltaTime;

            if (currentAlpha >= 1f) /// 투명도가 1 이상이 될 경우
            {
                isInverse = true; // inverse를 true로 바꿔준다.
                currentAlpha = 1f; // 1.x 가 될 수 있음으로 1f로 셋팅해준다.
            }
            else if (currentAlpha <= 0f) /// 투명도가 0 이하가 될 경우
            {
                isInverse = false; // ..
                currentAlpha = 0f; // ..
            }

            if (isInverse == false) // inverse가 false이면? 투명도를 올려준다.
            {
                currentAlpha += offset;
            }
            else if (isInverse == true) // inverse가 true이면? 투명도를 내려준다.
            {
                currentAlpha -= offset;
            }

            if (texts != null)
            {
                foreach (Text target in texts)
                {
                    target.color = new Color(target.color.r, target.color.g, target.color.b, currentAlpha);
                }
            }
            if (images != null)
            {
                foreach (Image img in images)
                {
                    img.color = new Color(img.color.r, img.color.g, img.color.b, currentAlpha);
                }
            }

            yield return null;
        }
    }
}
