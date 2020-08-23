using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEditor;

public class MakingManager : MonoBehaviour
{
    public SongData songData;
    public KeyCode[] keyCodes = new KeyCode[] { KeyCode.A, KeyCode.S, KeyCode.D, KeyCode.Space, KeyCode.J, KeyCode.K, KeyCode.L };
    public VideoPlayer vPlayer;

    private void Update()
    {
        foreach (KeyCode target in keyCodes)
        {
            if (Input.GetKeyDown(target))
            {
                MakeNoteData(target);
            }
        }

        if(Input.GetKeyDown(KeyCode.Insert))
        {
            SaveData();
        }
    }
    public void MakeNoteData(KeyCode targetCode)
    {
        MakingNoteData data = new MakingNoteData();
        data.keyCode = targetCode;
        data.time = (float)vPlayer.clockTime;
        songData.datas.Add(data);
    }

    public void SaveData()
    {
        string savePath = EditorUtility.SaveFilePanel("저장할 곳을 지정하세요", "", $"{songData.title} - {songData.singer}", "json");
        System.IO.File.WriteAllText(savePath, JsonUtility.ToJson(songData));
    }
}
