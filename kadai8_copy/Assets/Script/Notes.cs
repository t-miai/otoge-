using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour//MonoBehaviourを継承
{
    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/
    int NoteSpeed=8;
    // Update is called once per frame
    void Update()
    {
        transform.position-=transform.forward*Time.deltaTime*NoteSpeed;//ノーツのZ座標の位置を変化
        //transform.forwardは向きの取得
        //Time.deltaTimeは最後のフレームからの経過時間
        //フレームはアップデート関数で行われる一連の流れ
    }
}
