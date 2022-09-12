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
    [SerializeField] GameObject noteObj2;
    [SerializeField] GameObject noteObj3;
    [SerializeField] GameObject noteObj4;
    [SerializeField] GameObject noteObj5;
    [SerializeField] GameObject noteObj6;
    [SerializeField] GameObject noteObj7;
    [SerializeField] GameObject noteObj8;
    [SerializeField] GameObject noteObj9;
    [SerializeField] GameObject noteObj10;
    [SerializeField] GameObject noteObj11;
    [SerializeField] GameObject noteObj12;
    [SerializeField] GameObject noteObj13;
    [SerializeField] GameObject noteObj14;
    [SerializeField] GameObject noteObj15;
    [SerializeField] GameObject noteObj16;
    [SerializeField] GameObject noteObj17;
    [SerializeField] GameObject noteObj18;
    [SerializeField] GameObject noteObj19;
    [SerializeField] GameObject noteObj20;
    [SerializeField] GameObject noteObj21;
    [SerializeField] GameObject noteObj22;
    [SerializeField] GameObject noteObj23;
    [SerializeField] GameObject noteObj24;
    [SerializeField] GameObject noteObj25;
    [SerializeField] GameObject noteObj26;
    [SerializeField] GameObject noteObj27;
    [SerializeField] GameObject noteObj28;
    [SerializeField] GameObject noteObj29;
    [SerializeField] GameObject noteObj30;
    [SerializeField] GameObject noteObj31;
    [SerializeField] GameObject noteObj32;
    [SerializeField] GameObject noteObj33;
    [SerializeField] GameObject noteObj34;
    [SerializeField] GameObject noteObj35;
    [SerializeField] GameObject noteObj36;
    [SerializeField] GameObject noteObj37;
    [SerializeField] GameObject noteObj38;
    [SerializeField] GameObject noteObj39;
    [SerializeField] GameObject noteObj40;
    [SerializeField] GameObject noteObj41;
    

    void OnEnable()
    {
        noteNum = 0;
        songName = "Makeyouhappy_level5";//Jsonファイルの名前
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
            if(inputJson.notes[i].type==2){
                NotesObj.Add(Instantiate(noteObj2, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==3){
                NotesObj.Add(Instantiate(noteObj3, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==4){
                NotesObj.Add(Instantiate(noteObj4, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==5){
                NotesObj.Add(Instantiate(noteObj5, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==6){
                NotesObj.Add(Instantiate(noteObj6, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==7){
                NotesObj.Add(Instantiate(noteObj7, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==8){
                NotesObj.Add(Instantiate(noteObj8, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==9){
                NotesObj.Add(Instantiate(noteObj9, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==10){
                NotesObj.Add(Instantiate(noteObj10, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==11){
                NotesObj.Add(Instantiate(noteObj11, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==12){
                NotesObj.Add(Instantiate(noteObj12, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==13){
                NotesObj.Add(Instantiate(noteObj13, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==14){
                NotesObj.Add(Instantiate(noteObj14, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==15){
                NotesObj.Add(Instantiate(noteObj15, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==16){
                NotesObj.Add(Instantiate(noteObj16, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==17){
                NotesObj.Add(Instantiate(noteObj17, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==18){
                NotesObj.Add(Instantiate(noteObj18, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==19){
                NotesObj.Add(Instantiate(noteObj19, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==20){
                NotesObj.Add(Instantiate(noteObj20, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==21){
                NotesObj.Add(Instantiate(noteObj21, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==22){
                NotesObj.Add(Instantiate(noteObj22, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==23){
                NotesObj.Add(Instantiate(noteObj23, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==24){
                NotesObj.Add(Instantiate(noteObj24, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==25){
                NotesObj.Add(Instantiate(noteObj25, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==26){
                NotesObj.Add(Instantiate(noteObj26, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==27){
                NotesObj.Add(Instantiate(noteObj27, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==28){
                NotesObj.Add(Instantiate(noteObj28, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==29){
                NotesObj.Add(Instantiate(noteObj29, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==30){
                NotesObj.Add(Instantiate(noteObj30, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==31){
                NotesObj.Add(Instantiate(noteObj31, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==32){
                NotesObj.Add(Instantiate(noteObj32, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==33){
                NotesObj.Add(Instantiate(noteObj33, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==34){
                NotesObj.Add(Instantiate(noteObj34, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==35){
                NotesObj.Add(Instantiate(noteObj35, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==36){
                NotesObj.Add(Instantiate(noteObj36, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==37){
                NotesObj.Add(Instantiate(noteObj37, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==38){
                NotesObj.Add(Instantiate(noteObj38, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==39){
                NotesObj.Add(Instantiate(noteObj39, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==40){
                NotesObj.Add(Instantiate(noteObj40, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else if(inputJson.notes[i].type==41){
                NotesObj.Add(Instantiate(noteObj41, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }else{
                NotesObj.Add(Instantiate(noteObj, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));//ノーツを生成
            }  
        }
    }
}