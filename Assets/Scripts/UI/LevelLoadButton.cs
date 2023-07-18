using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Level Load Button Class
public class LevelLoadButton : MonoBehaviour
{
    // Level
    /// <param name="levelToLoadName">The name of the level to load</param>
    public void LoadLevelByName(string levelToLoadName)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(levelToLoadName);
    }
}
