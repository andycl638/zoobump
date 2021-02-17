using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using TMPro;

public class GMScript : MonoBehaviour {

	float originalWidth = 1920.0f;  // define here the original resolution
	float originalHeight = 1080.0f; // you used to create the GUI contents 
	private Vector3 scale;


	[SerializeField]
	private TextMeshProUGUI timer;
	private float currTime;
	private float highScore;

	[SerializeField]
	private TextMeshProUGUI UIHighScore;

	[SerializeField]
	private GameObject TouchBallToStartUI;


	public GameObject zooball;
	public int random;

	// Use this for initialization
	void Start()
	{
		Time.timeScale = 0;
		highScore = PlayerPrefs.GetFloat("highScore");

		UIHighScore.text = ((int)highScore).ToString();

		currTime = 0;
		GameObject[] spawnLocations = GameObject.FindGameObjectsWithTag("Respawn");
		random = UnityEngine.Random.Range(0, spawnLocations.Length);


		zooball.transform.position = spawnLocations[random].transform.position;
		Camera.main.transform.position = new Vector3(spawnLocations[random].transform.position.x, spawnLocations[random].transform.position.y, Camera.main.transform.position.z);

		SpriteRenderer newOne = zooball.GetComponent<SpriteRenderer>();
		if (GameObject.Find("RandomSprite") != null)
		{
			newOne.sprite = GameObject.Find("RandomSprite").GetComponent<RandomSprite>().chosen;
		}
	}
	// Update is called once per frame
	void Update () 
	{

		if (Application.platform == RuntimePlatform.Android)
		{
			if (Input.GetKey(KeyCode.Escape))
			{
				// Insert Code Here (I.E. Load Scene, Etc)
				UnityEngine.SceneManagement.SceneManager.LoadScene(0);

				return;
			}

		}

		if (currTime > 0)
		{
			TouchBallToStartUI.SetActive(false);
		}
		if (Time.timeScale == 1)
		{
			currTime += Time.deltaTime;
			if (currTime > highScore)
			{
				PlayerPrefs.SetFloat("highScore", currTime);
				UIHighScore.text = ((int)currTime).ToString();
			}
			timer.text = ((int)currTime).ToString();


		}
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
	}

	public float getTime()
	{
		return currTime;
	}
	

}
