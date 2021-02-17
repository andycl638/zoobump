using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateGuiText : MonoBehaviour {

	Text theText;
	// Use this for initialization
	void Start () {
		//this.myText = this.GetComponent<Text>();
		if (gameObject.name.Contains ("UITimer")) {
				theText = GameObject.Find ("UITimer").GetComponent<Text> ();
		} else {
				theText = GameObject.Find ("UIHighScore").GetComponent<Text> ();
		}
				
	}
	
	// Update is called once per frame
	void Update () {
			//myText.text = theText.text ;
	}
}
