using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 2f; // Public variable for restart delay

    // Singleton pattern to ensure only one instance of GameManager
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        // If there is an instance, and it's not this, delete this instance
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void EndGame()
    {
        StartCoroutine(RestartGameAfterDelay());
    }

    private IEnumerator RestartGameAfterDelay()
    {
        Debug.Log("Game Over! Restarting in " + restartDelay + " seconds.");
        yield return new WaitForSeconds(restartDelay);
        RestartGame();
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}