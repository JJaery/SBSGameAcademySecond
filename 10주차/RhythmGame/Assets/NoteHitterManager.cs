using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteHitterManager : MonoBehaviour
{
    #region 싱글톤
    public static NoteHitterManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType<NoteHitterManager>();
            return _instance;
        }
    }
    private static NoteHitterManager _instance;
    #endregion

    public List<NoteHitter> noteHitters;

    public NoteHitter GetNoteHitter(KeyCode keyCode)
    {
        foreach (NoteHitter noteHitter in noteHitters)
        {
            if (noteHitter.targetKeyCode == keyCode)
                return noteHitter;
        }

        //여기가 들어온 순간 에러이기 때문에 에러메세지를 표시해주는게 맞습니다.
        Debug.LogError($"키코드가 잘못들어왔습니다. - {keyCode}");
        return null;
    }
}
