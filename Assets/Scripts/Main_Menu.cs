using UnityEngine;
using System.Collections;

public class Main_Menu : MonoBehaviour {

	public GameObject startButton;
	public GameObject quitButton;
	public GameObject beginButton;
	public GameObject marcus;
	public GameObject ayame;
	public GameObject mSpotlight;
	public GameObject aSpotlight;
	private Transform marcusORotation;
	private Transform ayameORotation;
	private bool changePlayer;

	public float turnSpeed = 20f;

	void Start(){
		marcusORotation = marcus.transform;
		ayameORotation = ayame.transform;
		changePlayer = true;
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
		{
			if(changePlayer)
				changePlayer = false;
			else
				changePlayer = true;
		}

		if(changePlayer){
			rotateMarcus();
			ApplicationModel.character = "Marcus";
			ayame.transform.rotation = new Quaternion( 0, ayameORotation.rotation.y, 0, 0);
		}
		else
		{
			rotateAyame();
			ApplicationModel.character = "Ayame";
			marcus.transform.rotation = new Quaternion( 0, marcusORotation.rotation.y, 0, 0);
		}


	}

	public void StartGame(){
		startButton.SetActive(false);
		quitButton.SetActive(false);
		beginButton.SetActive(true);
		marcus.SetActive(true);
		ayame.SetActive(true);
		mSpotlight.SetActive(true);
		aSpotlight.SetActive(true);
	}

	public void Quit(){
		Application.Quit();
	}

	public void Begin(){
		Application.LoadLevel("Fetch_The_Ship");
	}

	private void rotateMarcus(){
		marcus.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
	}

	private void rotateAyame(){
		ayame.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
	}


}
