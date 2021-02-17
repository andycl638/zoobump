using UnityEngine;
using System.Collections;

public class WallCollide : MonoBehaviour {

	GameObject timer;
	GameObject zooball;
	public GameObject GameOverScreen;
	DragBody script;

	// Use this for initialization
	void Start () {
		timer = GameObject.Find ("_GM");
		GameOverScreen = GameObject.Find ("GameOver"); 
		zooball = GameObject.Find ("zooball");
		script = zooball.GetComponent<DragBody> ();
	}
	
	// Update is called once per frame
	void Update () {
	


	}



	void OnCollisionEnter2D(Collision2D collision){



				if (collision.collider.name == "zooball") {

						
						Debug.Log ("Hit Wall");

						GMScript theScript = timer.GetComponent<GMScript> ();
						float theTime = theScript.getTime ();

			script.enabled1 = false;

			GetComponent<AudioSource>().Play();

						if (PlayerPrefs.GetFloat ("highScore") < theTime) {

								PlayerPrefs.SetFloat ("highScore", theTime);

						}
			//GameOverScreen
						//Application.LoadLevel(Application.loadedLevel);


						
					//	transform.gameObject.AddComponent<GameOverScript> ();
			GameObject go = Instantiate(Resources.Load("Textures/Screen/gameOverTextPref")) as GameObject;
			GameObject go2 = Instantiate(Resources.Load ("Textures/Screen/playAgainTextPref")) as GameObject;
			GameObject go3 = Instantiate (Resources.Load ("Textures/Screen/highScorePref")) as GameObject;
						Time.timeScale = 0;


            GameObject.Destroy(GameObject.Find("UITimer"));
            GameObject.Destroy(GameObject.Find("UITimer2"));
            GameObject.Destroy(GameObject.Find("UITimer3"));

        }

		}




}
