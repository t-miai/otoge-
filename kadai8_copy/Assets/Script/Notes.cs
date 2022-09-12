using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour//MonoBehaviourを継承
{
    // Start is called before the first frame update
    /*void Start()
    {
        var rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezePositionX;
        rb.constraints = RigidbodyConstraints.FreezePositionY;
        
    }*/
    int NoteSpeed=6;
    // Update is called once per frame
    void Update()
    {
        //Vector3 pos = transform.position;
        //pos.z = pos.z -transform.forward*Time.deltaTime*NoteSpeed;
        //transform.position = pos;

        transform.position-=transform.forward*Time.deltaTime*NoteSpeed;//ノーツのZ座標の位置を変化
        //transform.forwardは向きの取得
        //Time.deltaTimeは最後のフレームからの経過時間
        //フレームはアップデート関数で行われる一連の流れ
    }
}
