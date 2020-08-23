using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SongData
{
    public string title;
    public string singer;
    public List<MakingNoteData> datas;
}


[System.Serializable]
public class MakingNoteData
{
    public KeyCode keyCode;
    public float time;
}
