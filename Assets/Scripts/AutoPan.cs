using UnityEngine;
using System.Collections;

public class AutoPan : MonoBehaviour {


    public Vector3 speed;
	public int multiplier;
	float timing;
	public float range;





	private float halfWidth;
	private float halfHeight;
		//calculate Terrain bounds

	// Use this for initialization
	void Start () {

		halfWidth = Camera.main.orthographicSize * Screen.width / Screen.height;
		halfHeight = Camera.main.orthographicSize;


	    
		//Vector3 x = theRend.bounds.size;

		speed = new Vector3(Random.Range (-1*range,range), Random.Range (-1*range, range), 0);
		timing = 0;

		Debug.Log (halfWidth);
	
	
	}
	
	// Update is called once per frame
	void Update () {
	
		timing += Time.deltaTime;
		transform.Translate( speed * Time.deltaTime);
		if(timing > 2 ){
			ChangeDirection();
				timing = 0;
		}
		if (transform.position.x > 25 - halfWidth) {
			
			speed = new Vector3 (Random.Range(-1*range*multiplier,1), speed.y);
			
		}
		if (transform.position.x < -1 * (25 - halfWidth)) {


			speed = new Vector3(Random.Range (1,range*multiplier), speed.y);

				}
		if (transform.position.y > 25 - halfHeight) {

			speed = new Vector3 (speed.x, Random.Range(-1*range*multiplier,1));

				}

		if (transform.position.y < -1 * (25 - halfHeight)) {
			
			
			speed = new Vector3(speed.x, Random.Range (1,range*multiplier));
			
		}







	}

		void ChangeDirection(){

		speed = new Vector3(Random.Range (-1*range*multiplier,range*multiplier), Random.Range (-1*range*multiplier, range*multiplier), 0);


		if (speed.x == 0 && speed.y == 0) {

		

		

			speed = new Vector3(Random.Range (-1*range,range), Random.Range (-1*range, range), 0);

				}



		}
	}

