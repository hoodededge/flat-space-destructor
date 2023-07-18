using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Score Display
public class ScoreDisplay : UIelement
{
    [Tooltip("The text UI to use for display")]
    public Text displayText = null;

    // Display Score Function
    public void DisplayScore()
    {
        if (displayText != null)
        {
            displayText.text = "SCORE x " + GameManager.score.ToString();
        }
    }

    // Update UI Function
    public override void UpdateUI()
    {
        // Updates UI in-game
        base.UpdateUI();

        // Display Score Updates
        DisplayScore();
    }
}
