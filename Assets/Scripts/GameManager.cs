using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 5;

    // Called if the current level is complete successfully.
    public void CompleteLevel()
    {
        Debug.Log("Game Mananger, Level Complete");
    }

    // Called if the current level is failed.
    public void FailLevel()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Mananger, Level Lost");
            Invoke("Restart", restartDelay);
        }

    }

    // Restarts the current level being played.
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Game Mananger, Level Restart");
    }
}
