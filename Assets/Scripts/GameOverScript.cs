﻿using UnityEngine;
using System.Collections;

/// <summary>
/// Start or quit the game
/// </summary>
public class GameOverScript : MonoBehaviour
{

    void Start()
    {
        this.enabled = false;
    }

    void Update()
    {
        if (Time.timeScale == 0 && this.enabled == false)
        {
            this.enabled = true;
        }
    }

    /*

	void OnGUI()
	{

				const int buttonWidth = 120;
				const int buttonHeight = 60;


				if (
			GUI.Button (
			// Center in X, 1/3 of the height in Y
			new Rect (
			Screen.width / 2 - (buttonWidth / 2),
			(1 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
				),
			"Retry!"
				)
			) {
						// Reload the level

						Application.LoadLevel ("playgame");
				}

				if (
			GUI.Button (
			// Center in X, 2/3 of the height in Y
			new Rect (
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
				),
			"Back to menu"
				)
			) {
						// Reload the level
						Application.LoadLevel ("titlescreen");
				}

				
		}	
*/


}