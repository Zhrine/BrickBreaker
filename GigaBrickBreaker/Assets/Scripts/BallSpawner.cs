using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallSpawner : MonoBehaviour
{
    public GameData gameData;
    public GameObject ballPrefab;
    public GameObject gameOverScreen;
    public GameObject restartButton; // Reference to the restart button
    public TextMeshProUGUI timerText;
    public PowerUpSpawner powerUpSpawner; // Reference to the power-up spawner
    public Paddle paddle; // Reference to the paddle

    private void Start()
    {
        gameOverScreen.SetActive(false); // Hide the game over screen at the start
        restartButton.SetActive(false); // Hide the restart button at the start
        StartCoroutine(StartCountdown());
    }

    public IEnumerator StartCountdown()
    {
        if (gameData.lives <= 0) // Check if the game is over
        {
            gameOverScreen.SetActive(true); // Show the game over screen
            restartButton.SetActive(true); // Show the restart button
            powerUpSpawner.enabled = false; // Disable power-up spawns
            paddle.enabled = false; // Disable paddle movement
            yield break; // Exit the coroutine if the game is over
        }
        for (int i = 3; i > 0; i--)
        {
            timerText.text = i.ToString();
            yield return new WaitForSeconds(1f);
        }
        timerText.text = "";
        SpawnBall();
    }

    private void SpawnBall()
    {
        if (gameData.lives > 0)
        {
            Instantiate(ballPrefab, Vector3.zero, Quaternion.identity);
            gameOverScreen.SetActive(false); // Hide the game over screen
            restartButton.SetActive(false); // Hide the restart button
            powerUpSpawner.enabled = true; // Enable power-up spawns
            paddle.enabled = true; // Enable paddle movement
        }
        else
        {
            gameOverScreen.SetActive(true); // Show the game over screen
            restartButton.SetActive(true); // Show the restart button
            powerUpSpawner.enabled = false; // Disable power-up spawns
            paddle.enabled = false; // Disable paddle movement
            // Add code here to animate the game over screen
        }
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}