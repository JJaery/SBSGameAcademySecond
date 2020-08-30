using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEditor.UI;
using UnityEngine;

public class Note : MonoBehaviour
{
    public KeyCode targetKeycode;
    private float height = 0;
    private float maxRange = 0;
    private float minRange = 0;
    private NoteHitter targetHitter;

    private void Start()
    {
        NoteManager.Instance.notes.Add(this);
        targetHitter = NoteHitterManager.Instance.GetNoteHitter(targetKeycode);
        Vector3[] wCorners = new Vector3[4];
        targetHitter.targetImage.rectTransform.GetWorldCorners(wCorners);
        ///bl - tl - tr - br
        height = wCorners[1].y - wCorners[0].y;
        minRange = -height * 1.5f;
        maxRange = height * 1.5f;

    }

    void Update()
    {
        NoteMove();
        CheckHit();
    }

    private void NoteMove()
    {
        transform.Translate(Vector2.down * NoteManager.NoteSpeed * Time.deltaTime);
        if (transform.localPosition.y < -600f)
        {
            GameManager.Instance.OnHitNote(GameManager.eHitPercent.Miss);
            Destroy(this.gameObject);
            NoteManager.Instance.notes.Remove(this);
        }
    }

    private void CheckHit()
    {
        if (Input.GetKey(targetKeycode))
        {
            if (targetHitter.canHit == true)
            {
                float dist = (this.transform.position.y - targetHitter.targetImage.rectTransform.position.y);
                // dist == 0일 경우 두개가 겹칠 때
                if (dist <= maxRange && dist >= minRange) // 딱 영역안
                {
                    targetHitter.canHit = false;
                    Hitted(dist);
                }
            }
        }
    }

    // dist == 0일 경우 두개가 겹칠 때
    public void Hitted(float dist)
    {
        //dist == 0 , height / height == 1,
        //dist == height, (height - height) / height == 0,
        float totalRange = maxRange - minRange;
        float percent = (totalRange - dist) / totalRange;

        if(percent > 0.5f)
        {
            GameManager.Instance.OnHitNote(GameManager.eHitPercent.Perfect);
        }
        else if(percent > 0.1f)
        {
            GameManager.Instance.OnHitNote(GameManager.eHitPercent.Good);
        }
        else
        {
            GameManager.Instance.OnHitNote(GameManager.eHitPercent.Bad);
        }

        Destroy(this.gameObject);
        NoteManager.Instance.notes.Remove(this);
    }
}
