using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonScript : MonoBehaviour
{
    public void OnClick(){
        Debug.Log("押された！");
        SceneManager.LoadScene ("Level1");
    }
}
