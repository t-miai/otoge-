using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour
{
    //変数の宣言
    [SerializeField] private GameObject[] MessageObj;//プレイヤーに判定を伝えるゲームオブジェクト
    [SerializeField] NotesManager notesManager;//スクリプト「NotesManager」を入れる変数
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (notesManager.LaneNum[0] == 0 && notesManager.NoteType[0] == 2)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (notesManager.LaneNum[0] == 0 && notesManager.NoteType[0] == 3)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.A))//〇キーが押されたとき
        {
            if (notesManager.LaneNum[0] == 0 && notesManager.NoteType[0] == 4)//押されたボタンはレーンの番号とあっているか？
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
                /*
                本来ノーツをたたく場所と実際にたたいた場所がどれくらいずれているかを求め、
                その絶対値をJudgement関数に送る
                */
            }
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (notesManager.LaneNum[0] == 0 && notesManager.NoteType[0] == 5)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (notesManager.LaneNum[0] == 1 && notesManager.NoteType[0] == 6)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (notesManager.LaneNum[0] == 1 && notesManager.NoteType[0] == 7)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (notesManager.LaneNum[0] == 1 && notesManager.NoteType[0] == 8)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (notesManager.LaneNum[0] == 1 && notesManager.NoteType[0] == 9)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (notesManager.LaneNum[0] == 2 && notesManager.NoteType[0] == 10)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (notesManager.LaneNum[0] == 2 && notesManager.NoteType[0] == 11)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (notesManager.LaneNum[0] == 2 && notesManager.NoteType[0] == 12)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (notesManager.LaneNum[0] == 2 && notesManager.NoteType[0] == 13)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (notesManager.LaneNum[0] == 3 && notesManager.NoteType[0] == 14)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (notesManager.LaneNum[0] == 3 && notesManager.NoteType[0] == 15)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (notesManager.LaneNum[0] == 3 && notesManager.NoteType[0] == 16)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (notesManager.LaneNum[0] == 3 && notesManager.NoteType[0] == 17)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (notesManager.LaneNum[0] == 3 && notesManager.NoteType[0] == 18)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (notesManager.LaneNum[0] == 3 && notesManager.NoteType[0] == 19)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (notesManager.LaneNum[0] == 3 && notesManager.NoteType[0] == 20)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (notesManager.LaneNum[0] == 3 && notesManager.NoteType[0] == 21)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            if (notesManager.LaneNum[0] == 4 && notesManager.NoteType[0] == 22)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            if (notesManager.LaneNum[0] == 4 && notesManager.NoteType[0] == 23)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (notesManager.LaneNum[0] == 4 && notesManager.NoteType[0] == 24)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (notesManager.LaneNum[0] == 4 && notesManager.NoteType[0] == 25)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            if (notesManager.LaneNum[0] == 4 && notesManager.NoteType[0] == 26)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            if (notesManager.LaneNum[0] == 4 && notesManager.NoteType[0] == 27)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (notesManager.LaneNum[0] == 4 && notesManager.NoteType[0] == 28)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (notesManager.LaneNum[0] == 4 && notesManager.NoteType[0] == 29)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            if (notesManager.LaneNum[0] == 5 && notesManager.NoteType[0] == 30)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (notesManager.LaneNum[0] == 5 && notesManager.NoteType[0] == 31)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (notesManager.LaneNum[0] == 5 && notesManager.NoteType[0] == 32)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.Comma))
        {
            if (notesManager.LaneNum[0] == 5 && notesManager.NoteType[0] == 33)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            if (notesManager.LaneNum[0] == 6 && notesManager.NoteType[0] == 34)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            if (notesManager.LaneNum[0] == 6 && notesManager.NoteType[0] == 35)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (notesManager.LaneNum[0] == 6 && notesManager.NoteType[0] == 36)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.Period))
        {
            if (notesManager.LaneNum[0] == 6 && notesManager.NoteType[0] == 37)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            if (notesManager.LaneNum[0] == 7 && notesManager.NoteType[0] == 38)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (notesManager.LaneNum[0] == 7 && notesManager.NoteType[0] == 39)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            if (notesManager.LaneNum[0] == 7 && notesManager.NoteType[0] == 40)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.Slash))
        {
            if (notesManager.LaneNum[0] == 7 && notesManager.NoteType[0] == 41)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }

        if (Time.time > notesManager.NotesTime[0] + 0.2f)//本来ノーツをたたくべき時間から0.2秒たっても入力がなかった場合
        {
            message(3);
            deleteData();
            Debug.Log("miss");
            //ミス
        }
    }
    void Judgement(float timeLag)
    {
        if (timeLag <= 0.10)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.1秒以下だったら
        {
            Debug.Log("perfect");
            message(0);
            deleteData();
        }
        else
        {
            if (timeLag <= 0.15)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.15秒以下だったら
            {
                Debug.Log("great");
                message(1);
                deleteData();
            }
            else
            {
                if (timeLag <= 0.20)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.2秒以下だったら
                {
                    Debug.Log("bad");
                    message(2);
                    deleteData();
                }
            }
        }
    }
    float GetABS(float num)//引数の絶対値を返す関数
    {
        if (num >= 0)
        {
            return num;
        }
        else
        {
            return -num;
        }
    }
    void deleteData()//すでにたたいたノーツを削除する関数
    {
        notesManager.NotesTime.RemoveAt(0);
        notesManager.LaneNum.RemoveAt(0);
        notesManager.NoteType.RemoveAt(0);
    }

    void message(int judge)//判定を表示する
    {
        Instantiate(MessageObj[judge],new Vector3(notesManager.LaneNum[0]-1.5f,0.76f,0.15f),Quaternion.Euler(45,0,0));
        //オブジェクトの生成
    }
}
