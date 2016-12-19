using UnityEngine;
using System.Collections;

public class LoadSceneMenu : MonoBehaviour {

	int Level;

	public void loadScene(int level){

		Invoke ("wait", 7);
		Level = level;

	}

	void wait(){

		Application.LoadLevel (Level);
	}



}
