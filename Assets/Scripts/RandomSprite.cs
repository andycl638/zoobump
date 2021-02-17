using UnityEngine;
using System.Collections;

public class RandomSprite : MonoBehaviour {


	public Sprite[] theSprites;
	public Sprite chosen;
	// Use this for initialization
	void Start () {


		DontDestroyOnLoad (this);

	}

	void OnLevelWasLoaded(int level){

				if (level == 1 || level == 2) {


			InstantiateSprites();

				}
		}

	private void InstantiateSprites()
	{


		theSprites = Resources.LoadAll<Sprite> ("Textures/Character");
		Debug.Log (theSprites.Length);
		chosen = theSprites [Random.Range (0, 3)];


		}
	// Update is called once per frame
	void Update () {
	
	}
}
