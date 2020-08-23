using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    #region SingleTon
    public static NoteManager Instance;
    private void Awake()
    {
        Instance = this;
    }
    #endregion
    
    public static float SpawnDistance = 400f;
    public static float NoteSpeed = 400f;


    /// <summary>
    /// 노트 프리팹
    /// </summary>
    public Note prefab;

    public Transform parentObj;
    public List<Note> notes = new List<Note>();


    public void SpawnNote(KeyCode key)
    {
        NoteHitter hitter = NoteHitterManager.Instance.GetNoteHitter(key);
        ///노트가 생성되는 위치는 hitter.transform.position 의 값에 따라 달라진다.
        GameObject instanceObject = Instantiate(prefab.gameObject);
        instanceObject.transform.position = hitter.transform.position + Vector3.up * SpawnDistance;
        instanceObject.transform.SetParent(parentObj);
        instanceObject.transform.localScale = Vector3.one;

        Note script = instanceObject.GetComponent<Note>();
        script.targetKeycode = key;
    }
}
