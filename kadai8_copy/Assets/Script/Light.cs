using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    [SerializeField] private float Speed=3;
    [SerializeField] private int num=0;
    private Renderer rend;//Renderer:オブジェクトを描画するための処理
    private float alfa=0;
    // Start is called before the first frame update
    void Start()
    {
        rend=GetComponent<Renderer>();//unityにおいてのコンポーネントを取得
    }

    // Update is called once per frame
    void Update()
    {
        if(!(rend.material.color.a<=0)){
            rend.material.color=new Color(rend.material.color.r,rend.material.color.g,rend.material.color.b,alfa);

        }
        if(num==1){
            if(Input.GetKeyDown(KeyCode.A)){
                colorChange();
            }
        }
        if(num==2){
            if(Input.GetKeyDown(KeyCode.S)){
                colorChange();
            }
        }
        if(num==3){
            if(Input.GetKeyDown(KeyCode.D)){
                colorChange();
            }
        }
        if(num==4){
            if(Input.GetKeyDown(KeyCode.F)){
                colorChange();
            }
        }
        if(num==5){
            if(Input.GetKeyDown(KeyCode.J)){
                colorChange();
            }
        }
        if(num==6){
            if(Input.GetKeyDown(KeyCode.K)){
                colorChange();
            }
        }
        if(num==7){
            if(Input.GetKeyDown(KeyCode.L)){
                colorChange();
            }
        }
        if(num==8){
            if(Input.GetKeyDown(KeyCode.P)){
                colorChange();
            }
        }
        alfa-=Speed*Time.deltaTime;//元のレーンの色に戻っていく

    }

    void colorChange(){
        alfa=0.3f;
        rend.material.color=new Color(rend.material.color.r,rend.material.color.g,rend.material.color.b,alfa);
    }
}
