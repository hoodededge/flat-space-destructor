using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

// Load Scene Class
public class SceneLoad : MonoBehaviour
{
    [Header("--- HEALTH ---")]
    [Tooltip("Delay Before Loading:")]
    public float delayBeforeLoading = 5f;
    [Tooltip("Scene To Load:")]
    public string sceneToLoad;

    private float timeElapsed;

    public void Update()
    {
        // Countdown...
        timeElapsed += Time.deltaTime;

        // Load Scene After Time Has Elapsed.
        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}