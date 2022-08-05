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
        if (Input.GetKeyDown(KeyCode.A))//〇キーが押されたとき
        {
            if (notesManager.LaneNum[0] == 0)//押されたボタンはレーンの番号とあっているか？
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
                /*
                本来ノーツをたたく場所と実際にたたいた場所がどれくらいずれているかを求め、
                その絶対値をJudgement関数に送る
                */
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (notesManager.LaneNum[0] == 1)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (notesManager.LaneNum[0] == 2)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (notesManager.LaneNum[0] == 3)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (notesManager.LaneNum[0] == 4)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (notesManager.LaneNum[0] == 5)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (notesManager.LaneNum[0] == 6)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0]));
            }
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (notesManager.LaneNum[0] == 7)
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
