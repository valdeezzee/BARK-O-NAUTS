using UnityEngine;
using System.Collections;

public class Main_Menu : MonoBehaviour {



	public void StartGame(){

		Application.LoadLevel("Fetch_The_Ship");
	}

	public void Quit(){
		Application.Quit();
	}
}
