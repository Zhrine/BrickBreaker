using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Paddle : MonoBehaviour
{
    public Rigidbody rigidbody {get; private set;}
    public Vector3 Direction {get; private set;}
    public float speed = 80f;
    public float minX = -32f; // Minimum x-coordinate the paddle can move to
    public float maxX = 32f; // Maximum x-coordinate the paddle can move to
    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.Direction = Vector3.left;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.Direction = Vector3.right;
        }
        else
        {
            this.Direction = Vector3.zero;
        }
    }

      private void FixedUpdate()
    {
        Vector3 movement = this.Direction * speed * Time.fixedDeltaTime;
        this.rigidbody.velocity = movement;

        // Clamp the paddle's position
        Vector3 position = this.rigidbody.position;
        position.x = Mathf.Clamp(position.x, minX, maxX);
        this.rigidbody.position = position;
    }
    public void ActivatePowerUp(float speedChange, float duration)
    {
        StartCoroutine(PowerUp(speedChange, duration));
    }

    private IEnumerator PowerUp(float speedChange, float duration)
    {
        speed += speedChange;
        yield return new WaitForSeconds(duration);
        speed -= speedChange;
    }
}