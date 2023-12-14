using UnityEngine;

public class Deathwall : MonoBehaviour
{
    public BallSpawner ballSpawner;
    public GameData gameData;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(collision.gameObject);
            gameData.lives--; // Decrease the number of lives
            ballSpawner.StartCoroutine(ballSpawner.StartCountdown());
        }
    }
}