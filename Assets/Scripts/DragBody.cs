using UnityEngine;
using System.Collections;

public class DragBody : MonoBehaviour
{

		private Vector3 screenPoint;
		private Vector3 offset;
     	public bool enabled1;

		void Start ()
		{
		enabled1 = true;
		}

		void OnMouseDown ()
		{
		
		if (enabled1) {
						if (Time.timeScale == 0) {
								Time.timeScale = 1;
						}

						offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
				}
		}
		
		void OnMouseDrag ()
		{
		if (enabled1) {
						Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
						Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
						transform.position = curPosition;
				}
		}

}
		
	
	
