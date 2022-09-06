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
            if(Input.GetKeyDown(KeyCode.Alpha1)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.A)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.Q)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.Z)){
                colorChange();
            }
        }
        if(num==2){
            if(Input.GetKeyDown(KeyCode.Alpha2)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.W)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.S)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.X)){
                colorChange();
            }
        }
        if(num==3){
            if(Input.GetKeyDown(KeyCode.Alpha3)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.E)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.D)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.C)){
                colorChange();
            }
        }
        if(num==4){
            if(Input.GetKeyDown(KeyCode.Alpha4)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.R)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.F)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.V)){
                colorChange();
            }

            if(Input.GetKeyDown(KeyCode.Alpha5)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.T)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.G)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.B)){
                colorChange();
            }
        }
        if(num==5){
            if(Input.GetKeyDown(KeyCode.Alpha6)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.Y)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.H)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.N)){
                colorChange();
            }

            if(Input.GetKeyDown(KeyCode.Alpha7)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.U)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.J)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.M)){
                colorChange();
            }
        }
        if(num==6){
            if(Input.GetKeyDown(KeyCode.Alpha8)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.A)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.K)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.Comma)){
                colorChange();
            }
        }
        if(num==7){
            if(Input.GetKeyDown(KeyCode.Alpha9)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.O)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.L)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.Period)){
                colorChange();
            }
        }
        if(num==8){
            if(Input.GetKeyDown(KeyCode.Alpha0)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.P)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.Semicolon)){
                colorChange();
            }
            if(Input.GetKeyDown(KeyCode.Slash)){
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
