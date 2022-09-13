using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class SceneChange : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
 
 		//1キーが押されたらScene1に切り替える
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			SceneManager.LoadScene ("Level1");
		}	
		//2キーが押されたらScene2に切り替える
		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			SceneManager.LoadScene ("Level2");
		}	

		//3キーが押されたらScene3に切り替える
		if (Input.GetKeyDown(KeyCode.Alpha3)) {
			SceneManager.LoadScene ("Level3");
		}	
		//4キーが押されたらScene4に切り替える
		if (Input.GetKeyDown(KeyCode.Alpha4)) {
			SceneManager.LoadScene ("Level4");
		}

		//5キーが押されたらScene5に切り替える
		if (Input.GetKeyDown(KeyCode.Alpha5)) {
			SceneManager.LoadScene ("Level5");
		}

        if (Input.GetKeyDown(KeyCode.Alpha6)) {
			SceneManager.LoadScene ("Level6");
		}	

	}
}