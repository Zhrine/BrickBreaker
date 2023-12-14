using UnityEngine;

public class BrickSystem : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            switch (GetComponent<Renderer>().material.color)
            {
                case var color when color == Color.red:
                    GetComponent<Renderer>().material.color = Color.yellow;
                    break;
                case var color when color == Color.yellow:
                    Destroy(gameObject);
                    break;
                default:
                    GetComponent<Renderer>().material.color = Color.red;
                    break;
            }
        }
    }
}