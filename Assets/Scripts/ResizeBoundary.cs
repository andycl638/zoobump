using UnityEngine;
using System.Collections;


public class ResizeBoundary : MonoBehaviour {


	float orthoVertical;
	float orthoHorizontal;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	

		BoxCollider2D[] myColliders = gameObject.GetComponents<BoxCollider2D>();
		bool negX = false;
		bool negY = false;
		foreach(BoxCollider2D theCol in myColliders)
		{


			if(Mathf.Abs(theCol.size.y) > Mathf.Abs(theCol.size.x))
			{
				Camera cam = Camera.main;

				float height = 2f * cam.orthographicSize;


				float width = height * cam.aspect;
				if(negX == true)
					width = width * -1;

			//theCol.center = new Vector2(0, 0);
				Vector2 newCen = new Vector2(width/2, theCol.offset.y);
				theCol.offset = newCen;
				negX = true;
			}

			if(Mathf.Abs(theCol.size.x) > Mathf.Abs(theCol.size.y))
			{
				Camera cam = Camera.main;
				
				float height = 2f * cam.orthographicSize;

				if(negY == true)
					height = height *-1;
				//theCol.center = new Vector2(0, 0);
				Vector2 newCen = new Vector2(theCol.offset.x, height/2);
				
				theCol.offset = newCen;
				negY= true;
			}
			
		}

	}
}
