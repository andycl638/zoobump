using UnityEngine;
using System.Collections;

public class PlayerController2 : MonoBehaviour {



	public KeyCode attackButton;

	//Animator moveAnim;
	public Vector2 speed = new Vector2(5,5);
	float lastInputX ;
	float lastInputY ;
	public float veloPlayer;
	//CircleCollider2D myCollider;
	// Use this for initialization
	void Start () {
	//	moveAnim = GetComponent<Animator> ();
		//myCollider = transform.GetComponent<CircleCollider2D>();
	}

	void move() {

				/*if (Input.mousePosition.x < myCollider.radius && Input.mousePosition.x > myCollider.radius * -1 
						&& Input.mousePosition.y < myCollider.radius && Input.mousePosition.y > myCollider.radius * -1) {
*/
						if (Input.GetMouseButton (0)) {
								System.Console.WriteLine ("MousePRessed");

								//float zPos = transform.position.z;

								transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10));
								//	transform.position.z = zPos;
								 
								
								//transform.position = Camera.main.ScreenToWorldPoint(transformCurr);
								
						}
		


						//}
				}
		
	/*
	void attack() {
		GameObject sword = GameObject.Find("master_sword");
		Animator swordAnim = sword.GetComponent<Animator>();

		if (Input.GetKey (attackButton)) {
						//moveAnim.SetBool ("attack", true);
						//animation.Play ("Attack");


			swordAnim.SetBool("attack", true);

				} else {
			swordAnim.SetBool("attack", false);

				}
			//moveAnim.SetBool ("attack", false);

	}
	*/
	// Update is called once per frame
	void Update () {
	

		move ();
		//attack ();

	}
	/*
	void FixedUpdate() {

		//float lastInputX = Input.GetAxis ("Horizontal");
		//float lastInputY = Input.GetAxis ("Vertical");



		if (lastInputX != 0 || lastInputY != 0) {
						moveAnim.SetBool ("walking", true);
			if(lastInputX > 0){
				moveAnim.SetFloat("lastmoveX",1f);
			}else if (lastInputX< 0){
				moveAnim.SetFloat("lastmoveX",-1f);}
				else{
					moveAnim.SetFloat("lastmoveX",0f);
				}

			if(lastInputY > 0){
				moveAnim.SetFloat("lastmoveY",1f);
			}else if (lastInputY< 0){
				moveAnim.SetFloat("lastmoveY",-1f);}
			else{
				moveAnim.SetFloat("lastmoveY",0f);
			}

				} else {
						moveAnim.SetBool ("walking", false);
				}

	}
	*/
}
