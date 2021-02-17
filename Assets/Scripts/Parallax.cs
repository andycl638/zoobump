using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {

	bool seen = false;
	public float speed = 0;
	Vector3 startPos;
	// Use this for initialization
	void Start () {
		startPos = transform.position;

	}

	void Update() {


		goCloud ();

			if (GetComponent<Renderer>().isVisible) {
						seen = true;
				}	
			if (seen && !GetComponent<Renderer>().isVisible) {



			transform.position = startPos;
			seen = false;
				}


	// Update is called once per frame
	}


	void goCloud()
	{

		Vector3 temp = transform.position; 
		temp.x = temp.x + (Time.deltaTime + speed); 
		transform.position = temp;



	}
}