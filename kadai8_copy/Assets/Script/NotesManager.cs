using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]//シリアル化
public class Data
{
    public string name;
    public int maxBlock;
    public int BPM;
    public int offset;
    public Note[] notes;

}
[Serializable]
public class Note
{
    public int type;
    public int num;
    public int block;
    public int LPB;
}

public class NotesManager : MonoBehaviour
{
    public int noteNum;//総ノーツ数
    private string songName;//曲名

    public List<int> LaneNum = new List<int>();//何レーンにノーツが落ちるか
    public List<int> NoteType = new List<int>();//どんなノーツか
    public List<float> NotesTime = new List<float>();//判定線と重なる時間
    public List<GameObject> NotesObj = new List<GameObject>();//ゲームオブジェクト

    [SerializeField] private float NotesSpeed;//ノーツのスピード
    [SerializeField] GameObject noteObj;//ノーツのプレハブを入れる

    void OnEnable()
    {
        noteNum = 0;
        songName = "goforit";//Jsonファイルの名前
        Load(songName);
    }

    private void Load(string SongName)
    {
        string inputString = Resources.Load<TextAsset>(SongName).ToString();
        //リソースフォルダからjsonファイルの名前を読み込む
        Data inputJson = JsonUtility.FromJson<Data>(inputString);
        //jsonを読み込む

        noteNum = inputJson.notes.Length;//ノーツ数を指定
        //LPB：ノーツ(BPM)の配置間隔、一拍を何分割してノーツを置くか

        for (int i = 0; i < inputJson.notes.Length; i++)
        {
            float kankaku = 60 / (inputJson.BPM * (float)inputJson.notes[i].LPB);//一小節の長さ
            //括弧内：1分間に何個のノーツがあるか、なぜそれで60を割るのかは不明（聞いてみる）
            float beatSec = kankaku * (float)inputJson.notes[i].LPB;//ノーツ間の長さ
            float time = (beatSec * inputJson.notes[i].num / (float)inputJson.notes[i].LPB) + inputJson.offset + 0.01f;//ノーツの降ってくる時間
            NotesTime.Add(time);//リストに追加
            LaneNum.Add(inputJson.notes[i].block);//リストに追加
            NoteType.Add(inputJson.notes[i].type);//リストに追加

            float z = NotesTime[i] * NotesSpeed;//ノーツの生成する位置を計算
            NotesObj.Add(Instantiate(noteObj, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
        }
    }
}