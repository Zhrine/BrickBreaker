using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float speedChange = 150f;
    public float duration = 5f;

    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Paddle")
        {
            Paddle paddle = collision.gameObject.GetComponent<Paddle>();
            if (paddle != null)
            {
                paddle.ActivatePowerUp(speedChange, duration);
                Destroy(gameObject);
            }
        }
    }
}