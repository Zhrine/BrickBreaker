using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameData gameData;
    public GameObject ballPrefab;
    public GameObject gameOverScreen;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Deathwall")
        {
            gameData.lives--;
            if (gameData.lives > 0)
            {
                Instantiate(ballPrefab, Vector3.zero, Quaternion.identity);
            }
            else
            {
                gameOverScreen.SetActive(true);
                // Add code here to animate the game over screen
            }
            Destroy(gameObject);
        }
    }
}