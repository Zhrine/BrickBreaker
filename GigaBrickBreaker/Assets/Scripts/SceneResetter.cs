using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneResetter : MonoBehaviour
{
    public GameData gameData; // Reference to the GameData instance

    public void ResetScene()
    {
        if (gameData.lives <= 0) // Check if the player had 0 lives
        {
            gameData.lives = 3; // Reset the lives to 3
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}