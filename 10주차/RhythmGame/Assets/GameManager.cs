using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.RestService;
using UnityEngine;
using UnityEngine.Video;

public class GameManager : MonoBehaviour
{
    public VideoPlayer vPlayer;
    private List<MakingNoteData> _makingNoteDatas;

    public void SelectSongJsonFile()
    {
        string targetPath = EditorUtility.OpenFilePanel("재생할 노래 Json파일을 선택하세요", "", "json");
        string json = System.IO.File.ReadAllText(targetPath);
        SongData data = JsonUtility.FromJson<SongData>(json);
        PlayGame(data);
    }

    public void PlayGame(SongData playData)
    {
        ///게임 초기화 - 점수 초기화 등등..
        ///비디오 플레이
        _makingNoteDatas = playData.datas;
        vPlayer.Play();
    }

    /// <summary>
    /// 속력 = 거리 / 시간
    /// 시간 = 거리 / 속력
    /// 속력 = 100 - NoteManager.NoteSpeed
    /// 거리 = 400 - NoteManager.SpawnDistance
    /// 총 시간 = 4초 - NoteManager.SpawnDistance / NoteManager.NoteSpeed
    /// </summary>
    public void Update()
    {
        if(_makingNoteDatas != null)
        {
            float alphaTime = NoteManager.SpawnDistance / NoteManager.NoteSpeed;

            List<MakingNoteData> targetNotes = new List<MakingNoteData>();

            foreach (MakingNoteData data in _makingNoteDatas)
            {
               if(data.time - alphaTime <= vPlayer.clockTime)
                {
                    targetNotes.Add(data);
                    NoteManager.Instance.SpawnNote(data.keyCode);
                }
            }

            foreach(MakingNoteData data in targetNotes)
            {
                _makingNoteDatas.Remove(data);
            }
        }
    }
}
