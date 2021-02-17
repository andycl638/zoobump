using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class GrabHighScore : MonoBehaviour
{
	[SerializeField]
	TextMeshPro hsText;

	// Use this for initialization
	void Start () {
		hsText.text = ((int)PlayerPrefs.GetFloat("highScore")).ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
