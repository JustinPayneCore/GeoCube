using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject levelCompleteScreen;

    public bool gameHasEnded = false;

    public float screenDelay = 2;
    public float restartDelay = 1;
    public float levelCompleteDelay = 1;

    // Called if the current level is complete successfully.
    public void CompleteLevel()
    {
        gameHasEnded = true;
        Debug.Log("Game Mananger, Level Complete");
        Invoke("ShowLevelCompleteScreen", levelCompleteDelay);
    }

    // Called if the current level is failed.
    public void FailLevel()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Mananger, Level Lost");
            Invoke("ShowGameOverScreen", screenDelay);
        }

    }

    // Starts the next level
    public void NextLevelButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Triggers the restart function with a delay
    public void RestartButton()
    {
        Invoke("Restart", restartDelay);
    }

    // Closes the application
    public void QuitButton()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
			Application.Quit();
        #endif
    }

    // Sets the Game Over Screen to visible.
    void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }

    // Sets the Level Complete screen to visible.
    void ShowLevelCompleteScreen()
    {
        levelCompleteScreen.SetActive(true);
    }

    // Restarts the current level being played.
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Game Mananger, Level Restart");
    }
}
