using UnityEngine;
using System.Collections;

public class GUIAspectRatioSize : MonoBehaviour {


	public Vector2 scaleOnRatio1 = new Vector2(0.1f, 0.2f);
	private Transform myTrans;
	private float widthHeightRatio;

	// Use this for initialization
	void Start () {
		myTrans = transform;
		SetScale ();
	}
	
	// Update is called once per frame
	void Update () {
		SetScale ();
	}

	void SetScale()
	{

		widthHeightRatio = (float)Screen.width / Screen.height * Screen.height;

		myTrans.localScale = new Vector3 (scaleOnRatio1.x, widthHeightRatio * scaleOnRatio1.y, 1);
	}
}
