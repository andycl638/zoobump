using UnityEngine;
using UnityEngine.UI;

public class GuiResize : MonoBehaviour 
{
	public int scale;

	void Start()
	{
				Text myText = GetComponent<Text>();
	
				// 50 is the fontsize you want to use
				myText.fontSize = Mathf.Min (Screen.height, Screen.width) / scale;
		}

}