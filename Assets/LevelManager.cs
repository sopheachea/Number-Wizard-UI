using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public void LoadLevel(string name){
		Debug.Log ("Level load request for: " + name);

		// Load scene
		Application.LoadLevel (name);
	}
		

	public void QuitRequest(){
		Debug.Log ("Quit request.");

		// this method is effects only for PC, Mac, and Linux
		// it's will not effects for mobiles app, and will eject from play store or app store
		// if you add this method to your game.
		// It also not effects on debug mode.
		Application.Quit ();
	}
}
