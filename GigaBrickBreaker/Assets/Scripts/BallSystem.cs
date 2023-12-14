using UnityEngine;

public class BallSystem : MonoBehaviour
{
    public float speed = 10f; // Speed of the ball
    private Rigidbody rb; // Reference to the Rigidbody component

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.down * speed; // Start the ball moving downwards
    }

private void OnCollisionEnter(Collision collision)
{
    Vector3 dir = Vector3.zero;

    switch (collision.gameObject.tag)
    {
        case "Right Wall":
        case "Left Wall":
            float wallAngle = Random.Range(-40, 40); // Randomly choose between -40 and 40
            dir = Quaternion.Euler(0, 0, wallAngle) * (collision.gameObject.tag == "Right Wall" ? Vector3.left : Vector3.right);
            break;
        case "Brick":
            float brickAngle = Random.Range(-40, 40); // Randomly choose between -40 and 40
            dir = Quaternion.Euler(0, 0, brickAngle) * Vector3.down; // 40 degrees from down
            break;
        case "Paddle":
            float paddleAngle = Random.Range(-20, 20); // Randomly choose between -60 and 60
            dir = Quaternion.Euler(0, 0, paddleAngle) * Vector3.up; // 60 degrees from up
            break;
    }

    rb.velocity = dir.normalized * speed;
}
}