using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// High Score Display
public class HighScoreDisplay : UIelement
{
    [Tooltip("The Text UI to use for display")]
    public Text displayText = null;

    // Display High Score Function
    public void DisplayHighScore()
    {
        if (displayText != null)
        {
            displayText.text = "HI-SCORE x " + GameManager.instance.highScore.ToString();
        }
    }

    // Update UI Function
    public override void UpdateUI()
    {
        // Updates UI in-game
        base.UpdateUI();

        // Display High Score Updates
        DisplayHighScore();
    }
}
